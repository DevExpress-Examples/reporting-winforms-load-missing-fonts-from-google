using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using System;

namespace FontDemoReport {
    internal class Program {
        [STAThread]
        static void Main(string[] args) {
            using(var report = new DemoReport()) {
                DXFontRepository.QueryNotFoundFont += Report_QueryNotFoundFont;
                report.ShowPreviewDialog();
            }
        }

        private static void Report_QueryNotFoundFont(object sender, NotFoundFontEventArgs e) {
            var service = new FontCollectorService();
            var fontData = service.ProcessFont(e.RequestedFont).Result;
            e.FontFileData = fontData;            
        }
    }
}
