Imports Microsoft.VisualBasic
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
		Protected Overrides Function CreateCalendar() As DateEditCalendar
			Dim c As VistaDateEditCalendar = New MyVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)
			AddHandler c.OkClick, AddressOf OnOkClick
			Return c
		End Function
		Protected Overridable Overloads Sub OnOkClick(ByVal sender As Object, ByVal e As EventArgs)
			If OwnerEdit IsNot Nothing Then
				OwnerEdit.ClosePopup()
			End If
		End Sub


	End Class

	Public Class MyVistaDateEditCalendar
		Inherits VistaDateEditCalendar
		Public Sub New(ByVal item As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit, ByVal editDate As Object)
			MyBase.New(item, editDate)

		End Sub

		Public Overrides Function CalcBestSize(ByVal g As Graphics) As Size
			Return New Size(VistaCalendar.ClockTextRect.Width + 40, VistaCalendar.ClockRect.Height + VistaCalendar.ClockTextRect.Height +4 *VistaCalendar.IndentFromTopToClock)

		End Function

		Protected Overrides Function CreateInfoArgs() As DevExpress.XtraEditors.ViewInfo.DateEditInfoArgs
			Return New MyVistaDateEditInfoArgs(Me)
		End Function


	End Class

	Public Class MyVistaDateEditInfoArgs
		Inherits VistaDateEditInfoArgs
		Public Sub New(ByVal calendar As DateEditCalendarBase)
			MyBase.New(calendar)

		End Sub

		Public Overrides Sub CalcLayout(ByVal contentBounds As Rectangle, ByVal painter As DevExpress.XtraEditors.Calendar.CalendarBasePainter)
			contentBounds.Width = 10
			contentBounds.Y= -40
			MyBase.CalcLayout(contentBounds, painter)
			Dim buttonBounds As Rectangle = ClockTextRect
			buttonBounds.Y += 30
			buttonBounds.Width = ClockTextRect.Width \ 2 - 5
			OkRect = buttonBounds
			OkButtonRect = GetButtonRect(OkRect)
			buttonBounds.Offset(buttonBounds.Width + 5, 0)
			CancelRect = buttonBounds
			CancelButtonRect = GetButtonRect(buttonBounds)
		End Sub



	End Class


End Namespace