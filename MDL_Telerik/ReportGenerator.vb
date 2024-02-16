Module ReportGenerator

    Sub Main()
        Try

            Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor()

            'set any deviceInfo settings if necessary
            Dim deviceInfo As New System.Collections.Hashtable()

            ' Depending on the report definition choose ONE of the following REPORT SOURCES
            '                  -1-
            '' ***CLR (VB) report definitions***
            'Dim reportSource As New Telerik.Reporting.TypeReportSource()

            '' reportName is the Assembly Qualified Name of the report
            'reportSource.TypeName = "MDL_Report"
            ''                  -1-

            ''                  -2-
            '' ***Declarative (TRDP/TRDX) report definitions***
            'Dim reportSource As New Telerik.Reporting.UriReportSource()

            '' reportName Is the path to the TRDP/TRDX file
            'reportSource.Uri = reportName
            ''                  -2-

            '                  -3-
            ' ***Instance of the report definition***
            Dim reportSource As New Telerik.Reporting.InstanceReportSource()

            ' Report1 Is the type of the report. It should inherit Telerik.Reporting.Report
            reportSource.ReportDocument = New MDL_Report()
            '                  -3-

            'Dim parameterValue As Object = "Some Parameter Value"
            'reportSource.Parameters.Add("ParameterName", parameterValue)

            Dim result As Telerik.Reporting.Processing.RenderingResult = reportProcessor.RenderReport("PDF", reportSource, deviceInfo)

            If Not result.HasErrors Then

                Dim fileName As String = result.DocumentName + DateTime.Now.ToString("_yyyy_MM_dd_hhmmssfff") + "." + result.Extension

                Dim path As String = System.IO.Path.GetTempPath()

                Dim filePath As String = System.IO.Path.Combine(path, fileName)

                Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Create)
                    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length)
                End Using

            End If

        Catch ex As Exception

            Console.WriteLine(ex)

        End Try

    End Sub

End Module
