using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using FontDemoReport;

namespace LoadMissingFonts {
    public partial class Form1 : Form {
        public Form1() {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            using (var report = new DemoReport()) {
                DXFontRepository.QueryNotFoundFont += Report_QueryNotFoundFont;
                using (var tool = new ReportPrintTool(report)) {
                    tool.ShowRibbonPreviewDialog();
                }
            }
            Close();
        }

        private static void Report_QueryNotFoundFont(object sender, NotFoundFontEventArgs e) {
            var service = new FontCollectorService();
            var fontData = service.ProcessFont(e.RequestedFont).Result;
            e.FontFileData = fontData;
        }

      
    }
}
