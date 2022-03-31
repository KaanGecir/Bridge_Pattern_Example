using BridgeDesignPattern.ReportFormats;

namespace BridgeDesignPattern.Reports
{
    public abstract class Report
    {
        private readonly IReportFormat reportFormat;

        protected Report(IReportFormat ReportFormat)
        {
            reportFormat = ReportFormat;
        }
        
        public virtual void Display()
        {
            reportFormat.Generate();
        }
    }
}
