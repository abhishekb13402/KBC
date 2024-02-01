namespace KBC
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.questionattendno = new System.Windows.Forms.TextBox();
            this.guestuserbtnsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guestusername = new System.Windows.Forms.TextBox();
            this.guestuserpassword = new System.Windows.Forms.TextBox();
            this.lblguest = new System.Windows.Forms.Label();
            this.lbltotalquestion = new System.Windows.Forms.Label();
            this.lbldislplaytotalquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question are you want to attend?";
            // 
            // questionattendno
            // 
            this.questionattendno.Location = new System.Drawing.Point(380, 253);
            this.questionattendno.Margin = new System.Windows.Forms.Padding(2);
            this.questionattendno.Name = "questionattendno";
            this.questionattendno.Size = new System.Drawing.Size(76, 20);
            this.questionattendno.TabIndex = 1;
            this.questionattendno.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // guestuserbtnsubmit
            // 
            this.guestuserbtnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestuserbtnsubmit.Location = new System.Drawing.Point(165, 374);
            this.guestuserbtnsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.guestuserbtnsubmit.Name = "guestuserbtnsubmit";
            this.guestuserbtnsubmit.Size = new System.Drawing.Size(73, 29);
            this.guestuserbtnsubmit.TabIndex = 2;
            this.guestuserbtnsubmit.Text = "Submit";
            this.guestuserbtnsubmit.UseVisualStyleBackColor = true;
            this.guestuserbtnsubmit.Click += new System.EventHandler(this.guestuserbtnsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Password";
            // 
            // guestusername
            // 
            this.guestusername.Location = new System.Drawing.Point(209, 119);
            this.guestusername.Margin = new System.Windows.Forms.Padding(2);
            this.guestusername.Name = "guestusername";
            this.guestusername.Size = new System.Drawing.Size(247, 20);
            this.guestusername.TabIndex = 6;
            // 
            // guestuserpassword
            // 
            this.guestuserpassword.Location = new System.Drawing.Point(209, 186);
            this.guestuserpassword.Margin = new System.Windows.Forms.Padding(2);
            this.guestuserpassword.Name = "guestuserpassword";
            this.guestuserpassword.PasswordChar = '*';
            this.guestuserpassword.Size = new System.Drawing.Size(247, 20);
            this.guestuserpassword.TabIndex = 7;
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguest.Location = new System.Drawing.Point(206, 42);
            this.lblguest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(57, 16);
            this.lblguest.TabIndex = 8;
            this.lblguest.Text = "Login";
            // 
            // lbltotalquestion
            // 
            this.lbltotalquestion.AutoSize = true;
            this.lbltotalquestion.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalquestion.Location = new System.Drawing.Point(48, 313);
            this.lbltotalquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalquestion.Name = "lbltotalquestion";
            this.lbltotalquestion.Size = new System.Drawing.Size(265, 16);
            this.lbltotalquestion.TabIndex = 17;
            this.lbltotalquestion.Text = "Total Questions in DataBase :";
            // 
            // lbldislplaytotalquestion
            // 
            this.lbldislplaytotalquestion.AutoSize = true;
            this.lbldislplaytotalquestion.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldislplaytotalquestion.Location = new System.Drawing.Point(342, 313);
            this.lbldislplaytotalquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldislplaytotalquestion.Name = "lbldislplaytotalquestion";
            this.lbldislplaytotalquestion.Size = new System.Drawing.Size(43, 16);
            this.lbldislplaytotalquestion.TabIndex = 18;
            this.lbldislplaytotalquestion.Text = "QNO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 463);
            this.Controls.Add(this.lbldislplaytotalquestion);
            this.Controls.Add(this.lbltotalquestion);
            this.Controls.Add(this.lblguest);
            this.Controls.Add(this.guestuserpassword);
            this.Controls.Add(this.guestusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guestuserbtnsubmit);
            this.Controls.Add(this.questionattendno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionattendno;
        private System.Windows.Forms.Button guestuserbtnsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guestusername;
        private System.Windows.Forms.TextBox guestuserpassword;
        private System.Windows.Forms.Label lblguest;
        private System.Windows.Forms.Label lbltotalquestion;
        private System.Windows.Forms.Label lbldislplaytotalquestion;
    }
}