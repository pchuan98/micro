namespace Micro.Hal.Exceptions;

/// <summary>
/// 表示当尝试移动时，电机正忙于执行其他操作的异常。
/// </summary>
public class MotorBusyException : Exception
{
    /// <summary>
    /// 使用默认的错误信息初始化 MotorBusyException 的新实例。
    /// </summary>
    public MotorBusyException() : base("The motor is currently busy with another operation.") { }

    /// <summary>
    /// 使用指定的错误信息初始化 MotorBusyException 的新实例。
    /// </summary>
    /// <param name="message">描述错误的消息</param>
    public MotorBusyException(string message) : base(message) { }

    /// <summary>
    /// 使用指定的错误信息和对作为此异常原因的内部异常的引用来初始化 MotorBusyException 的新实例。
    /// </summary>
    /// <param name="message">描述错误的消息</param>
    /// <param name="inner">导致当前异常的异常</param>
    public MotorBusyException(string message, Exception inner) : base(message, inner) { }
}
