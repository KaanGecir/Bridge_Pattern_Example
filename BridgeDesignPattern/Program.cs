using BridgeDesignPattern.ReportFormats;
using BridgeDesignPattern.Reports;

Report report = new SalesReport(new DesktopReport());

report.Display();