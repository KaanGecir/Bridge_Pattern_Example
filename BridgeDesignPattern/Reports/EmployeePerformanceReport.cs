using BridgeDesignPattern.ReportFormats;

namespace BridgeDesignPattern.Reports
{
    internal class EmployeePerformanceReport : Report
    {
        public EmployeePerformanceReport(IReportFormat ReportFormat) 
            : base(ReportFormat)
        {
        }

        public override void Display()
        {
            Console.WriteLine("This is a EmployeePerformance Report.");
            base.Display();   
        }
    }
}
