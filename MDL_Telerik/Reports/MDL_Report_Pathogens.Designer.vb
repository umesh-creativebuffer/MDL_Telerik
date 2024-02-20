Partial Class MDL_Report_Pathogens

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDL_Report_Pathogens))
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.Table9 = New Telerik.Reporting.Table()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.HtmlTextBox()
        Me.NormalResults_1 = New Telerik.Reporting.JsonDataSource()
        Me.NormalResults_2 = New Telerik.Reporting.JsonDataSource()
        Me.NormalResults_3 = New Telerik.Reporting.JsonDataSource()
        Me.Table5 = New Telerik.Reporting.Table()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(5.0R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox2, Me.TextBox1, Me.TextBox29, Me.Table9, Me.Table5, Me.Table1})
        Me.detail.Name = "detail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = resources.GetString("PictureBox1.Value")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.1R), Telerik.Reporting.Drawing.Unit.Cm(0.1R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Pathogens"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3R), Telerik.Reporting.Drawing.Unit.Cm(0.1R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "Not Detected"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.3R), Telerik.Reporting.Drawing.Unit.Cm(1.6R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Name = "Open Sans"
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "Swab"
        '
        'Table9
        '
        Me.Table9.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6R)))
        Me.Table9.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4R)))
        Me.Table9.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609R)))
        Me.Table9.Body.SetCellContent(0, 0, Me.TextBox20)
        Me.Table9.Body.SetCellContent(0, 1, Me.TextBox22)
        TableGroup1.Name = "tableGroup2"
        TableGroup2.Name = "tableGroup3"
        Me.Table9.ColumnGroups.Add(TableGroup1)
        Me.Table9.ColumnGroups.Add(TableGroup2)
        Me.Table9.DataSource = Me.NormalResults_1
        Me.Table9.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox20, Me.TextBox22})
        Me.Table9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.25R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table9.Name = "Table9"
        TableGroup3.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup3.Name = "detailTableGroup1"
        Me.Table9.RowGroups.Add(TableGroup3)
        Me.Table9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.Table9.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Sortorder", Telerik.Reporting.SortDirection.Asc))
        '
        'TextBox20
        '
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox20.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "= Fields.GUID_TestCode"
        '
        'TextBox22
        '
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox22.Style.Font.Name = "Open Sans"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "{Fields.ShortTestName}"
        '
        'NormalResults_1
        '
        Me.NormalResults_1.DataSelector = "$.NormalResults[?(@.Column == 1)]"
        Me.NormalResults_1.Name = "NormalResults_1"
        Me.NormalResults_1.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'NormalResults_2
        '
        Me.NormalResults_2.DataSelector = "$.NormalResults[?(@.Column == 2)]"
        Me.NormalResults_2.Name = "NormalResults_2"
        Me.NormalResults_2.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'NormalResults_3
        '
        Me.NormalResults_3.DataSelector = "$.NormalResults[?(@.Column == 3)]"
        Me.NormalResults_3.Name = "NormalResults_3"
        Me.NormalResults_3.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'Table5
        '
        Me.Table5.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6R)))
        Me.Table5.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4R)))
        Me.Table5.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609R)))
        Me.Table5.Body.SetCellContent(0, 0, Me.TextBox11)
        Me.Table5.Body.SetCellContent(0, 1, Me.HtmlTextBox1)
        TableGroup4.Name = "tableGroup2"
        TableGroup5.Name = "tableGroup3"
        Me.Table5.ColumnGroups.Add(TableGroup4)
        Me.Table5.ColumnGroups.Add(TableGroup5)
        Me.Table5.DataSource = Me.NormalResults_2
        Me.Table5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.HtmlTextBox1})
        Me.Table5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.75R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table5.Name = "Table5"
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup6.Name = "detailTableGroup1"
        Me.Table5.RowGroups.Add(TableGroup6)
        Me.Table5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.Table5.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Sortorder", Telerik.Reporting.SortDirection.Asc))
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox11.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "= Fields.GUID_TestCode"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.HtmlTextBox1.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox1.Value = "{Fields.ShortTestName}"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox3)
        Me.Table1.Body.SetCellContent(0, 1, Me.HtmlTextBox2)
        TableGroup7.Name = "tableGroup2"
        TableGroup8.Name = "tableGroup3"
        Me.Table1.ColumnGroups.Add(TableGroup7)
        Me.Table1.ColumnGroups.Add(TableGroup8)
        Me.Table1.DataSource = Me.NormalResults_3
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.HtmlTextBox2})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.25R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table1.Name = "Table1"
        TableGroup9.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup9.Name = "detailTableGroup1"
        Me.Table1.RowGroups.Add(TableGroup9)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.Table1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Sortorder", Telerik.Reporting.SortDirection.Asc))
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.TextBox3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Fields.GUID_TestCode"
        '
        'HtmlTextBox2
        '
        Me.HtmlTextBox2.Name = "HtmlTextBox2"
        Me.HtmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4R), Telerik.Reporting.Drawing.Unit.Cm(0.609R))
        Me.HtmlTextBox2.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.HtmlTextBox2.Value = "{Fields.ShortTestName}"
        '
        'MDL_Report_Pathogens
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "MDL_Report_Pathogens"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.75R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents NormalResults_1 As Telerik.Reporting.JsonDataSource
    Friend WithEvents NormalResults_2 As Telerik.Reporting.JsonDataSource
    Friend WithEvents NormalResults_3 As Telerik.Reporting.JsonDataSource
    Friend WithEvents Table9 As Telerik.Reporting.Table
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Table5 As Telerik.Reporting.Table
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox2 As Telerik.Reporting.HtmlTextBox
End Class