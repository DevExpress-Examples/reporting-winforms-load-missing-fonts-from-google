Imports DevExpress.Drawing

Namespace LoadMissingFonts

    Friend Module Program

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            ApplicationConfiguration.Initialize()
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace
