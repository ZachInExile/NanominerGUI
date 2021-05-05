
namespace NanominerGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxETCAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxRigName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxETH = new System.Windows.Forms.CheckBox();
            this.checkBoxERG = new System.Windows.Forms.CheckBox();
            this.checkBoxCFX = new System.Windows.Forms.CheckBox();
            this.checkBoxRVN = new System.Windows.Forms.CheckBox();
            this.checkBoxUBQ = new System.Windows.Forms.CheckBox();
            this.checkBoxETC = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxXMR = new System.Windows.Forms.CheckBox();
            this.checkBoxVRSC = new System.Windows.Forms.CheckBox();
            this.checkBoxNanopool = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxETCAddress
            // 
            this.textBoxETCAddress.Location = new System.Drawing.Point(12, 27);
            this.textBoxETCAddress.Name = "textBoxETCAddress";
            this.textBoxETCAddress.Size = new System.Drawing.Size(305, 23);
            this.textBoxETCAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ethereum Classic (ETC) Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxRigName
            // 
            this.textBoxRigName.Location = new System.Drawing.Point(12, 84);
            this.textBoxRigName.Name = "textBoxRigName";
            this.textBoxRigName.Size = new System.Drawing.Size(305, 23);
            this.textBoxRigName.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 193);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 47);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save to File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 246);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 47);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load from File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(119, 193);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(198, 100);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rig Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVRSC);
            this.groupBox1.Controls.Add(this.checkBoxXMR);
            this.groupBox1.Controls.Add(this.checkBoxETH);
            this.groupBox1.Controls.Add(this.checkBoxERG);
            this.groupBox1.Controls.Add(this.checkBoxCFX);
            this.groupBox1.Controls.Add(this.checkBoxRVN);
            this.groupBox1.Controls.Add(this.checkBoxUBQ);
            this.groupBox1.Controls.Add(this.checkBoxETC);
            this.groupBox1.Location = new System.Drawing.Point(333, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coin";
            // 
            // checkBoxETH
            // 
            this.checkBoxETH.AutoSize = true;
            this.checkBoxETH.Enabled = false;
            this.checkBoxETH.Location = new System.Drawing.Point(6, 97);
            this.checkBoxETH.Name = "checkBoxETH";
            this.checkBoxETH.Size = new System.Drawing.Size(47, 19);
            this.checkBoxETH.TabIndex = 5;
            this.checkBoxETH.Text = "ETH";
            this.checkBoxETH.UseVisualStyleBackColor = true;
            // 
            // checkBoxERG
            // 
            this.checkBoxERG.AutoSize = true;
            this.checkBoxERG.Enabled = false;
            this.checkBoxERG.Location = new System.Drawing.Point(6, 47);
            this.checkBoxERG.Name = "checkBoxERG";
            this.checkBoxERG.Size = new System.Drawing.Size(47, 19);
            this.checkBoxERG.TabIndex = 4;
            this.checkBoxERG.Text = "ERG";
            this.checkBoxERG.UseVisualStyleBackColor = true;
            // 
            // checkBoxCFX
            // 
            this.checkBoxCFX.AutoSize = true;
            this.checkBoxCFX.Enabled = false;
            this.checkBoxCFX.Location = new System.Drawing.Point(6, 22);
            this.checkBoxCFX.Name = "checkBoxCFX";
            this.checkBoxCFX.Size = new System.Drawing.Size(47, 19);
            this.checkBoxCFX.TabIndex = 3;
            this.checkBoxCFX.Text = "CFX";
            this.checkBoxCFX.UseVisualStyleBackColor = true;
            // 
            // checkBoxRVN
            // 
            this.checkBoxRVN.AutoSize = true;
            this.checkBoxRVN.Enabled = false;
            this.checkBoxRVN.Location = new System.Drawing.Point(6, 122);
            this.checkBoxRVN.Name = "checkBoxRVN";
            this.checkBoxRVN.Size = new System.Drawing.Size(49, 19);
            this.checkBoxRVN.TabIndex = 2;
            this.checkBoxRVN.Text = "RVN";
            this.checkBoxRVN.UseVisualStyleBackColor = true;
            // 
            // checkBoxUBQ
            // 
            this.checkBoxUBQ.AutoSize = true;
            this.checkBoxUBQ.Enabled = false;
            this.checkBoxUBQ.Location = new System.Drawing.Point(6, 147);
            this.checkBoxUBQ.Name = "checkBoxUBQ";
            this.checkBoxUBQ.Size = new System.Drawing.Size(50, 19);
            this.checkBoxUBQ.TabIndex = 1;
            this.checkBoxUBQ.Text = "UBQ";
            this.checkBoxUBQ.UseVisualStyleBackColor = true;
            // 
            // checkBoxETC
            // 
            this.checkBoxETC.AutoSize = true;
            this.checkBoxETC.Checked = true;
            this.checkBoxETC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxETC.Enabled = false;
            this.checkBoxETC.Location = new System.Drawing.Point(6, 72);
            this.checkBoxETC.Name = "checkBoxETC";
            this.checkBoxETC.Size = new System.Drawing.Size(45, 19);
            this.checkBoxETC.TabIndex = 0;
            this.checkBoxETC.Text = "ETC";
            this.checkBoxETC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxNanopool);
            this.groupBox2.Location = new System.Drawing.Point(333, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkBoxXMR
            // 
            this.checkBoxXMR.AutoSize = true;
            this.checkBoxXMR.Enabled = false;
            this.checkBoxXMR.Location = new System.Drawing.Point(136, 22);
            this.checkBoxXMR.Name = "checkBoxXMR";
            this.checkBoxXMR.Size = new System.Drawing.Size(85, 19);
            this.checkBoxXMR.TabIndex = 11;
            this.checkBoxXMR.Text = "XMR (CPU)";
            this.checkBoxXMR.UseVisualStyleBackColor = true;
            // 
            // checkBoxVRSC
            // 
            this.checkBoxVRSC.AutoSize = true;
            this.checkBoxVRSC.Enabled = false;
            this.checkBoxVRSC.Location = new System.Drawing.Point(136, 47);
            this.checkBoxVRSC.Name = "checkBoxVRSC";
            this.checkBoxVRSC.Size = new System.Drawing.Size(88, 19);
            this.checkBoxVRSC.TabIndex = 11;
            this.checkBoxVRSC.Text = "VRSC (CPU)";
            this.checkBoxVRSC.UseVisualStyleBackColor = true;
            // 
            // checkBoxNanopool
            // 
            this.checkBoxNanopool.AutoSize = true;
            this.checkBoxNanopool.Location = new System.Drawing.Point(6, 15);
            this.checkBoxNanopool.Name = "checkBoxNanopool";
            this.checkBoxNanopool.Size = new System.Drawing.Size(188, 19);
            this.checkBoxNanopool.TabIndex = 11;
            this.checkBoxNanopool.Text = "Open Nanopool site on launch";
            this.checkBoxNanopool.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRigName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxETCAddress);
            this.Name = "Form1";
            this.Text = "Nanominer GUI by Zachonite";
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxETCAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxRigName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxETH;
        private System.Windows.Forms.CheckBox checkBoxERG;
        private System.Windows.Forms.CheckBox checkBoxCFX;
        private System.Windows.Forms.CheckBox checkBoxRVN;
        private System.Windows.Forms.CheckBox checkBoxUBQ;
        private System.Windows.Forms.CheckBox checkBoxETC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxVRSC;
        private System.Windows.Forms.CheckBox checkBoxXMR;
        private System.Windows.Forms.CheckBox checkBoxNanopool;
    }
}

