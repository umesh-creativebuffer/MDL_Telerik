
Public Class ReportModel
    Public Property PCI As PCI_Model
    Public Property Specimens As List(Of Specimen_Model)
End Class

Public Class PCI_Model
    Public Property GUID_MDLNumber As String
    Public Property Results_Status As String
    Public Property SSN As String
    Public Property Date_Of_Birth As String
    Public Property Age As Integer
    Public Property Patient_Name As String
    Public Property Patient_Address As String
    Public Property Patient_Phone As String
    Public Property Patient_Ethnicity As String
    Public Property UPIN As String
    Public Property Client_Name As String
    Public Property Physician_Name As String
    Public Property Client_Address As String
    Public Property Client_WorkPhone As String
    Public Property Tel As String
    Public Property Fax As String
    Public Property Client_AssistantName As String
    Public Property CopyToPhys1 As String
    Public Property CopyToPhys2 As String
    Public Property PatientID As String
    Public Property Date_Processed As String
    Public Property Date_Reported As String
    Public Property ClientID As String
    Public Property GUID_VersionID As String
    Public Property Txt_InterpInfoForOPA As String
    Public Property ZipCode As String
    Public Property CopyTo_FaxNumber As String
    Public Property AbnormalSign As String
    Public Property GUID_Speciality As String
    Public Property PT_Gender As String
    Public Property Guid_PatientID As String
    Public Property Guid_Patient_VersionID As String
End Class


Public Class Specimen_Model
    Public Property GUID_MDLNumber As String
    Public Property Specimen_Num As Integer
    Public Property Date_Collected As String
    Public Property Date_Received As String
    Public Property Txt_SpecimenName As String
    Public Property Txt_Source As String
    Public Property SpecimenCount As Integer
End Class