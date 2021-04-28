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
using System.Diagnostics;

namespace NanominerGUI
{
    public partial class Form1 : Form
    {
        public string thisLoc = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        public string strETCaddress;
        public string strEmail;
        public string strRigName = System.Environment.MachineName;
        public bool boolValidated;

        //config.ini variables
        static string strConfigLine1 = "[Etchash]";
        static string strConfigLine2 = "wallet=";
        static string strConfigLine3 = "coin=Etc";
        static string strConfigLine4 = "rigName=";
        static string strConfigLine5 = "email=";

        public Form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            LoadSettings();
        }

        private void SetVariables()
        {
            boolValidated = true;

            if (textBoxETCAddress.Text == null | textBoxETCAddress.Text == "")
            {
                MessageBox.Show("Provide an ETC wallet address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boolValidated = false;
            }
            else
            {
                strETCaddress = textBoxETCAddress.Text;
            }

            if (textBoxEmail.Text == null | textBoxEmail.Text == "")
            {
                MessageBox.Show("Provide an email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boolValidated = false;
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
        private void LoadSettings()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("config.ini");

                line = sr.ReadLine(); //[Etchash] STATIC

                line = sr.ReadLine(); //wallet=12345
                textBoxETCAddress.Text = line.Replace("wallet=", "");

                line = sr.ReadLine(); //coin=Etc STATIC

                line = sr.ReadLine(); //rigName=rigname
                textBoxRigName.Text = line.Replace("rigName=", "");

                line = sr.ReadLine(); //email=email@
                textBoxEmail.Text = line.Replace("email=", "");

                sr.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception.Message);
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

                    if (boolValidated)
                    {
                        try
                        {
                            //Pass the filepath and filename to the StreamWriter Constructor
                            StreamWriter sw = new StreamWriter("config.ini", false);
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
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to overwrite your current settings with those in config.ini? (This just reads the config.ini for now, doesn't actually do anything)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                LoadSettings();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (File.Exists("nanominer.exe"))
            {
                MessageBox.Show("nanominer.exe found");
                //Process.Start("nanominer.exe");
            }
            else
            {
                MessageBox.Show("nanominer.exe NOT FOUND :( SAD DAY TO BE ALIVE");
            }
        }
    }
}
