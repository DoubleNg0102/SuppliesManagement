namespace Confirm
{
    partial class Customer
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
            this.Customer_Address_txt = new System.Windows.Forms.TextBox();
            this.Customer_Phone_txt = new System.Windows.Forms.TextBox();
            this.Customer_Name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Back_Btn = new System.Windows.Forms.Button();
            this.Customer_Next_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_Address_txt
            // 
            this.Customer_Address_txt.Location = new System.Drawing.Point(250, 273);
            this.Customer_Address_txt.Name = "Customer_Address_txt";
            this.Customer_Address_txt.Size = new System.Drawing.Size(355, 22);
            this.Customer_Address_txt.TabIndex = 17;
            // 
            // Customer_Phone_txt
            // 
            this.Customer_Phone_txt.Location = new System.Drawing.Point(250, 203);
            this.Customer_Phone_txt.Name = "Customer_Phone_txt";
            this.Customer_Phone_txt.Size = new System.Drawing.Size(355, 22);
            this.Customer_Phone_txt.TabIndex = 16;
            // 
            // Customer_Name_txt
            // 
            this.Customer_Name_txt.Location = new System.Drawing.Point(250, 116);
            this.Customer_Name_txt.Name = "Customer_Name_txt";
            this.Customer_Name_txt.Size = new System.Drawing.Size(355, 22);
            this.Customer_Name_txt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Information";
            // 
            // Customer_Back_Btn
            // 
            this.Customer_Back_Btn.Location = new System.Drawing.Point(485, 415);
            this.Customer_Back_Btn.Name = "Customer_Back_Btn";
            this.Customer_Back_Btn.Size = new System.Drawing.Size(107, 44);
            this.Customer_Back_Btn.TabIndex = 10;
            this.Customer_Back_Btn.Text = "Back";
            this.Customer_Back_Btn.UseVisualStyleBackColor = true;
            // 
            // Customer_Next_btn
            // 
            this.Customer_Next_btn.Location = new System.Drawing.Point(628, 415);
            this.Customer_Next_btn.Name = "Customer_Next_btn";
            this.Customer_Next_btn.Size = new System.Drawing.Size(108, 44);
            this.Customer_Next_btn.TabIndex = 9;
            this.Customer_Next_btn.Text = "Next";
            this.Customer_Next_btn.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 518);
            this.Controls.Add(this.Customer_Address_txt);
            this.Controls.Add(this.Customer_Phone_txt);
            this.Controls.Add(this.Customer_Name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_Back_Btn);
            this.Controls.Add(this.Customer_Next_btn);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Customer_Address_txt;
        private System.Windows.Forms.TextBox Customer_Phone_txt;
        private System.Windows.Forms.TextBox Customer_Name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Customer_Back_Btn;
        private System.Windows.Forms.Button Customer_Next_btn;
    }
}