namespace GST_Calculator
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
            this.txt_exGST = new System.Windows.Forms.TextBox();
            this.lbl_exGST = new System.Windows.Forms.Label();
            this.txt_incGST = new System.Windows.Forms.TextBox();
            this.lbl_incGST = new System.Windows.Forms.Label();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_exGST
            // 
            this.txt_exGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exGST.Location = new System.Drawing.Point(98, 10);
            this.txt_exGST.Name = "txt_exGST";
            this.txt_exGST.Size = new System.Drawing.Size(115, 32);
            this.txt_exGST.TabIndex = 0;
            this.txt_exGST.Leave += new System.EventHandler(this.txt_exGST_TextChanged);
            // 
            // lbl_exGST
            // 
            this.lbl_exGST.AutoSize = true;
            this.lbl_exGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exGST.Location = new System.Drawing.Point(29, 17);
            this.lbl_exGST.Name = "lbl_exGST";
            this.lbl_exGST.Size = new System.Drawing.Size(63, 20);
            this.lbl_exGST.TabIndex = 1;
            this.lbl_exGST.Text = "exGST";
            this.lbl_exGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_incGST
            // 
            this.txt_incGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_incGST.Location = new System.Drawing.Point(98, 48);
            this.txt_incGST.Name = "txt_incGST";
            this.txt_incGST.Size = new System.Drawing.Size(115, 32);
            this.txt_incGST.TabIndex = 2;
            this.txt_incGST.Leave += new System.EventHandler(this.txt_incGST_TextChanged);
            // 
            // lbl_incGST
            // 
            this.lbl_incGST.AutoSize = true;
            this.lbl_incGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incGST.Location = new System.Drawing.Point(24, 55);
            this.lbl_incGST.Name = "lbl_incGST";
            this.lbl_incGST.Size = new System.Drawing.Size(68, 20);
            this.lbl_incGST.TabIndex = 3;
            this.lbl_incGST.Text = "incGST";
            // 
            // txt_GST
            // 
            this.txt_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GST.Location = new System.Drawing.Point(98, 86);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.ReadOnly = true;
            this.txt_GST.Size = new System.Drawing.Size(115, 32);
            this.txt_GST.TabIndex = 4;
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(47, 93);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(45, 20);
            this.lbl_GST.TabIndex = 5;
            this.lbl_GST.Text = "GST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 132);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.txt_GST);
            this.Controls.Add(this.lbl_incGST);
            this.Controls.Add(this.txt_incGST);
            this.Controls.Add(this.lbl_exGST);
            this.Controls.Add(this.txt_exGST);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 170);
            this.MinimumSize = new System.Drawing.Size(260, 170);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GST Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_exGST;
        private System.Windows.Forms.Label lbl_exGST;
        private System.Windows.Forms.TextBox txt_incGST;
        private System.Windows.Forms.Label lbl_incGST;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.Label lbl_GST;
    }
}

