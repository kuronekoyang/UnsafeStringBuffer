//#define ENABLE_MULTITHREAD_UNSAFE_STRING_BUFFER

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Unity.Collections.LowLevel.Unsafe;

namespace kuro
{
    public unsafe partial struct UnsafeStringBuffer : IEquatable<UnsafeStringBuffer>, IDisposable
    {
        private static readonly BufferPool s_pool = new();

        private string _buffer;
        private int _capacity;
        private int _length;
        private string _copy;

        public bool IsEmpty
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _length <= 0;
        }

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _length;
        }

        public int Capacity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _capacity;
        }

        public char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalBuffer[index];
        }

        public string InternalBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _buffer ?? string.Empty;
        }

        public string StringCopy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IsEmpty ? string.Empty : (_copy ??= new string(InternalBuffer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<char> AsSpan() => InternalBuffer.AsSpan();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<char> AsSpan(int start) => InternalBuffer.AsSpan().Slice(start);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<char> AsSpan(int start, int length) => InternalBuffer.AsSpan().Slice(start, length);

        public UnsafeStringBuffer(string value) : this() => SetString(value);
        public UnsafeStringBuffer(string value, int index) : this() => SetString(value, index);
        public UnsafeStringBuffer(string value, int index, int length) : this() => SetString(value, index, length);
        public UnsafeStringBuffer(char[] value) : this() => SetString(value);
        public UnsafeStringBuffer(char[] value, int index) : this() => SetString(value, index);
        public UnsafeStringBuffer(char[] value, int index, int length) : this() => SetString(value, index, length);
        public UnsafeStringBuffer(ReadOnlySpan<char> value) : this() => SetString(value);
        public UnsafeStringBuffer(char* value, int length) : this() => SetString(value, length);
        public UnsafeStringBuffer(IntPtr value, int length) : this() => SetString(value, length);

        public UnsafeStringBuffer(char value) : this() => SetString(value);
        public UnsafeStringBuffer(char value, int length) : this() => SetString(value, length);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(string value) => SetString(value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(string value, int index) => SetString(value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(string value, int index, int length) => SetString(value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(char[] value) => SetString(value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(char[] value, int index) => SetString(value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(char[] value, int index, int length) => SetString(value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(ReadOnlySpan<char> value)
        {
            if (!value.IsEmpty)
            {
                fixed (char* ptr = value)
                    SetString(ptr, value.Length);
            }
            else
            {
                SetString((char*)null, 0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(IntPtr value, int length) => SetString((char*)value.ToPointer(), length);

        public void SetString(char* value, int length)
        {
            using var safe = new SafeMemorySegment(this, value, length);
            var span = safe.AsSpan();
            Resize(length);

            if (length > 0 && !span.IsEmpty)
                fixed (char* ptr = _buffer)
                fixed (char* source = span)
                    UnsafeUtility.MemCpy(ptr, source, sizeof(char) * length);

            _copy = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(char value) => SetString(value, 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetString(char value, int length)
        {
            Resize(length);

            if (length > 0)
            {
                fixed (char* ptr = _buffer)
                    for (int i = 0; i < length; i++)
                        ptr[i] = value;
            }

            _copy = null;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(string value) => Append(value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(string value, int index) => Append(value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(string value, int index, int length) => Append(value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(char[] value) => Append(value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(char[] value, int index) => Append(value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(char[] value, int index, int length) => Append(value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(ReadOnlySpan<char> value)
        {
            if (value.IsEmpty)
                return;
            fixed (char* ptr = value)
                Append(ptr, value.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(IntPtr value, int length) => Append((char*)value.ToPointer(), length);

        public void Append(char* value, int length)
        {
            if (value == null || length <= 0)
                return;
            using var safe = new SafeMemorySegment(this, value, length);
            var span = safe.AsSpan();
            var oldLength = _length;
            Resize(oldLength + length);

            fixed (char* ptr = _buffer)
            fixed (char* source = span)
                UnsafeUtility.MemCpy((ptr + oldLength), source, sizeof(char) * length);

            _copy = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(char value) => Append(value, 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append(char value, int length)
        {
            var oldLength = _length;
            Resize(oldLength + length);

            if (length > 0)
                fixed (char* ptr = _buffer)
                    for (int i = 0; i < length; i++)
                        ptr[oldLength + i] = value;

            _copy = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendUtf8(ReadOnlySpan<byte> value)
        {
            if (value.IsEmpty)
                return;
            fixed (byte* ptr = value)
                AppendUtf8(ptr, value.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendUtf8(IntPtr value, int length) => AppendUtf8((byte*)value.ToPointer(), length);

        public void AppendUtf8(byte* value, int length)
        {
            if (value == null)
                return;
            var encoding = Encoding.UTF8;
            var maxCharCount = encoding.GetMaxCharCount(length);
            var charBuffer = ArrayPool<char>.Shared.Rent(maxCharCount);
            try
            {
                fixed (char* charPtr = charBuffer)
                {
                    var charCount = encoding.GetChars(value, length, charPtr, maxCharCount);
                    Append(charBuffer, 0, charCount);
                }
            }
            finally
            {
                ArrayPool<char>.Shared.Return(charBuffer);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, string value) => Insert(insertIndex, value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, string value, int index) => Insert(insertIndex, value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, string value, int index, int length) => Insert(insertIndex, value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, char[] value) => Insert(insertIndex, value != null ? value.AsSpan() : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, char[] value, int index) => Insert(insertIndex, value != null ? value.AsSpan(index) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, char[] value, int index, int length) => Insert(insertIndex, value != null ? value.AsSpan(index, length) : ReadOnlySpan<char>.Empty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, ReadOnlySpan<char> value)
        {
            fixed (char* ptr = value)
                Insert(insertIndex, ptr, value.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, IntPtr value, int length) => Insert(insertIndex, (char*)value.ToPointer(), length);

        public void Insert(int insertIndex, char* value, int length)
        {
            if (value == null || length <= 0)
                return;
            if (insertIndex < 0 || insertIndex > _length)
                throw new ArgumentOutOfRangeException(nameof(insertIndex));

            using var safe = new SafeMemorySegment(this, value, length);
            var span = safe.AsSpan();
            var oldLength = _length;
            Resize(oldLength + length);

            fixed (char* ptr = _buffer)
            fixed (char* source = span)
            {
                if (oldLength > insertIndex)
                    UnsafeUtility.MemCpy((ptr + insertIndex + length), (ptr + insertIndex), sizeof(char) * (oldLength - insertIndex));
                UnsafeUtility.MemCpy((ptr + insertIndex), source, sizeof(char) * length);
            }

            _copy = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, char value) => Insert(insertIndex, value, 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int insertIndex, char value, int length)
        {
            if (insertIndex < 0 || insertIndex > _length)
                throw new ArgumentOutOfRangeException(nameof(insertIndex));

            var oldLength = _length;
            Resize(oldLength + length);

            if (length > 0)
                fixed (char* ptr = _buffer)
                {
                    if (oldLength > insertIndex)
                        UnsafeUtility.MemCpy((ptr + insertIndex + length), (ptr + insertIndex), sizeof(char) * (oldLength - insertIndex));
                    for (int i = 0; i < length; i++)
                        ptr[oldLength + i] = value;
                }

            _copy = null;
        }

        public int RemoveAll(char value)
        {
            if (IsEmpty)
                return 0;

            fixed (char* ptr = _buffer)
            {
                int index1 = 0;
                while (index1 < _length && ptr[index1] != value)
                    ++index1;
                if (index1 >= _length)
                    return 0;
                int index2 = index1 + 1;
                while (index2 < _length)
                {
                    while (index2 < _length && ptr[index2] == value)
                        ++index2;
                    if (index2 < _length)
                        ptr[index1++] = ptr[index2++];
                }

                var num = _length - index1;
                if (index1 <= 0)
                {
                    Clear();
                }
                else
                {
                    UnsafeUtility.MemClear((ptr + index1), sizeof(char) * (_length - index1));
                    _length = index1;
                    SetBufferLength(_buffer, index1);
                }

                return num;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Remove(int index) => Remove(index, Length - index - 1);

        public void Remove(int index, int count)
        {
            if (IsEmpty)
                return;
            if (count <= 0)
                return;
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (_length - index < count)
                throw new ArgumentOutOfRangeException(nameof(count));
            _length -= count;
            SetBufferLength(_buffer, _length);
            fixed (char* ptr = _buffer)
            {
                if (index < _length)
                    UnsafeUtility.MemCpy((ptr + index), (ptr + index + count), sizeof(char) * (_length - index));
                UnsafeUtility.MemClear((ptr + _length), sizeof(char) * count);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            if (_buffer != null)
            {
                s_pool.Return(_buffer, _capacity);
                _buffer = null;
            }

            _length = 0;
            _capacity = 0;
            _copy = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Resize(int newSize)
        {
            if (newSize <= 0)
            {
                Clear();
            }
            else if (_buffer != null && newSize <= _capacity)
            {
                if (newSize < _length)
                {
                    fixed (char* ptr = _buffer)
                        UnsafeUtility.MemClear((ptr + newSize), sizeof(char) * (_length - newSize));
                }

                // do nothing
                _length = newSize;
                SetBufferLength(_buffer, newSize);
            }
            else
            {
                s_pool.Rent(newSize, out var newBuffer, out var newCapacity);
                if (_buffer != null)
                {
                    fixed (char* ptr = _buffer)
                    fixed (char* newPtr = newBuffer)
                        UnsafeUtility.MemCpy(newPtr, ptr, sizeof(char) * _capacity);
                    s_pool.Return(_buffer, _capacity);
                }

                _buffer = newBuffer;
                _capacity = newCapacity;
                _length = newSize;
                SetBufferLength(_buffer, newSize);
            }
        }

        // 有点危险
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // public static implicit operator string(StringBuffer value) => value.StringReference;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ReadOnlySpan<char>(UnsafeStringBuffer value) => value.AsSpan();

        // 有点危险
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // public static implicit operator PooledString(string value) => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(UnsafeStringBuffer a, UnsafeStringBuffer b) => string.Equals(a.InternalBuffer, b.InternalBuffer, StringComparison.Ordinal);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(UnsafeStringBuffer a, UnsafeStringBuffer b) => !(a == b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(UnsafeStringBuffer a, string b) => string.Equals(a.InternalBuffer, b, StringComparison.Ordinal);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(UnsafeStringBuffer a, string b) => !(a == b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(string a, UnsafeStringBuffer b) => string.Equals(a, b.InternalBuffer, StringComparison.Ordinal);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(string a, UnsafeStringBuffer b) => !(a == b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(UnsafeStringBuffer a, ReadOnlySpan<char> b) => a.AsSpan().SequenceEqual(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(UnsafeStringBuffer a, ReadOnlySpan<char> b) => !(a == b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ReadOnlySpan<char> a, UnsafeStringBuffer b) => a.SequenceEqual(b.AsSpan());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ReadOnlySpan<char> a, UnsafeStringBuffer b) => !(a == b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UnsafeStringBuffer other) => this == other;

        public override bool Equals(object other)
        {
            if (other is UnsafeStringBuffer pooledString)
                return this == pooledString;
            if (other is string s)
                return this == s;
            return false;
        }

        public override int GetHashCode() => InternalBuffer.GetHashCode();
        public override string ToString() => InternalBuffer;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose() => Clear();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void SetBufferLength(string str, int length)
        {
            var dummy = UnsafeUtility.As<string, DummyString>(ref str);
            dummy.Length = length;
        }


        private readonly struct SafeMemorySegment : IDisposable
        {
            private readonly UnsafeStringBuffer? _tempBuffer;
            private readonly char* _value;
            private readonly int _length;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ReadOnlySpan<char> AsSpan()
            {
                if (_tempBuffer.HasValue)
                    return _tempBuffer.Value.AsSpan();
                if (_value != null && _length > 0)
                    return new ReadOnlySpan<char>(_value, _length);
                return ReadOnlySpan<char>.Empty;
            }

            public SafeMemorySegment(UnsafeStringBuffer owner, char* value, int length)
            {
                _tempBuffer = null;
                _value = value;
                _length = length;
                if (length > 0 && value != null && owner._buffer != null)
                    fixed (char* ptr = owner._buffer)
                        if (ptr <= value && value < ptr + owner._capacity)
                            _tempBuffer = new(value, length);
            }

            public void Dispose()
            {
                _tempBuffer?.Dispose();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private class DummyString
        {
            public int Length;
            public char FirstChar;
        }

        private class BufferPool
        {
            private static readonly string s_emptyBuffer = new("");
            private readonly int _maxBuffersPerBucket = 50;
            private readonly List<string>[] _buckets;

            public BufferPool(int maxBuffersPerBucket = 50)
            {
                _maxBuffersPerBucket = maxBuffersPerBucket;
                _buckets = new List<string>[16];
                for (int i = 0; i < _buckets.Length; i++)
                    _buckets[i] = new List<string>(8);
            }

            public void Rent(int minimumLength, out string buffer, out int capacity)
            {
                if (minimumLength < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(minimumLength));
                }

                if (minimumLength == 0)
                {
                    buffer = s_emptyBuffer;
                    capacity = 0;
                    return;
                }

                var size = CalculateSize(minimumLength);
                var index = GetQueueIndex(size);
                if (index != -1)
                {
                    var q = _buckets[index];
#if ENABLE_MULTITHREAD_UNSAFE_STRING_BUFFER
                    lock (q)
#endif
                    {
                        try
                        {
                            var count = q.Count;
                            if (count > 0)
                            {
                                var r = q[count - 1];
                                q.RemoveAt(count - 1);
                                buffer = r;
                                capacity = size;
                                return;
                            }
                        }
                        finally
                        {
                        }
                    }
                }

                buffer = new string('\0', size);
                capacity = size;
            }

            public void Return(string buffer, int capacity)
            {
                if (buffer == null || capacity == 0)
                    return;

                var index = GetQueueIndex(capacity);
                if (index != -1)
                {
                    var q = _buckets[index];

#if ENABLE_MULTITHREAD_UNSAFE_STRING_BUFFER
                    lock (q)
#endif
                    {
                        try
                        {
                            if (q.Count > _maxBuffersPerBucket)
                            {
                                return;
                            }

                            q.Add(buffer);
                        }
                        finally
                        {
                        }
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static int CalculateSize(int size)
            {
                size--;
                size |= size >> 1;
                size |= size >> 2;
                size |= size >> 4;
                size |= size >> 8;
                size |= size >> 16;
                size += 1;

                if (size < 8)
                {
                    size = 8;
                }

                return size;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static int GetQueueIndex(int size)
            {
                switch (size)
                {
                    case 8: return 0;
                    case 16: return 1;
                    case 32: return 2;
                    case 64: return 3;
                    case 128: return 4;
                    case 256: return 5;
                    case 512: return 6;
                    case 1024: return 7;
                    case 2048: return 8;
                    case 4096: return 9;
                    case 8192: return 10;
                    case 16384: return 11;
                    case 32768: return 12;
                    case 65536: return 13;
                    case 131072: return 14;
                    case 262144: return 15; // max array length
                    default:
                        return -1;
                }
            }
        }
    }
}