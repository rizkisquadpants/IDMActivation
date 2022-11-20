namespace RTA_Activation_IDM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRekomen = new System.Windows.Forms.Label();
            this.lblDowIDM = new System.Windows.Forms.Label();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.btnActivation = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFireWall = new System.Windows.Forms.Label();
            this.btnFirewall = new System.Windows.Forms.Button();
            this.lblValueFirewall = new System.Windows.Forms.Label();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "RTA SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Internet Download Manager Activation";
            // 
            // lblRekomen
            // 
            this.lblRekomen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekomen.ForeColor = System.Drawing.Color.White;
            this.lblRekomen.Location = new System.Drawing.Point(12, 121);
            this.lblRekomen.Name = "lblRekomen";
            this.lblRekomen.Size = new System.Drawing.Size(507, 16);
            this.lblRekomen.TabIndex = 5;
            this.lblRekomen.Text = "Recommendation to use IDM Official Software";
            this.lblRekomen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDowIDM
            // 
            this.lblDowIDM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDowIDM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDowIDM.ForeColor = System.Drawing.Color.Green;
            this.lblDowIDM.Location = new System.Drawing.Point(13, 91);
            this.lblDowIDM.Name = "lblDowIDM";
            this.lblDowIDM.Size = new System.Drawing.Size(303, 16);
            this.lblDowIDM.TabIndex = 6;
            this.lblDowIDM.Text = "https://www.internetdownloadmanager.com/";
            this.lblDowIDM.Click += new System.EventHandler(this.lblDowIDM_Click);
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(164, 427);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(100, 20);
            this.txtScript.TabIndex = 7;
            this.txtScript.Text = resources.GetString("txtScript.Text");
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.Crimson;
            this.lblConnection.Location = new System.Drawing.Point(12, 222);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(507, 23);
            this.lblConnection.TabIndex = 8;
            this.lblConnection.Text = "Pastikan internet Terkoneksi";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.pnlMove.Controls.Add(this.label3);
            this.pnlMove.Controls.Add(this.btnMinimize);
            this.pnlMove.Controls.Add(this.btnAbout);
            this.pnlMove.Controls.Add(this.btnMaximize);
            this.pnlMove.Controls.Add(this.btnClose);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(532, 31);
            this.pnlMove.TabIndex = 14;
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "RTA CODE TEAM";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::RTA_Activation_IDM.Properties.Resources.Min;
            this.btnMinimize.Location = new System.Drawing.Point(418, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 31);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Crimson;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(339, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(64, 25);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = global::RTA_Activation_IDM.Properties.Resources.Max;
            this.btnMaximize.Location = new System.Drawing.Point(457, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 31);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximize.TabIndex = 16;
            this.btnMaximize.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::RTA_Activation_IDM.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(498, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 31);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEng.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEng.ForeColor = System.Drawing.Color.IndianRed;
            this.rbEng.Location = new System.Drawing.Point(372, 37);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(64, 20);
            this.rbEng.TabIndex = 18;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.rbEng_CheckedChanged);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.ForeColor = System.Drawing.Color.White;
            this.rbId.Location = new System.Drawing.Point(442, 37);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(79, 20);
            this.rbId.TabIndex = 19;
            this.rbId.Text = "Indonesia";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnActivation
            // 
            this.btnActivation.BackColor = System.Drawing.Color.Crimson;
            this.btnActivation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivation.FlatAppearance.BorderSize = 0;
            this.btnActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivation.ForeColor = System.Drawing.Color.White;
            this.btnActivation.Location = new System.Drawing.Point(12, 181);
            this.btnActivation.Name = "btnActivation";
            this.btnActivation.Size = new System.Drawing.Size(165, 31);
            this.btnActivation.TabIndex = 20;
            this.btnActivation.Text = "New Activation";
            this.btnActivation.UseVisualStyleBackColor = false;
            this.btnActivation.Click += new System.EventHandler(this.btnActivation_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(354, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 31);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset Trial / Activation";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFireWall
            // 
            this.lblFireWall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFireWall.ForeColor = System.Drawing.Color.Yellow;
            this.lblFireWall.Location = new System.Drawing.Point(12, 155);
            this.lblFireWall.Name = "lblFireWall";
            this.lblFireWall.Size = new System.Drawing.Size(506, 16);
            this.lblFireWall.TabIndex = 23;
            this.lblFireWall.Text = "Firewall Status : DISABLE";
            this.lblFireWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFirewall
            // 
            this.btnFirewall.BackColor = System.Drawing.Color.Crimson;
            this.btnFirewall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirewall.FlatAppearance.BorderSize = 0;
            this.btnFirewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirewall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirewall.ForeColor = System.Drawing.Color.White;
            this.btnFirewall.Location = new System.Drawing.Point(183, 181);
            this.btnFirewall.Name = "btnFirewall";
            this.btnFirewall.Size = new System.Drawing.Size(165, 31);
            this.btnFirewall.TabIndex = 24;
            this.btnFirewall.Text = "Disable / Enable Firewall";
            this.btnFirewall.UseVisualStyleBackColor = false;
            this.btnFirewall.Click += new System.EventHandler(this.btnFirewall_Click);
            // 
            // lblValueFirewall
            // 
            this.lblValueFirewall.AutoSize = true;
            this.lblValueFirewall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueFirewall.ForeColor = System.Drawing.Color.Crimson;
            this.lblValueFirewall.Location = new System.Drawing.Point(288, 155);
            this.lblValueFirewall.Name = "lblValueFirewall";
            this.lblValueFirewall.Size = new System.Drawing.Size(61, 16);
            this.lblValueFirewall.TabIndex = 25;
            this.lblValueFirewall.Text = "DISABLE";
            this.lblValueFirewall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(530, 258);
            this.Controls.Add(this.lblValueFirewall);
            this.Controls.Add(this.btnFirewall);
            this.Controls.Add(this.lblFireWall);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnActivation);
            this.Controls.Add(this.rbId);
            this.Controls.Add(this.rbEng);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.lblDowIDM);
            this.Controls.Add(this.lblRekomen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTA Activation IDM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRekomen;
        private System.Windows.Forms.Label lblDowIDM;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.Button btnActivation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblFireWall;
        private System.Windows.Forms.Button btnFirewall;
        private System.Windows.Forms.Label lblValueFirewall;
    }
}

