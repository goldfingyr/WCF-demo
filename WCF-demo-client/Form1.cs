using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_demo_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            WCFService.WCF_DemoServiceClient client = new WCFService.WCF_DemoServiceClient("BasicHttpBinding_IWCF_DemoService");
            tbResult.Text = client.CsAdd(int.Parse(tbArg1.Text), int.Parse(tbArg2.Text)).ToString();
        }
    }
}
