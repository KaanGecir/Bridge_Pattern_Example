namespace BridgeDesignPattern.ReportFormats
{
    internal class DesktopReport : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Desktop Report Created.");
        }
    }
}
