namespace Confirm
{
    partial class Bill
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
            this.Bill_Finish_btn = new System.Windows.Forms.Button();
            this.Bill_Datagridview_big = new System.Windows.Forms.DataGridView();
            this.Bill_Datagridview_Small = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Datagridview_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Datagridview_Small)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill_Finish_btn
            // 
            this.Bill_Finish_btn.Location = new System.Drawing.Point(430, 621);
            this.Bill_Finish_btn.Name = "Bill_Finish_btn";
            this.Bill_Finish_btn.Size = new System.Drawing.Size(108, 34);
            this.Bill_Finish_btn.TabIndex = 7;
            this.Bill_Finish_btn.Text = "Finish";
            this.Bill_Finish_btn.UseVisualStyleBackColor = true;
            // 
            // Bill_Datagridview_big
            // 
            this.Bill_Datagridview_big.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_Datagridview_big.Location = new System.Drawing.Point(77, 313);
            this.Bill_Datagridview_big.Name = "Bill_Datagridview_big";
            this.Bill_Datagridview_big.RowTemplate.Height = 24;
            this.Bill_Datagridview_big.Size = new System.Drawing.Size(439, 287);
            this.Bill_Datagridview_big.TabIndex = 6;
            // 
            // Bill_Datagridview_Small
            // 
            this.Bill_Datagridview_Small.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_Datagridview_Small.Location = new System.Drawing.Point(77, 103);
            this.Bill_Datagridview_Small.Name = "Bill_Datagridview_Small";
            this.Bill_Datagridview_Small.RowTemplate.Height = 24;
            this.Bill_Datagridview_Small.Size = new System.Drawing.Size(439, 182);
            this.Bill_Datagridview_Small.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bill";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 704);
            this.Controls.Add(this.Bill_Finish_btn);
            this.Controls.Add(this.Bill_Datagridview_big);
            this.Controls.Add(this.Bill_Datagridview_Small);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Datagridview_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Datagridview_Small)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bill_Finish_btn;
        private System.Windows.Forms.DataGridView Bill_Datagridview_big;
        private System.Windows.Forms.DataGridView Bill_Datagridview_Small;
        private System.Windows.Forms.Label label1;
    }
}