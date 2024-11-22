Imports DevExpress.XtraReports.UI

Namespace FontDemoReport

    Partial Class DemoReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FontDemoReport.DemoReport))
            Dim xrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label5, Me.label3})
            Me.Detail.HeightF = 35.41667F
            Me.Detail.Name = "Detail"
            ' 
            ' label5
            ' 
            Me.label5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(513.5417F, 0F)
            Me.label5.Multiline = True
            Me.label5.Name = "label5"
            Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label5.SizeF = New System.Drawing.SizeF(126.4582F, 23F)
            Me.label5.Text = "label5"
            ' 
            ' label3
            ' 
            Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.label3.Font = New DevExpress.Drawing.DXFont("Roboto", 9.75F)
            Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.label3.Multiline = True
            Me.label3.Name = "label3"
            Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label3.SizeF = New System.Drawing.SizeF(362.5F, 27.08333F)
            Me.label3.StylePriority.UseFont = False
            Me.label3.Text = "label3"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label4, Me.pictureBox1, Me.label2, Me.label1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
            ' 
            ' label4
            ' 
            Me.label4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.label4.Font = New DevExpress.Drawing.DXFont("Roboto", 10F)
            Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 39.58333F)
            Me.label4.Multiline = True
            Me.label4.Name = "label4"
            Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label4.SizeF = New System.Drawing.SizeF(362.5F, 60.41668F)
            Me.label4.StylePriority.UseFont = False
            Me.label4.Text = "label4"
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(401.0417F, 0F)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.SizeF = New System.Drawing.SizeF(100F, 100F)
            Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' label2
            ' 
            Me.label2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([UnitPrice])")})
            Me.label2.Font = New DevExpress.Drawing.DXFont("Nerko One", 14F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(513.5417F, 0F)
            Me.label2.Multiline = True
            Me.label2.Name = "label2"
            Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label2.SizeF = New System.Drawing.SizeF(126.4583F, 23F)
            Me.label2.StylePriority.UseFont = False
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.label2.Summary = xrSummary1
            Me.label2.Text = "label2"
            ' 
            ' label1
            ' 
            Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.label1.Font = New DevExpress.Drawing.DXFont("Ga Maamli", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(1.041667F, 0F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(371.4583F, 28.125F)
            Me.label1.StylePriority.UseFont = False
            Me.label1.Text = "label1"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""283"" />"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "QuantityPerUnit"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "UnitPrice"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitsInStock"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsOnOrder"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "ReorderLevel"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Discontinued"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "EAN13"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "CategoryName"
            table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""183"" />"
            table2.Name = "Categories"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "Description"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Picture"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Icon17"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "Icon25"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "CategoryID"
            columnExpression16.Table = table1
            column16.Expression = columnExpression16
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.Columns.Add(column13)
            selectQuery1.Columns.Add(column14)
            selectQuery1.Columns.Add(column15)
            selectQuery1.Columns.Add(column16)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' DemoReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.GroupHeader1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.Version = "24.2"
            xrWatermark1.Id = "Watermark1"
            Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {xrWatermark1})
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private label5 As DevExpress.XtraReports.UI.XRLabel

        Private label3 As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private label4 As DevExpress.XtraReports.UI.XRLabel

        Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

        Private label2 As DevExpress.XtraReports.UI.XRLabel

        Private label1 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
