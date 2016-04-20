namespace UMeng.Touch.Analytics
{
    public enum ReportPolicy : uint
    {
        Realtime = 0,
        Batch = 1,
        SendInterval = 6,
        Senddaily = 4,
        Sendwifionly = 5,
        SendOnExit = 7
    }
}
