using RentSystem_DevExpress.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentSystem_DevExpress
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            AddSummaryUserControl();
        }

        /*
         * 요약화면 사용자 정의 컨트롤
         */
        public void AddSummaryUserControl()
        {
            Summary summary = new Summary();
            xtraTabPage1.Controls.Add(summary);
            summary.Dock = DockStyle.Fill;
        }
    }
}
