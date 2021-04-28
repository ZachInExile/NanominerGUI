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
        public string strEmail;
        public string strRigName = System.Environment.MachineName;

        //config.ini variables
        static string strConfigLine1 = "[Etchash]";
        static string strConfigLine2 = "wallet = ";
        static string strConfigLine3 = "coin = Etc";
        static string strConfigLine4 = "rigName = ";
        static string strConfigLine5 = "email = ";

        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            //----- Testing -----
            textBoxETCAddress.Text = "0x98bdf1563461dca87f6e5fe9e5ad75dc4147b313";
            textBoxRigName.Text = strRigName;

            if (File.Exists("config.ini"))
            {
                Console.Write("FOUND CONFIG.INI");
            }
            else
            {
                MessageBox.Show("the file doesn't exist. i have depression");
            }
            //--------------------
        }

        private void SetVariables()
        {
            if (textBoxETCAddress.Text == null | textBoxETCAddress.Text == "")
            {
                MessageBox.Show("Provide an ETC wallet address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                strETCaddress = textBoxETCAddress.Text;
            }

            if (textBoxEmail.Text == null | textBoxEmail.Text == "")
            {
                MessageBox.Show("Provide an email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                strEmail = textBoxEmail.Text;
            }

            if (textBoxRigName.Text == null | textBoxRigName.Text == "")
            {
                strRigName = System.Environment.MachineName;
                textBoxRigName.Text = strRigName;
            }
            else
            {
                strRigName = textBoxRigName.Text;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to overwrite your current config.ini with these settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                if (!File.Exists("config.ini"))
                {
                    MessageBox.Show("WARNING: Could not find config.ini, double check it exists in the same folder as this exe");
                }
                else
                {
                    SetVariables();

                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter("config.ini");
                        sw.WriteLine(strConfigLine1);
                        sw.WriteLine(strConfigLine2 + strETCaddress);
                        sw.WriteLine(strConfigLine3);
                        sw.WriteLine(strConfigLine4 + strRigName);
                        sw.WriteLine(strConfigLine5 + strEmail);
                        //Close the file
                        sw.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Exception: " + exception.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Saved");
                    }
                }
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this doesnt do anything yet lol");
        }
    }
}
