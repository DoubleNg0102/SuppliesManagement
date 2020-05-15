namespace Supplies
{
    partial class Confirm
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
            this.Confirm_Datagridview = new System.Windows.Forms.DataGridView();
            this.Confirm_Finish_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Goods";
            // 
            // Confirm_Datagridview
            // 
            this.Confirm_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Confirm_Datagridview.Location = new System.Drawing.Point(53, 59);
            this.Confirm_Datagridview.Name = "Confirm_Datagridview";
            this.Confirm_Datagridview.RowTemplate.Height = 24;
            this.Confirm_Datagridview.Size = new System.Drawing.Size(307, 347);
            this.Confirm_Datagridview.TabIndex = 1;
            // 
            // Confirm_Finish_btn
            // 
            this.Confirm_Finish_btn.Location = new System.Drawing.Point(247, 440);
            this.Confirm_Finish_btn.Name = "Confirm_Finish_btn";
            this.Confirm_Finish_btn.Size = new System.Drawing.Size(113, 36);
            this.Confirm_Finish_btn.TabIndex = 2;
            this.Confirm_Finish_btn.Text = "Finish";
            this.Confirm_Finish_btn.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 506);
            this.Controls.Add(this.Confirm_Finish_btn);
            this.Controls.Add(this.Confirm_Datagridview);
            this.Controls.Add(this.label1);
            this.Name = "Confirm";
            this.Text = "Confirm";
            ((System.ComponentModel.ISupportInitialize)(this.Confirm_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Confirm_Datagridview;
        private System.Windows.Forms.Button Confirm_Finish_btn;
    }
}

