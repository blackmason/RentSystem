using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentSystem_DevExpress.UserControl
{
    public partial class Summary : System.Windows.Forms.UserControl
    {
        public Summary()
        {
            InitializeComponent();
            SetToolTip();
        }

        /*
         * 마우스 오버시 툴팁 보여줌
         */
        public void SetToolTip()
        {
            tooltipSummary.SetToolTip(groupBox6, "약 1개월 후 보험만료 차량 입니다.");
        }
    }
}
