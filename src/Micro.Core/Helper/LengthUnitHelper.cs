using Micro.Core.Constants;

namespace Micro.Core.Helper;

public static class LengthUnitHelper
{
    /// <summary>
    /// 长度单位的转换
    /// </summary>
    /// <param name="length">要转换的长度值</param>
    /// <param name="src">源单位</param>
    /// <param name="target">目标单位</param>
    /// <returns>转换后的长度值</returns>
    public static double Converter(double length, LengthUnit src, LengthUnit target)
    {
        // 定义基本单位为米的转换因子
        var factors = new Dictionary<LengthUnit, double>
        {
            {LengthUnit.Meter, 1},
            {LengthUnit.Centimeter, 0.01},
            {LengthUnit.Millimeter, 0.001},
            {LengthUnit.Micrometer, 1E-6},
            {LengthUnit.Nanometer, 1E-9},
            {LengthUnit.Picometer, 1E-12}
        };

        var meterLength = length * factors[src];
        return meterLength / factors[target];
    }

    /// <summary>
    /// 截断长度到指定的精度
    /// </summary>
    /// <param name="length">要截断的长度值</param>
    /// <param name="precision">精度，即保留的小数位数</param>
    /// <returns>截断后的长度值</returns>
    public static double TruncateLength(double length, int precision)
    {
        var factor = Math.Pow(10, precision);
        var truncated = (long)(length * factor);
        return truncated / factor;
    }
}