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
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(34, 46);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(65, 17);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Question";
            // 
            // rbbtna
            // 
            this.rbbtna.AutoSize = true;
            this.rbbtna.Location = new System.Drawing.Point(37, 184);
            this.rbbtna.Name = "rbbtna";
            this.rbbtna.Size = new System.Drawing.Size(66, 17);
            this.rbbtna.TabIndex = 1;
            this.rbbtna.TabStop = true;
            this.rbbtna.Text = "Option A";
            this.rbbtna.UseVisualStyleBackColor = true;
            // 
            // rbbtnb
            // 
            this.rbbtnb.AutoSize = true;
            this.rbbtnb.Location = new System.Drawing.Point(37, 243);
            this.rbbtnb.Name = "rbbtnb";
            this.rbbtnb.Size = new System.Drawing.Size(66, 17);
            this.rbbtnb.TabIndex = 2;
            this.rbbtnb.TabStop = true;
            this.rbbtnb.Text = "Option B";
            this.rbbtnb.UseVisualStyleBackColor = true;
            // 
            // rbbtnc
            // 
            this.rbbtnc.AutoSize = true;
            this.rbbtnc.Location = new System.Drawing.Point(37, 297);
            this.rbbtnc.Name = "rbbtnc";
            this.rbbtnc.Size = new System.Drawing.Size(66, 17);
            this.rbbtnc.TabIndex = 3;
            this.rbbtnc.TabStop = true;
            this.rbbtnc.Text = "Option C";
            this.rbbtnc.UseVisualStyleBackColor = true;
            // 
            // rbbtnd
            // 
            this.rbbtnd.AutoSize = true;
            this.rbbtnd.Location = new System.Drawing.Point(37, 350);
            this.rbbtnd.Name = "rbbtnd";
            this.rbbtnd.Size = new System.Drawing.Size(67, 17);
            this.rbbtnd.TabIndex = 4;
            this.rbbtnd.TabStop = true;
            this.rbbtnd.Text = "Option D";
            this.rbbtnd.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(499, 427);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(107, 34);
            this.btn.TabIndex = 5;
            this.btn.Text = "Next";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(37, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 10);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rbbtnd);
            this.Controls.Add(this.rbbtnc);
            this.Controls.Add(this.rbbtnb);
            this.Controls.Add(this.rbbtna);
            this.Controls.Add(this.lblquestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

