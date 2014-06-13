## What is this?

Based on the character map found in java-zhconverter to convert c# string between traditional and simplified Chinese characters.

* [java-zhconverter](https://code.google.com/p/java-zhconverter/)

## example

Convert c# string between traditional and simplified using `ZhConverter.Convert` and `ZhConverter.To.Traditional` / `ZhConverter.To.Simplified`.

```csharp
Debug.Assert(ZhConverter.Convert("有背光的机械式键盘", ZhConverter.To.Traditional) == "有背光的機械式鍵盤");
Debug.Assert(ZhConverter.Convert("有背光的機械式鍵盤", ZhConverter.To.Simplified) == "有背光的机械式键盘");
```