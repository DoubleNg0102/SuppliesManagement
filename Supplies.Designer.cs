namespace Confirm
{
    partial class Supplies
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
            this.Supplier_Datagridview = new System.Windows.Forms.DataGridView();
            this.Supplier_Next_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplies Goods";
            // 
            // Supplier_Datagridview
            // 
            this.Supplier_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Supplier_Datagridview.Location = new System.Drawing.Point(65, 65);
            this.Supplier_Datagridview.Name = "Supplier_Datagridview";
            this.Supplier_Datagridview.RowTemplate.Height = 24;
            this.Supplier_Datagridview.Size = new System.Drawing.Size(686, 266);
            this.Supplier_Datagridview.TabIndex = 1;
            // 
            // Supplier_Next_btn
            // 
            this.Supplier_Next_btn.Location = new System.Drawing.Point(642, 383);
            this.Supplier_Next_btn.Name = "Supplier_Next_btn";
            this.Supplier_Next_btn.Size = new System.Drawing.Size(109, 34);
            this.Supplier_Next_btn.TabIndex = 2;
            this.Supplier_Next_btn.Text = "Next";
            this.Supplier_Next_btn.UseVisualStyleBackColor = true;
            // 
            // Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Supplier_Next_btn);
            this.Controls.Add(this.Supplier_Datagridview);
            this.Controls.Add(this.label1);
            this.Name = "Supplies";
            this.Text = "Supplies";
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Supplier_Datagridview;
        private System.Windows.Forms.Button Supplier_Next_btn;
    }
}

