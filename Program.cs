using System.Diagnostics;

namespace Localization.Converter
{
    internal class Program
    {
        private static void Main()
        {
            Debug.Assert(ZhConverter.Convert("有背光的机械式键盘", ZhConverter.To.Traditional) == "有背光的機械式鍵盤");
            Debug.Assert(ZhConverter.Convert("有背光的機械式鍵盤", ZhConverter.To.Simplified) == "有背光的机械式键盘");
        }
    }
}