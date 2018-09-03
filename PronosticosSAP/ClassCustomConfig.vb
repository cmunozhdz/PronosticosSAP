Imports System.Windows.Forms
Imports System.Configuration

Public Class ClassCustomConfig
    Inherits ApplicationSettingsBase
    <ApplicationScopedSetting()> _
        <DefaultSettingValue("(local)")> _
    Public Property Connection As String
        Get
            Return My.Settings("ForeCastSapConnectionString").ToString


        End Get
        Set(ByVal value As String)
            My.Settings("ForeCastSapConnectionString") = value


        End Set
    End Property
    <ApplicationScopedSetting()> _
        <DefaultSettingValue("(local)")> _
    Public Property DiasAgricolas As Integer
        Get
            Return My.Settings.DiaCongelaAgricola

        End Get
        Set(ByVal value As Integer)
            'My.Settings.DiaCongelaAgricola = value
            My.Settings("DiaCongelaAgricola") = value

        End Set
    End Property
    <ApplicationScopedSetting()> _
        <DefaultSettingValue("(local)")> _
    Public Property DiasIndustrial() As Integer
        Get
            Return My.Settings.DiaCongelaIndustrial
        End Get
        Set(ByVal value As Integer)
            My.Settings("DiaCongelaIndustrial") = value

        End Set
    End Property
    <UserScopedSetting()> _
    <DefaultSettingValue("300")> _
    Public Property DelayAutoSave() As Long
        Get
            Return My.Settings.AutoSave

        End Get
        Set(ByVal value As Long)
            My.Settings.AutoSave = value

        End Set
    End Property

    <UserScopedSetting()> _
    Public Property AplicaAgricolaHabiles() As Boolean

        Get
            Return ModComun.FnStr2Bol(My.Settings.DiasHabilesAgricola)
        End Get
        Set(ByVal value As Boolean)
            If value Then
                My.Settings.DiasHabilesAgricola = "S"
            Else
                My.Settings.DiasHabilesAgricola = "N"
            End If
        End Set
    End Property
    <UserScopedSetting()> _
    Public Property AplicaIndustrialHabiles() As Boolean

        Get
            Return ModComun.FnStr2Bol(My.Settings.DiasHabilesI)
        End Get
        Set(ByVal value As Boolean)
            If value Then
                My.Settings.DiasHabilesI = "S"
            Else
                My.Settings.DiasHabilesI = "N"
            End If
        End Set
    End Property







    Public Overrides Sub Save()
        MyBase.Save()
        My.Settings.Save()
       


    End Sub


End Class
