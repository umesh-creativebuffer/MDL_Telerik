Partial Class MDL_Report

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDL_Report))
        Dim TypeReportSource1 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim TypeReportSource2 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim TypeReportSource3 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim TypeReportSource4 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim TypeReportSource5 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim TypeReportSource6 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.PictureBox2 = New Telerik.Reporting.PictureBox()
        Me.PictureBox3 = New Telerik.Reporting.PictureBox()
        Me.SubReport2 = New Telerik.Reporting.SubReport()
        Me.SubReport3 = New Telerik.Reporting.SubReport()
        Me.SubReport4 = New Telerik.Reporting.SubReport()
        Me.SubReport5 = New Telerik.Reporting.SubReport()
        Me.SubReport6 = New Telerik.Reporting.SubReport()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.JsonDataSource1 = New Telerik.Reporting.JsonDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(27.0R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.SubReport1, Me.Panel1, Me.SubReport2, Me.SubReport3, Me.SubReport4, Me.SubReport5, Me.SubReport6})
        Me.detail.Name = "detail"
        Me.detail.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        Me.detail.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        Me.detail.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        Me.detail.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(22.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.53R), Telerik.Reporting.Drawing.Unit.Cm(1.25R))
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox1.Value = resources.GetString("TextBox1.Value")
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.35R)
        Me.PageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9})
        Me.PageFooterSection1.Name = "PageFooterSection1"
        Me.PageFooterSection1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        Me.PageFooterSection1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        Me.PageFooterSection1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.75R)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(20.5R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.53R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Value = resources.GetString("TextBox2.Value")
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.SubReport1.Name = "SubReport1"
        TypeReportSource1.TypeName = "MDL_Telerik.MDL_Report_PatientDetails, MDL_Telerik, Version=1.0.0.0, Culture=neut" &
    "ral, PublicKeyToken=null"
        Me.SubReport1.ReportSource = TypeReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(2.25R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5R), Telerik.Reporting.Drawing.Unit.Cm(0.3R))
        Me.HtmlTextBox1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.HtmlTextBox1.Style.Font.Name = "Open Sans SemiBold"
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.HtmlTextBox1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.HtmlTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.HtmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.HtmlTextBox1.Value = "<a href=""http://www.mdlab.com/""><span style=""font-size: 8pt; font-family: open sa" &
    "ns semibold"">www.mdlab.com</span></a>"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox2, Me.HtmlTextBox1, Me.PictureBox3})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PictureBox2.MimeType = ""
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        Me.PictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox2.Value = resources.GetString("PictureBox2.Value")
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.125R))
        Me.PictureBox3.MimeType = ""
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.25R), Telerik.Reporting.Drawing.Unit.Cm(2.25R))
        Me.PictureBox3.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox3.Value = CType(resources.GetObject("PictureBox3.Value"), Object)
        '
        'SubReport2
        '
        Me.SubReport2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(5.25R))
        Me.SubReport2.Name = "SubReport2"
        TypeReportSource2.TypeName = "MDL_Telerik.MDL_Report_ClientDetails, MDL_Telerik, Version=1.0.0.0, Culture=neutr" &
    "al, PublicKeyToken=null"
        Me.SubReport2.ReportSource = TypeReportSource2
        Me.SubReport2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        '
        'SubReport3
        '
        Me.SubReport3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(3.25R))
        Me.SubReport3.Name = "SubReport3"
        TypeReportSource3.TypeName = "MDL_Telerik.MDL_Report_Specimen, MDL_Telerik, Version=1.0.0.0, Culture=neutral, P" &
    "ublicKeyToken=null"
        Me.SubReport3.ReportSource = TypeReportSource3
        Me.SubReport3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        '
        'SubReport4
        '
        Me.SubReport4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.25R), Telerik.Reporting.Drawing.Unit.Cm(8.45R))
        Me.SubReport4.Name = "SubReport4"
        TypeReportSource4.TypeName = "MDL_Telerik.MDI_Report_AbnormalResults, MDL_Telerik, Version=1.0.0.0, Culture=neu" &
    "tral, PublicKeyToken=null"
        Me.SubReport4.ReportSource = TypeReportSource4
        Me.SubReport4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        '
        'SubReport5
        '
        Me.SubReport5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.25R), Telerik.Reporting.Drawing.Unit.Cm(10.75R))
        Me.SubReport5.Name = "SubReport5"
        TypeReportSource5.TypeName = "MDL_Telerik.MDL_Report_Bacterial, MDL_Telerik, Version=1.0.0.0, Culture=neutral, " &
    "PublicKeyToken=null"
        Me.SubReport5.ReportSource = TypeReportSource5
        Me.SubReport5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        '
        'SubReport6
        '
        Me.SubReport6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.25R), Telerik.Reporting.Drawing.Unit.Cm(14.0R))
        Me.SubReport6.Name = "SubReport6"
        TypeReportSource6.TypeName = "MDL_Telerik.MDL_Report_Pathogens, MDL_Telerik, Version=1.0.0.0, Culture=neutral, " &
    "PublicKeyToken=null"
        Me.SubReport6.ReportSource = TypeReportSource6
        Me.SubReport6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.75R), Telerik.Reporting.Drawing.Unit.Cm(5.5R))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.5R), Telerik.Reporting.Drawing.Unit.Cm(1.7R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = resources.GetString("PictureBox1.Value")
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.95R), Telerik.Reporting.Drawing.Unit.Cm(0.9R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.68R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox3.Style.Color = System.Drawing.Color.White
        Me.TextBox3.Style.Font.Name = "Open Sans"
        Me.TextBox3.Value = "= PageNumber"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.25R), Telerik.Reporting.Drawing.Unit.Cm(0.9R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.55R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Value = "= PageCount"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.65R), Telerik.Reporting.Drawing.Unit.Cm(0.9R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.55R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox5.Style.Font.Name = "Open Sans"
        Me.TextBox5.Value = "of"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.35R), Telerik.Reporting.Drawing.Unit.Cm(0.9R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.05R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox6.Style.Font.Name = "Open Sans"
        Me.TextBox6.Value = "Page"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.65R), Telerik.Reporting.Drawing.Unit.Cm(0.3R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.65R), Telerik.Reporting.Drawing.Unit.Cm(0.4R))
        Me.TextBox7.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Open Sans"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Format(""{0:MM/dd/yyyy}"",Now())" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.25R), Telerik.Reporting.Drawing.Unit.Cm(0.3R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15R), Telerik.Reporting.Drawing.Unit.Cm(0.4R))
        Me.TextBox8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Open Sans"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= Fields.GUID_MDLNumber"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.95R), Telerik.Reporting.Drawing.Unit.Cm(0.232R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.25R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
        Me.TextBox9.Style.Color = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TextBox9.Style.Font.Name = "Open Sans"
        Me.TextBox9.Value = "MDL#:"
        '
        'JsonDataSource1
        '
        Me.JsonDataSource1.DataSelector = "$.PCI"
        Me.JsonDataSource1.Name = "JsonDataSource1"
        Me.JsonDataSource1.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'MDL_Report
        '
        Me.DataSource = Me.JsonDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.PageFooterSection1})
        Me.Name = "MDL_Report"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0R)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(22.15R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents PictureBox2 As Telerik.Reporting.PictureBox
    Friend WithEvents PictureBox3 As Telerik.Reporting.PictureBox
    Friend WithEvents SubReport2 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport3 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport4 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport5 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport6 As Telerik.Reporting.SubReport
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents JsonDataSource1 As Telerik.Reporting.JsonDataSource
End Class