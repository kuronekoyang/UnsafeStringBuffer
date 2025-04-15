# UnsafeStringBuffer
High performance zero allocation string builder (but unsafe)

你可能用过很多种StringBuilder，不管是C#原生的StringBuilder，还是Cysharp的ZString，亦或是其他的。
  
但无论哪一种，即便是号称"Zero Allocation"，在最后ToString也会new一个新的string。


这在某些需要临时使用StringBuilder，但接收端只提供了string作为参数的api的情况下，还是会分配内存。

这时就可以使用UnsafeStringBuffer。

# 实现原理

UnsafeStringBuffer内部使用字符串池，可以高效利用内存。

再通过Unsafe.As，修改string的private length字段，让string真正成为了变长字符串

# 使用方法

```csharp
var buffer = new kuro.UnsafeStringBuffer();
buffer.Append(1);
buffer.Append(' ', 10);
buffer.Append("hello world");
UnityEngine.Debug.Log(buffer.InternalBuffer);
```

# 注意事项

InternalBuffer只能使用在临时场景。
