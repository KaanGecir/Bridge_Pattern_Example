using BridgeDesignPattern.ReportFormats;

namespace BridgeDesignPattern.Reports
{
    internal class VisitReport : Report
    {
        public VisitReport(IReportFormat ReportFormat) 
            : base(ReportFormat)
        {
        }

        public override void Display()
        {
            Console.WriteLine("This is a Visit Report.");
            base.Display();
        }
    }
}
