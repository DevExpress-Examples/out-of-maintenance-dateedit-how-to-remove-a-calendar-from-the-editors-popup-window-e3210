Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MyDateEdit
        Inherits DateEdit

        Public Sub New()
        End Sub
        Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
            Return New MyVistaPopupDateEditForm(Me)
        End Function
    End Class

    Public Class MyVistaPopupDateEditForm
        Inherits VistaPopupDateEditForm

        Public Sub New(ByVal ownerEdit As DateEdit)
            MyBase.New(ownerEdit)
        End Sub
        Protected Overrides Function CreateCalendar() As CalendarControl
            Dim c As New MyVistaDateEditCalendar()
            Return c
        End Function
    End Class

    Public Class MyVistaDateEditCalendar
        Inherits CalendarControl

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Function CalcBestSize() As Size
            Dim size As Size = MyBase.CalcBestSize()
            Return New Size(ViewInfo.RightAreaSize.Width + 40, size.Height - 40)

        End Function
        Protected Overrides Function CreatePainter() As DevExpress.XtraEditors.Drawing.BaseControlPainter
            Dim p = New MyVistaDateEditCalendarObjectPainter()
            Return p
        End Function

        Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
            Dim v = New MyVistaCalendarViewInfo(Me)
            Return v
        End Function

        Protected Overrides ReadOnly Property IsPopupCalendar() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides Property ShowOkButton() As DefaultBoolean
            Get
                Return DefaultBoolean.True
            End Get
            Set(ByVal value As DefaultBoolean)
            End Set
        End Property
    End Class

    Public Class MyVistaCalendarViewInfo
        Inherits VistaCalendarViewInfo

        Public Sub New(ByVal owner As CalendarControlBase)
            MyBase.New(owner)

        End Sub
        Protected Overrides Function CreateRightAreaInfo() As CalendarAreaViewInfoBase
            Return MyBase.CreateRightAreaInfo()
        End Function

        Protected Overrides Function CalcFooterSize() As Size
            Dim s As Size = MyBase.CalcFooterSize()
            s.Height += 50
            Return s
        End Function


        Protected Overrides Function CalcCalendarsClientBounds(ByVal bounds As Rectangle) As Rectangle
            Dim rect As Rectangle = MyBase.CalcCalendarsClientBounds(bounds)
            rect.Y = 2
            Return rect
        End Function

        Protected Overrides Function CreateFooterInfo() As CalendarFooterViewInfoBase
            Dim info As New MyVistaCalendarFooterViewInfo(Me)
            Return info
        End Function
        Protected Overrides Function CalcRightAreaBounds() As Rectangle
            Dim rect As Rectangle = MyBase.CalcRightAreaBounds()
            Dim x As Integer = (Me.OwnerControl.CalcBestSize().Width \ 2) - rect.Width \ 2
            rect.X = x
            rect.Y = 10
            Return rect
        End Function

    End Class
    Public Class MyVistaCalendarFooterViewInfo
        Inherits VistaCalendarFooterViewInfo

        Public Sub New(ByVal viewInfo As CalendarViewInfoBase)
            MyBase.New(viewInfo)
        End Sub
        Protected Overrides Function CalcOkButtonBounds() As Rectangle
            Dim rect As Rectangle = MyBase.CalcOkButtonBounds()
            rect.Y += 30
            rect.X += 28
            Return rect
        End Function

        Protected Overrides Function CalcClearButtonBounds() As Rectangle
            Dim rect As Rectangle = MyBase.CalcClearButtonBounds()
            rect.Y += 30
            rect.X = 5
            Return rect
        End Function

        Protected Overrides Function CalcCancelButtonBounds() As Rectangle
            Dim rect As Rectangle = MyBase.CalcCancelButtonBounds()
            rect.Y += 30
            rect.X -= 40
            Return rect
        End Function

        Protected Overrides Function CalcButtonPanelBounds() As Rectangle
            Dim rect As Rectangle = MyBase.CalcButtonPanelBounds()
            Return rect
        End Function
    End Class

    Public Class MyVistaDateEditCalendarObjectPainter
        Inherits VistaDateEditCalendarObjectPainter

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides Sub DrawBackground(ByVal info As CalendarControlInfoArgs)
            MyBase.DrawBackground(info)
        End Sub
        Protected Overrides Sub DrawHeader(ByVal info As CalendarControlInfoArgs)
        End Sub
        Protected Overrides Sub DrawAdornments(ByVal info As ControlGraphicsInfoArgs)
        End Sub

        Protected Overrides Sub DrawCalendars(ByVal info As CalendarControlInfoArgs)
        End Sub

    End Class
End Namespace