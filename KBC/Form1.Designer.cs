namespace KBC
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.rbbtna = new System.Windows.Forms.RadioButton();
            this.rbbtnb = new System.Windows.Forms.RadioButton();
            this.rbbtnc = new System.Windows.Forms.RadioButton();
            this.rbbtnd = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblrandom = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.QNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(45, 94);
            this.lblquestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(76, 20);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Question";
            // 
            // rbbtna
            // 
            this.rbbtna.AutoSize = true;
            this.rbbtna.Location = new System.Drawing.Point(20, 22);
            this.rbbtna.Margin = new System.Windows.Forms.Padding(4);
            this.rbbtna.Name = "rbbtna";
            this.rbbtna.Size = new System.Drawing.Size(79, 20);
            this.rbbtna.TabIndex = 1;
            this.rbbtna.TabStop = true;
            this.rbbtna.Text = "Option A";
            this.rbbtna.UseVisualStyleBackColor = true;
            this.rbbtna.CheckedChanged += new System.EventHandler(this.rbbtna_CheckedChanged);
            // 
            // rbbtnb
            // 
            this.rbbtnb.AutoSize = true;
            this.rbbtnb.Location = new System.Drawing.Point(20, 95);
            this.rbbtnb.Margin = new System.Windows.Forms.Padding(4);
            this.rbbtnb.Name = "rbbtnb";
            this.rbbtnb.Size = new System.Drawing.Size(79, 20);
            this.rbbtnb.TabIndex = 2;
            this.rbbtnb.TabStop = true;
            this.rbbtnb.Text = "Option B";
            this.rbbtnb.UseVisualStyleBackColor = true;
            this.rbbtnb.CheckedChanged += new System.EventHandler(this.rbbtnb_CheckedChanged);
            // 
            // rbbtnc
            // 
            this.rbbtnc.AutoSize = true;
            this.rbbtnc.Location = new System.Drawing.Point(20, 162);
            this.rbbtnc.Margin = new System.Windows.Forms.Padding(4);
            this.rbbtnc.Name = "rbbtnc";
            this.rbbtnc.Size = new System.Drawing.Size(79, 20);
            this.rbbtnc.TabIndex = 3;
            this.rbbtnc.TabStop = true;
            this.rbbtnc.Text = "Option C";
            this.rbbtnc.UseVisualStyleBackColor = true;
            this.rbbtnc.CheckedChanged += new System.EventHandler(this.rbbtnc_CheckedChanged);
            // 
            // rbbtnd
            // 
            this.rbbtnd.AutoSize = true;
            this.rbbtnd.Location = new System.Drawing.Point(20, 227);
            this.rbbtnd.Margin = new System.Windows.Forms.Padding(4);
            this.rbbtnd.Name = "rbbtnd";
            this.rbbtnd.Size = new System.Drawing.Size(80, 20);
            this.rbbtnd.TabIndex = 4;
            this.rbbtnd.TabStop = true;
            this.rbbtnd.Text = "Option D";
            this.rbbtnd.UseVisualStyleBackColor = true;
            this.rbbtnd.CheckedChanged += new System.EventHandler(this.rbbtnd_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(665, 526);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(143, 42);
            this.btn.TabIndex = 5;
            this.btn.Text = "Next";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(49, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 12);
            this.panel1.TabIndex = 6;
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrandom.Location = new System.Drawing.Point(487, 546);
            this.lblrandom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(73, 20);
            this.lblrandom.TabIndex = 7;
            this.lblrandom.Text = "lblrndom";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(296, 526);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 42);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // QNumber
            // 
            this.QNumber.AutoSize = true;
            this.QNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QNumber.Location = new System.Drawing.Point(80, 35);
            this.QNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QNumber.Name = "QNumber";
            this.QNumber.Size = new System.Drawing.Size(102, 20);
            this.QNumber.TabIndex = 9;
            this.QNumber.Text = "Question No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbbtnc);
            this.groupBox1.Controls.Add(this.rbbtna);
            this.groupBox1.Controls.Add(this.rbbtnb);
            this.groupBox1.Controls.Add(this.rbbtnd);
            this.groupBox1.Location = new System.Drawing.Point(49, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 274);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QNumber);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblrandom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblquestion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rbbtna;
        private System.Windows.Forms.RadioButton rbbtnb;
        private System.Windows.Forms.RadioButton rbbtnc;
        private System.Windows.Forms.RadioButton rbbtnd;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label QNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

