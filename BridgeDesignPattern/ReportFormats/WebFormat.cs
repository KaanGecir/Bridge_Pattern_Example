namespace BridgeDesignPattern.ReportFormats
{
    internal class WebFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Web Report created.");
        }
    }
}
