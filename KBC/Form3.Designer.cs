namespace KBC
{
    partial class Form3
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
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btndisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbq_id = new System.Windows.Forms.TextBox();
            this.tbq_name = new System.Windows.Forms.TextBox();
            this.tbq_optd = new System.Windows.Forms.TextBox();
            this.tbq_optc = new System.Windows.Forms.TextBox();
            this.tbq_optb = new System.Windows.Forms.TextBox();
            this.tbq_opta = new System.Windows.Forms.TextBox();
            this.tbq_Correctopt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(1015, 75);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(71, 32);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(1015, 128);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(71, 32);
            this.Update.TabIndex = 2;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1015, 177);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(71, 30);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(25, 233);
            this.dgview.Margin = new System.Windows.Forms.Padding(2);
            this.dgview.Name = "dgview";
            this.dgview.RowHeadersWidth = 51;
            this.dgview.RowTemplate.Height = 24;
            this.dgview.Size = new System.Drawing.Size(1118, 283);
            this.dgview.TabIndex = 4;
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(1015, 32);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(82, 28);
            this.btndisplay.TabIndex = 5;
            this.btndisplay.Text = "display";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.Display);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "q_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "q_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "q_optA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "q_optB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "q_optC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "q_optd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "q_Correctopt";
            // 
            // tbq_id
            // 
            this.tbq_id.Location = new System.Drawing.Point(180, 40);
            this.tbq_id.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_id.Name = "tbq_id";
            this.tbq_id.ReadOnly = true;
            this.tbq_id.Size = new System.Drawing.Size(218, 20);
            this.tbq_id.TabIndex = 13;
            // 
            // tbq_name
            // 
            this.tbq_name.Location = new System.Drawing.Point(180, 78);
            this.tbq_name.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_name.Multiline = true;
            this.tbq_name.Name = "tbq_name";
            this.tbq_name.Size = new System.Drawing.Size(218, 83);
            this.tbq_name.TabIndex = 14;
            // 
            // tbq_optd
            // 
            this.tbq_optd.Location = new System.Drawing.Point(611, 177);
            this.tbq_optd.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_optd.Name = "tbq_optd";
            this.tbq_optd.Size = new System.Drawing.Size(228, 20);
            this.tbq_optd.TabIndex = 15;
            // 
            // tbq_optc
            // 
            this.tbq_optc.Location = new System.Drawing.Point(611, 128);
            this.tbq_optc.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_optc.Name = "tbq_optc";
            this.tbq_optc.Size = new System.Drawing.Size(228, 20);
            this.tbq_optc.TabIndex = 16;
            // 
            // tbq_optb
            // 
            this.tbq_optb.Location = new System.Drawing.Point(611, 77);
            this.tbq_optb.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_optb.Name = "tbq_optb";
            this.tbq_optb.Size = new System.Drawing.Size(228, 20);
            this.tbq_optb.TabIndex = 17;
            // 
            // tbq_opta
            // 
            this.tbq_opta.Location = new System.Drawing.Point(611, 32);
            this.tbq_opta.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_opta.Name = "tbq_opta";
            this.tbq_opta.Size = new System.Drawing.Size(228, 20);
            this.tbq_opta.TabIndex = 18;
            // 
            // tbq_Correctopt
            // 
            this.tbq_Correctopt.Location = new System.Drawing.Point(180, 177);
            this.tbq_Correctopt.Margin = new System.Windows.Forms.Padding(2);
            this.tbq_Correctopt.Name = "tbq_Correctopt";
            this.tbq_Correctopt.Size = new System.Drawing.Size(218, 20);
            this.tbq_Correctopt.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 538);
            this.Controls.Add(this.tbq_Correctopt);
            this.Controls.Add(this.tbq_opta);
            this.Controls.Add(this.tbq_optb);
            this.Controls.Add(this.tbq_optc);
            this.Controls.Add(this.tbq_optd);
            this.Controls.Add(this.tbq_name);
            this.Controls.Add(this.tbq_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "Form3";
            this.Text = "form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbq_id;
        private System.Windows.Forms.TextBox tbq_name;
        private System.Windows.Forms.TextBox tbq_optd;
        private System.Windows.Forms.TextBox tbq_optc;
        private System.Windows.Forms.TextBox tbq_optb;
        private System.Windows.Forms.TextBox tbq_opta;
        private System.Windows.Forms.TextBox tbq_Correctopt;
    }
}