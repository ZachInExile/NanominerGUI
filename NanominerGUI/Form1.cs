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
        public string thisLoc = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public string strETCaddress;

        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            //----- Testing -----
            MessageBox.Show(thisLoc);
            textBoxETCAddress.Text = "0x98bdf1563461dca87f6e5fe9e5ad75dc4147b313";

            if (File.Exists("GUIconfig.ini"))
            {
                MessageBox.Show("the GUIconfig.ini exists");
            }
            else
            {
                MessageBox.Show("GUIconfig.ini doesn't exist. i have depression");
            }
            //--------------------
        }
    }
}
