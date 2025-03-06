namespace Micro.Hal.Camera;

/// <summary>
/// 相机统一参数接口
/// </summary>
public interface ICameraHal
{
    public Span<byte> Grab();
}