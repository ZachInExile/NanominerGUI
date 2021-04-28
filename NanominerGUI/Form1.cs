using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace NanominerGUI
{
    public partial class Form1 : Form
    {
        public string thisLoc = Application.StartupPath;
        public string strETCaddress;

        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            //testing
            textBoxETCAddress.Text = "0x98bdf1563461dca87f6e5fe9e5ad75dc4147b313";
        }

        private void buttonValidateETC_Click(object sender, EventArgs e)
        {
        }
    }
}
