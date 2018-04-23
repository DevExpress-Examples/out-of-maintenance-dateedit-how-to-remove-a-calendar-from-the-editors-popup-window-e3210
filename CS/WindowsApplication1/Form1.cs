using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class MyDateEdit: DateEdit
    {
        
        public MyDateEdit()
        {
            
        }
        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new MyVistaPopupDateEditForm(this);
        }
    }

    public class MyVistaPopupDateEditForm : VistaPopupDateEditForm
    {
        public MyVistaPopupDateEditForm(DateEdit ownerEdit)
            : base(ownerEdit)
        {
            
        }
        protected override DateEditCalendar CreateCalendar()
        {
            VistaDateEditCalendar c = new MyVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
            c.OkClick += new EventHandler(OnOkClick);
            return c;
        }
        protected virtual void OnOkClick(object sender, EventArgs e)
        {
            if (OwnerEdit != null)
                OwnerEdit.ClosePopup();
        }


    }

    public class MyVistaDateEditCalendar : VistaDateEditCalendar
    {
        public MyVistaDateEditCalendar(DevExpress.XtraEditors.Repository.RepositoryItemDateEdit item, object editDate)
            : base(item, editDate)
        {
            
        }

        public override Size CalcBestSize(Graphics g)
        {
            return new Size(VistaCalendar.ClockTextRect.Width + 40, VistaCalendar.ClockRect.Height + VistaCalendar.ClockTextRect.Height  +4 *VistaCalendar.IndentFromTopToClock);
            
            }

        protected override DevExpress.XtraEditors.ViewInfo.DateEditInfoArgs CreateInfoArgs()
        {
            return new MyVistaDateEditInfoArgs(this);
        }
        
   
    }

    public class MyVistaDateEditInfoArgs : VistaDateEditInfoArgs
    {
        public MyVistaDateEditInfoArgs(DateEditCalendarBase calendar)
            : base(calendar)
        {
            
        }

        public override void CalcLayout(Rectangle contentBounds, DevExpress.XtraEditors.Calendar.CalendarBasePainter painter)
        {
            contentBounds.Width = 10;
            contentBounds.Y= -40;
            base.CalcLayout(contentBounds, painter);
            Rectangle buttonBounds = ClockTextRect;
            buttonBounds.Y += 30;
            buttonBounds.Width = ClockTextRect.Width / 2 - 5;
            OkRect = buttonBounds;
            OkButtonRect = GetButtonRect(OkRect);
            buttonBounds.Offset(buttonBounds.Width + 5, 0);
            CancelRect = buttonBounds;
            CancelButtonRect = GetButtonRect(buttonBounds);
        }


        
    }


}