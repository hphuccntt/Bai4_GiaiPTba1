using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_GiaiPTba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int intA = Convert.ToInt32(txtA.Text);
            int intB = Convert.ToInt32(txtB.Text);
            double X;

            if (intA == 0 && intB == 0)
            {
                txtKQ.Text = " Phuong Trinh Co Vo So Nghiem ";
            }
            else if (intA == 0 && intB != 0)
            {
                txtKQ.Text = " Phuong Trinh Vo Nghiem ";
            }
            else
            {
                X = (double)-intB / intA;
                txtKQ.Text = " Phuong Trinh Co 1 Nghiem Duy Nhat x = " + X;

            }
        }
    }
}
