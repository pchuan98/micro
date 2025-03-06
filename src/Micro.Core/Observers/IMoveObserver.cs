using Micro.Core.Constants;

namespace Micro.Core.Observers;

/// <summary>
/// 定义移动观察者接口，用于控制和观察对象的移动行为。
/// </summary>
public interface IMoveObserver
{
    /// <summary>
    /// 执行相对位移。可以移动一个或多个轴上的位置
    /// </summary>
    /// <param name="x">X轴上的相对位移量，默认为null</param>
    /// <param name="y">Y轴上的相对位移量，默认为null</param>
    /// <param name="z">Z轴上的相对位移量，默认为null</param>
    /// <returns>是否成功执行移动</returns>
    bool RelativeMove(double? x = null, double? y = null, double? z = null);

    /// <summary>
    /// 移动到绝对唯一位置。可以设置一个或多个轴的绝对位置
    /// </summary>
    /// <param name="x">X轴上的绝对位置，默认为null</param>
    /// <param name="y">Y轴上的绝对位置，默认为null</param>
    /// <param name="z">Z轴上的绝对位置，默认为null</param>
    /// <returns>是否成功执行移动</returns>
    bool AbsoluteMove(double? x = null, double? y = null, double? z = null);

    /// <summary>
    /// 以像素为单位进行移动(基于当前位置)
    /// </summary>
    /// <param name="direction">移动的方向</param>
    /// <param name="pixel">移动的像素数</param>
    /// <returns>是否成功执行移动</returns>
    bool PixelMove(Direction direction, int pixel);

    /// <summary>
    /// 基于画幅或视图框进行移动
    /// </summary>
    /// <param name="direction">移动的方向</param>
    /// <param name="scale">移动的缩放比例
    /// 当方向是上和下的时候，scale=1 等价于移动一个画面高度的像素距离
    /// 同理，左右的时候表示移动基于当前位置一个宽度像素的位移
    /// </param>
    /// <returns>是否成功执行移动</returns>
    bool FrameMove(Direction direction, double scale);

    /// <summary>
    /// 停止当前的移动行为
    /// </summary>
    /// <returns>是否成功停止移动</returns>
    bool Stop();
}