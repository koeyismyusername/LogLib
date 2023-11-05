namespace LogLib
{
    public enum LogLevel
    {
        NONE,
        DEBUG,
        INFO,
        WARN,
        ERROR
    }

    public static class LogLevelExtensions
    {
        public static LogColor GetColor(this LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.DEBUG: return LogColor.GRAY;
                case LogLevel.WARN: return LogColor.ORANGE;
                case LogLevel.ERROR: return LogColor.RED;
                case LogLevel.INFO:
                case LogLevel.NONE:
                default: return LogColor.BLACK;
            }
        }
    }
}
