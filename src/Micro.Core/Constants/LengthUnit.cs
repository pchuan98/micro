namespace Micro.Core.Constants;

/// <summary>
/// 定义长度的国际单位。
/// </summary>
public enum LengthUnit
{
    /// <summary>
    /// 米，国际单位制（SI）中的基本长度单位。
    /// </summary>
    Meter = 0,

    /// <summary>
    /// 厘米，等于1米的百分之一。
    /// 1m = 100cm
    /// </summary>
    Centimeter = 1,

    /// <summary>
    /// 毫米，等于1厘米的十分之一。
    /// 1cm = 10mm
    /// </summary>
    Millimeter = 2,

    /// <summary>
    /// 微米，1毫米的千分之一。
    /// 1mm = 1000μm
    /// </summary>
    Micrometer = 3,

    /// <summary>
    /// 纳米，1微米的千分之一。
    /// 1μm = 1000nm
    /// </summary>
    Nanometer = 4,

    /// <summary>
    /// 皮米，1纳米的千分之一。
    /// 1nm = 1000pm
    /// </summary>
    Picometer = 5
}
