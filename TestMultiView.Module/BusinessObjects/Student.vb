Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
<DefaultClassOptions()> _
Public Class Student ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        If Module1.xGen = 0 Then
            Me.Gender = GenderType.Male
        Else
            Me.Gender = GenderType.Female
        End If
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Private _StudentID As String
    Public Property StudentID() As String
        Get
            Return _StudentID
        End Get
        Set(ByVal value As String)
            SetPropertyValue("StudentID", _StudentID, value)
        End Set
    End Property

    Private _StudentName As String
    Public Property StudentName() As String
        Get
            Return _StudentName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("StudentName", _StudentName, value)
        End Set
    End Property

    Private _Gender As GenderType
    Public Property Gender() As GenderType
        Get
            Return _Gender
        End Get
        Set(ByVal value As GenderType)
            SetPropertyValue("Gender", _Gender, value)
        End Set
    End Property

    Private _Age As Integer
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue("Age", _Age, value)
        End Set
    End Property


    Public Enum GenderType
        Male
        Female
    End Enum


    '<Action(Caption:="My UI Action", ConfirmationMessage:="Are you sure?", ImageName:="Attention", AutoCommit:=True)> _
    'Public Sub ActionMethod()
    '    ' Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
    '    Me.PersistentProperty = "Paid"
    'End Sub
End Class
