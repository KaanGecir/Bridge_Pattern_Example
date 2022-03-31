using BridgeDesignPattern.ReportFormats;

namespace BridgeDesignPattern.Reports
{
    internal class SalesReport : Report
    {
        public SalesReport(IReportFormat ReportFormat) 
            : base(ReportFormat)
        {
        }

        public override void Display()
        {
            Console.WriteLine("This is a Sales Report.");
            base.Display();
        }
    }
}
