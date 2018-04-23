namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myDateEdit1 = new WindowsApplication1.MyDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myDateEdit1
            // 
            this.myDateEdit1.EditValue = null;
            this.myDateEdit1.Location = new System.Drawing.Point(9, 10);
            this.myDateEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.myDateEdit1.Name = "myDateEdit1";
            this.myDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.myDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myDateEdit1.Properties.ShowOk = DevExpress.Utils.DefaultBoolean.True;
            this.myDateEdit1.Size = new System.Drawing.Size(264, 20);
            this.myDateEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 67);
            this.Controls.Add(this.myDateEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyDateEdit myDateEdit1;


    }
}

