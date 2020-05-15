namespace Confirm
{
    partial class Confirminformation
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
            this.Information_Print_btn = new System.Windows.Forms.Button();
            this.Information_datagridview = new System.Windows.Forms.DataGridView();
            this.Information_Address_txt = new System.Windows.Forms.TextBox();
            this.Information_Phone_txt = new System.Windows.Forms.TextBox();
            this.Information_Name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Information_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Information_Print_btn
            // 
            this.Information_Print_btn.Location = new System.Drawing.Point(700, 473);
            this.Information_Print_btn.Name = "Information_Print_btn";
            this.Information_Print_btn.Size = new System.Drawing.Size(103, 31);
            this.Information_Print_btn.TabIndex = 17;
            this.Information_Print_btn.Text = "Print ";
            this.Information_Print_btn.UseVisualStyleBackColor = true;
            // 
            // Information_datagridview
            // 
            this.Information_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information_datagridview.Location = new System.Drawing.Point(102, 276);
            this.Information_datagridview.Name = "Information_datagridview";
            this.Information_datagridview.RowTemplate.Height = 24;
            this.Information_datagridview.Size = new System.Drawing.Size(702, 174);
            this.Information_datagridview.TabIndex = 16;
            // 
            // Information_Address_txt
            // 
            this.Information_Address_txt.Location = new System.Drawing.Point(283, 225);
            this.Information_Address_txt.Name = "Information_Address_txt";
            this.Information_Address_txt.Size = new System.Drawing.Size(383, 22);
            this.Information_Address_txt.TabIndex = 15;
            // 
            // Information_Phone_txt
            // 
            this.Information_Phone_txt.Location = new System.Drawing.Point(283, 192);
            this.Information_Phone_txt.Name = "Information_Phone_txt";
            this.Information_Phone_txt.Size = new System.Drawing.Size(383, 22);
            this.Information_Phone_txt.TabIndex = 14;
            // 
            // Information_Name_txt
            // 
            this.Information_Name_txt.Location = new System.Drawing.Point(283, 153);
            this.Information_Name_txt.Name = "Information_Name_txt";
            this.Information_Name_txt.Size = new System.Drawing.Size(383, 22);
            this.Information_Name_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirm Information";
            // 
            // Confirminformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 537);
            this.Controls.Add(this.Information_Print_btn);
            this.Controls.Add(this.Information_datagridview);
            this.Controls.Add(this.Information_Address_txt);
            this.Controls.Add(this.Information_Phone_txt);
            this.Controls.Add(this.Information_Name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Confirminformation";
            this.Text = "Confirminformation";
            ((System.ComponentModel.ISupportInitialize)(this.Information_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Information_Print_btn;
        private System.Windows.Forms.DataGridView Information_datagridview;
        private System.Windows.Forms.TextBox Information_Address_txt;
        private System.Windows.Forms.TextBox Information_Phone_txt;
        private System.Windows.Forms.TextBox Information_Name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}