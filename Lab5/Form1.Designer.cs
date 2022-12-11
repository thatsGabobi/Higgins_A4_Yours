﻿namespace Lab5
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.radStats = new System.Windows.Forms.RadioButton();
            this.radText = new System.Windows.Forms.RadioButton();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.chkSwap = new System.Windows.Forms.CheckBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblOdd = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudHowMany = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.grpChoose.SuspendLayout();
            this.grpText.SuspendLayout();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHowMany)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtCode);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.lblCode);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(15, 15);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogin.Size = new System.Drawing.Size(707, 73);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(578, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(387, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(133, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Location = new System.Drawing.Point(173, 28);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(117, 27);
            this.lblCode.TabIndex = 1;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Code:";
            // 
            // grpChoose
            // 
            this.grpChoose.BackColor = System.Drawing.Color.Gold;
            this.grpChoose.Controls.Add(this.radStats);
            this.grpChoose.Controls.Add(this.radText);
            this.grpChoose.Location = new System.Drawing.Point(16, 96);
            this.grpChoose.Margin = new System.Windows.Forms.Padding(4);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Padding = new System.Windows.Forms.Padding(4);
            this.grpChoose.Size = new System.Drawing.Size(707, 56);
            this.grpChoose.TabIndex = 1;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "Choose...";
            // 
            // radStats
            // 
            this.radStats.AutoSize = true;
            this.radStats.Location = new System.Drawing.Point(442, 22);
            this.radStats.Name = "radStats";
            this.radStats.Size = new System.Drawing.Size(60, 20);
            this.radStats.TabIndex = 1;
            this.radStats.TabStop = true;
            this.radStats.Text = "Stats";
            this.radStats.UseVisualStyleBackColor = true;
            this.radStats.CheckedChanged += new System.EventHandler(this.radStats_CheckedChanged);
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Location = new System.Drawing.Point(82, 22);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(54, 20);
            this.radText.TabIndex = 0;
            this.radText.TabStop = true;
            this.radText.Text = "Text";
            this.radText.UseVisualStyleBackColor = true;
            this.radText.CheckedChanged += new System.EventHandler(this.radText_CheckedChanged);
            // 
            // grpText
            // 
            this.grpText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpText.Controls.Add(this.btnReset);
            this.grpText.Controls.Add(this.btnAnalyze);
            this.grpText.Controls.Add(this.btnJoin);
            this.grpText.Controls.Add(this.lblResults);
            this.grpText.Controls.Add(this.chkSwap);
            this.grpText.Controls.Add(this.txtString2);
            this.grpText.Controls.Add(this.txtString1);
            this.grpText.Controls.Add(this.label4);
            this.grpText.Controls.Add(this.label3);
            this.grpText.Location = new System.Drawing.Point(17, 164);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(356, 242);
            this.grpText.TabIndex = 2;
            this.grpText.TabStop = false;
            this.grpText.Text = "Text";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(128, 200);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(96, 30);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "&Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(17, 200);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(96, 30);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "&Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Location = new System.Drawing.Point(17, 108);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(317, 82);
            this.lblResults.TabIndex = 5;
            // 
            // chkSwap
            // 
            this.chkSwap.AutoSize = true;
            this.chkSwap.Location = new System.Drawing.Point(17, 81);
            this.chkSwap.Name = "chkSwap";
            this.chkSwap.Size = new System.Drawing.Size(63, 20);
            this.chkSwap.TabIndex = 2;
            this.chkSwap.Text = "Swap";
            this.chkSwap.UseVisualStyleBackColor = true;
            this.chkSwap.CheckedChanged += new System.EventHandler(this.chkSwap_CheckedChanged);
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(124, 54);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(210, 23);
            this.txtString2.TabIndex = 1;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(124, 20);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(210, 23);
            this.txtString1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "String #2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "String #1:";
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.Beige;
            this.grpStats.Controls.Add(this.btnClear);
            this.grpStats.Controls.Add(this.lstNumbers);
            this.grpStats.Controls.Add(this.btnGenerate);
            this.grpStats.Controls.Add(this.lblOdd);
            this.grpStats.Controls.Add(this.lblMean);
            this.grpStats.Controls.Add(this.lblSum);
            this.grpStats.Controls.Add(this.label8);
            this.grpStats.Controls.Add(this.label7);
            this.grpStats.Controls.Add(this.label6);
            this.grpStats.Controls.Add(this.nudHowMany);
            this.grpStats.Controls.Add(this.label5);
            this.grpStats.Location = new System.Drawing.Point(381, 164);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(341, 242);
            this.grpStats.TabIndex = 3;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(176, 20);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(155, 164);
            this.lstNumbers.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(19, 200);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 30);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblOdd
            // 
            this.lblOdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOdd.Location = new System.Drawing.Point(71, 157);
            this.lblOdd.Name = "lblOdd";
            this.lblOdd.Size = new System.Drawing.Size(98, 27);
            this.lblOdd.TabIndex = 8;
            this.lblOdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMean
            // 
            this.lblMean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMean.Location = new System.Drawing.Point(71, 113);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(98, 27);
            this.lblMean.TabIndex = 7;
            this.lblMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSum
            // 
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSum.Location = new System.Drawing.Point(71, 70);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(98, 27);
            this.lblSum.TabIndex = 6;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Odd:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mean:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sum:";
            // 
            // nudHowMany
            // 
            this.nudHowMany.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHowMany.Location = new System.Drawing.Point(107, 22);
            this.nudHowMany.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHowMany.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHowMany.Name = "nudHowMany";
            this.nudHowMany.Size = new System.Drawing.Size(62, 23);
            this.nudHowMany.TabIndex = 2;
            this.nudHowMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHowMany.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "How Many?";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 418);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpText);
            this.Controls.Add(this.grpChoose);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab5 by";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpChoose.ResumeLayout(false);
            this.grpChoose.PerformLayout();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHowMany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radStats;
        private System.Windows.Forms.RadioButton radText;
        private System.Windows.Forms.CheckBox chkSwap;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblOdd;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudHowMany;
        private System.Windows.Forms.Label label5;
    }
}

