namespace Confirm
{
    partial class Checklist
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
            this.Checklist_Back_btn = new System.Windows.Forms.Button();
            this.Checklist_Next_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Checklist_datagridview = new System.Windows.Forms.DataGridView();
            this.Checklist_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Checklist_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Checklist_Back_btn
            // 
            this.Checklist_Back_btn.Location = new System.Drawing.Point(532, 396);
            this.Checklist_Back_btn.Name = "Checklist_Back_btn";
            this.Checklist_Back_btn.Size = new System.Drawing.Size(112, 47);
            this.Checklist_Back_btn.TabIndex = 11;
            this.Checklist_Back_btn.Text = "Back";
            this.Checklist_Back_btn.UseVisualStyleBackColor = true;
            // 
            // Checklist_Next_btn
            // 
            this.Checklist_Next_btn.Location = new System.Drawing.Point(674, 396);
            this.Checklist_Next_btn.Name = "Checklist_Next_btn";
            this.Checklist_Next_btn.Size = new System.Drawing.Size(111, 47);
            this.Checklist_Next_btn.TabIndex = 10;
            this.Checklist_Next_btn.Text = "Next";
            this.Checklist_Next_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment method:";
            // 
            // Checklist_datagridview
            // 
            this.Checklist_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Checklist_datagridview.Location = new System.Drawing.Point(43, 70);
            this.Checklist_datagridview.Name = "Checklist_datagridview";
            this.Checklist_datagridview.RowTemplate.Height = 24;
            this.Checklist_datagridview.Size = new System.Drawing.Size(742, 261);
            this.Checklist_datagridview.TabIndex = 8;
            // 
            // Checklist_comboBox
            // 
            this.Checklist_comboBox.FormattingEnabled = true;
            this.Checklist_comboBox.Location = new System.Drawing.Point(167, 363);
            this.Checklist_comboBox.Name = "Checklist_comboBox";
            this.Checklist_comboBox.Size = new System.Drawing.Size(119, 24);
            this.Checklist_comboBox.TabIndex = 7;
            this.Checklist_comboBox.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Check List";
            // 
            // Checklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.Controls.Add(this.Checklist_Back_btn);
            this.Controls.Add(this.Checklist_Next_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Checklist_datagridview);
            this.Controls.Add(this.Checklist_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Checklist";
            this.Text = "Checklist";
            ((System.ComponentModel.ISupportInitialize)(this.Checklist_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Checklist_Back_btn;
        private System.Windows.Forms.Button Checklist_Next_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Checklist_datagridview;
        private System.Windows.Forms.ComboBox Checklist_comboBox;
        private System.Windows.Forms.Label label1;
    }
}