namespace BridgeDesignPattern.ReportFormats
{
    internal class MobileReport : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Mobile Report Created.");
        }
    }
}
