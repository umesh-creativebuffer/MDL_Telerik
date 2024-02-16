Partial Class MDL_Report_PatientDetails

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDL_Report_PatientDetails))
        Dim QrCodeEncoder1 As Telerik.Reporting.Barcodes.QRCodeEncoder = New Telerik.Reporting.Barcodes.QRCodeEncoder()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.PatientDetails = New Telerik.Reporting.JsonDataSource()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox5 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox3 = New Telerik.Reporting.HtmlTextBox()
        Me.HtmlTextBox4 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox6 = New Telerik.Reporting.HtmlTextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.HtmlTextBox7 = New Telerik.Reporting.HtmlTextBox()
        Me.Barcode1 = New Telerik.Reporting.Barcode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(5.018R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.HtmlTextBox1, Me.HtmlTextBox5, Me.HtmlTextBox2, Me.HtmlTextBox3, Me.HtmlTextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.HtmlTextBox6, Me.TextBox9, Me.HtmlTextBox7, Me.Barcode1})
        Me.detail.Name = "detail"
        '
        'PatientDetails
        '
        Me.PatientDetails.DataSelector = "$.PCI"
        Me.PatientDetails.Name = "PatientDetails"
        Me.PatientDetails.Source = New System.Uri("JsonFiles\10094547.json", System.UriKind.Relative)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.018R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.PictureBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.PictureBox1.Value = resources.GetString("PictureBox1.Value")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.75R), Telerik.Reporting.Drawing.Unit.Cm(0.1R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.Style.Color = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Open Sans"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.TextBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.TextBox1.Value = "= Fields.GUID_MDLNumber"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.375R), Telerik.Reporting.Drawing.Unit.Cm(0.15R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.TextBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Open Sans"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Value = "MDL #"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.TextBox3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Open Sans"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Value = "PRELIMINARY"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(1.1R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.TextBox4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Open Sans"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Value = "= Fields.Patient_Name"
        '
        'HtmlTextBox1
        '
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(1.5R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.HtmlTextBox1.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox1.Value = "{Fields.Patient_Address}"
        '
        'HtmlTextBox5
        '
        Me.HtmlTextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.HtmlTextBox5.Name = "HtmlTextBox5"
        Me.HtmlTextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox5.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox5.Value = "DOB:"
        '
        'HtmlTextBox2
        '
        Me.HtmlTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(2.9R))
        Me.HtmlTextBox2.Name = "HtmlTextBox2"
        Me.HtmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.25R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox2.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox2.Value = "Gender:"
        '
        'HtmlTextBox3
        '
        Me.HtmlTextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(3.3R))
        Me.HtmlTextBox3.Name = "HtmlTextBox3"
        Me.HtmlTextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox3.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox3.Value = "Ethnicity:"
        '
        'HtmlTextBox4
        '
        Me.HtmlTextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.625R), Telerik.Reporting.Drawing.Unit.Cm(3.75R))
        Me.HtmlTextBox4.Name = "HtmlTextBox4"
        Me.HtmlTextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.75R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox4.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox4.Value = "Patient ID:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.TextBox5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox5.Style.Font.Bold = False
        Me.TextBox5.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox5.Value = "= Fields.Date_Of_Birth"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.75R), Telerik.Reporting.Drawing.Unit.Cm(2.9R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.725R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.TextBox6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox6.Style.Font.Bold = False
        Me.TextBox6.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Value = "= Fields.PT_Gender"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(3.3R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.TextBox7.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox7.Style.Font.Bold = False
        Me.TextBox7.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Value = "= Fields.Patient_Ethnicity"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.125R), Telerik.Reporting.Drawing.Unit.Cm(3.75R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.125R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.TextBox8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox8.Style.Font.Bold = False
        Me.TextBox8.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Value = "= Fields.PatientID"
        '
        'HtmlTextBox6
        '
        Me.HtmlTextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.HtmlTextBox6.Name = "HtmlTextBox6"
        Me.HtmlTextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.75R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox6.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox6.Value = "(Age "
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.575R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.TextBox9.Style.Color = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.TextBox9.Style.Font.Bold = False
        Me.TextBox9.Style.Font.Name = "Open Sans SemiBold"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Value = "= Fields.Age"
        '
        'HtmlTextBox7
        '
        Me.HtmlTextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.95R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.HtmlTextBox7.Name = "HtmlTextBox7"
        Me.HtmlTextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.75R), Telerik.Reporting.Drawing.Unit.Cm(0.375R))
        Me.HtmlTextBox7.Style.Font.Name = "Open Sans"
        Me.HtmlTextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.HtmlTextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.HtmlTextBox7.Value = ")"
        '
        'Barcode1
        '
        Me.Barcode1.Encoder = QrCodeEncoder1
        Me.Barcode1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5R), Telerik.Reporting.Drawing.Unit.Cm(1.5R))
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.Barcode1.Stretch = True
        Me.Barcode1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Barcode1.Style.Font.Bold = True
        Me.Barcode1.Style.Font.Name = "Open Sans"
        Me.Barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Barcode1.Value = "= Fields.GUID_MDLNumber"
        '
        'MDL_Report_PatientDetails
        '
        Me.DataSource = Me.PatientDetails
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "MDL_Report_PatientDetails"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(5.0R))
        Me.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(10.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents PatientDetails As Telerik.Reporting.JsonDataSource
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox5 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox2 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox3 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents HtmlTextBox4 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox6 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents HtmlTextBox7 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents Barcode1 As Telerik.Reporting.Barcode
End Class