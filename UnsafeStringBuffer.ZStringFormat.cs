using System;
using System.Runtime.CompilerServices;
using Cysharp.Text;

namespace kuro
{
    public partial struct UnsafeStringBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Append<T>(T value)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.Append(value);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert<T>(int index, T value)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.Append(value);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1>(string format, T1 arg1)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1>(ReadOnlySpan<char> format, T1 arg1)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2>(ReadOnlySpan<char> format, T1 arg1, T2 arg2)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ReadOnlySpan<char> format,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            Append(sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            Append(sb.AsSpan());
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1>(int index, string format, T1 arg1)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2>(int index, string format, T1 arg1, T2 arg2)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3>(int index, string format, T1 arg1, T2 arg2, T3 arg3)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, string format,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            int index, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1>(int index, ReadOnlySpan<char> format, T1 arg1)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            T7 arg7)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, ReadOnlySpan<char> format,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            Insert(index, sb.AsSpan());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            int index, ReadOnlySpan<char> format, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            using var sb = new Utf16ValueStringBuilder(true);
            sb.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            Insert(index, sb.AsSpan());
        }
    }
}