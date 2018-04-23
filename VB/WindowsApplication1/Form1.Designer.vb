Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.myDateEdit1 = New WindowsApplication1.MyDateEdit()
            DirectCast(Me.myDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myDateEdit1
            ' 
            Me.myDateEdit1.EditValue = Nothing
            Me.myDateEdit1.Location = New System.Drawing.Point(9, 10)
            Me.myDateEdit1.Margin = New System.Windows.Forms.Padding(2)
            Me.myDateEdit1.Name = "myDateEdit1"
            Me.myDateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.myDateEdit1.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True
            Me.myDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.myDateEdit1.Properties.ShowOk = DevExpress.Utils.DefaultBoolean.True
            Me.myDateEdit1.Size = New System.Drawing.Size(264, 20)
            Me.myDateEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 67)
            Me.Controls.Add(Me.myDateEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myDateEdit1 As MyDateEdit


    End Class
End Namespace

