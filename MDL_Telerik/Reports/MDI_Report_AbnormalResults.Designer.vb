Partial Class MDI_Report_AbnormalResults

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_Report_AbnormalResults))
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.HtmlTextBox()
        Me.AbnormalResultsDetails_0 = New Telerik.Reporting.JsonDataSource()
        Me.AbnormalResultsDetails_1 = New Telerik.Reporting.JsonDataSource()
        Me.TextBox8 = New Telerik.Reporting.PictureBox()
        Me.Table2 = New Telerik.Reporting.Table()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.PictureBox2 = New Telerik.Reporting.PictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox2, Me.TextBox1, Me.Table1, Me.Table2})
        Me.detail.Name = "detail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = resources.GetString("PictureBox1.Value")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Pathogens"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "Detected"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.5R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.0R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox4)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox6)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox8)
        TableGroup1.Name = "tableGroup"
        TableGroup2.Name = "tableGroup1"
        TableGroup3.Name = "tableGroup2"
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.DataSource = Me.AbnormalResultsDetails_0
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox6, Me.TextBox8})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.75R), Telerik.Reporting.Drawing.Unit.Cm(1.25R))
        Me.Table1.Name = "Table1"
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup4.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup4)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.5R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "= Fields.GUID_TestCode"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox6.Style.Font.Name = "Open Sans"
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "{Fields.ShortTestName}"
        '
        'AbnormalResultsDetails_0
        '
        Me.AbnormalResultsDetails_0.DataSelector = "$.AbnormalResults[0]"
        Me.AbnormalResultsDetails_0.Name = "AbnormalResultsDetails_0"
        Me.AbnormalResultsDetails_0.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'AbnormalResultsDetails_1
        '
        Me.AbnormalResultsDetails_1.DataSelector = "$.AbnormalResults[1]"
        Me.AbnormalResultsDetails_1.Name = "AbnormalResultsDetails_1"
        Me.AbnormalResultsDetails_1.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'TextBox8
        '
        Me.TextBox8.ImageAlignment = Telerik.Reporting.Drawing.ImageAlignment.BottomRight
        Me.TextBox8.MimeType = ""
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox8.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = resources.GetString("TextBox8.Value")
        '
        'Table2
        '
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.5R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.0R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.0R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609R)))
        Me.Table2.Body.SetCellContent(0, 0, Me.TextBox3)
        Me.Table2.Body.SetCellContent(0, 1, Me.HtmlTextBox1)
        Me.Table2.Body.SetCellContent(0, 2, Me.PictureBox2)
        TableGroup5.Name = "tableGroup"
        TableGroup6.Name = "tableGroup1"
        TableGroup7.Name = "tableGroup2"
        Me.Table2.ColumnGroups.Add(TableGroup5)
        Me.Table2.ColumnGroups.Add(TableGroup6)
        Me.Table2.ColumnGroups.Add(TableGroup7)
        Me.Table2.DataSource = Me.AbnormalResultsDetails_1
        Me.Table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.HtmlTextBox1, Me.PictureBox2})
        Me.Table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(1.25R))
        Me.Table2.Name = "Table2"
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup8.Name = "detailTableGroup"
        Me.Table2.RowGroups.Add(TableGroup8)
        Me.Table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.5R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Fields.GUID_TestCode"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox1.Value = "{Fields.ShortTestName}"
        '
        'PictureBox2
        '
        Me.PictureBox2.ImageAlignment = Telerik.Reporting.Drawing.ImageAlignment.BottomRight
        Me.PictureBox2.MimeType = ""
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.PictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.PictureBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.PictureBox2.Value = resources.GetString("PictureBox2.Value")
        '
        'MDI_Report_AbnormalResults
        '
        Me.DataSource = Nothing
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "MDI_Report_AbnormalResults"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.75R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents AbnormalResultsDetails_0 As Telerik.Reporting.JsonDataSource
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents AbnormalResultsDetails_1 As Telerik.Reporting.JsonDataSource
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.PictureBox
    Friend WithEvents Table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents PictureBox2 As Telerik.Reporting.PictureBox
End Class