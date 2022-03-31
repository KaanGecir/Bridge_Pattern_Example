using BridgeDesignPattern.ReportFormats;
using BridgeDesignPattern.Reports;

Report report = new VisitReport(new MobileReport());

report.Display();