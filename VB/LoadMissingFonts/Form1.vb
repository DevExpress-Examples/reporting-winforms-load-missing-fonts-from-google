Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI
Imports FontDemoReport

Namespace LoadMissingFonts

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Using report = New DemoReport()
                DevExpress.Drawing.DXFontRepository.QueryNotFoundFont += AddressOf Report_QueryNotFoundFont
                Using tool = New ReportPrintTool(report)
                    tool.ShowRibbonPreviewDialog()
                End Using
            End Using

            Close()
        End Sub

        Private Shared Sub Report_QueryNotFoundFont(ByVal sender As Object, ByVal e As NotFoundFontEventArgs)
            Dim service = New FontCollectorService()
            Dim fontData = service.ProcessFont(e.RequestedFont).Result
            e.FontFileData = fontData
        End Sub
    End Class
End Namespace
