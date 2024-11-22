Namespace LoadMissingFonts

    Partial Class Form1

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            SuspendLayout()
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(800, 450)
            Name = "Form1"
            Text = "Form1"
            Load += AddressOf Form1_Load
            ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace
