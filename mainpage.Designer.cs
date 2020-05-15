namespace Confirm
{
    partial class Mainpage
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
            this.Main_Add_btn = new System.Windows.Forms.Button();
            this.Main_Reset_btn = new System.Windows.Forms.Button();
            this.Main_Next_btn = new System.Windows.Forms.Button();
            this.Main_Datagridview_big = new System.Windows.Forms.DataGridView();
            this.Main_datagridview_small = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Datagridview_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_datagridview_small)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Add_btn
            // 
            this.Main_Add_btn.Location = new System.Drawing.Point(76, 488);
            this.Main_Add_btn.Name = "Main_Add_btn";
            this.Main_Add_btn.Size = new System.Drawing.Size(102, 44);
            this.Main_Add_btn.TabIndex = 11;
            this.Main_Add_btn.Text = "Add";
            this.Main_Add_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Reset_btn
            // 
            this.Main_Reset_btn.Location = new System.Drawing.Point(693, 488);
            this.Main_Reset_btn.Name = "Main_Reset_btn";
            this.Main_Reset_btn.Size = new System.Drawing.Size(114, 44);
            this.Main_Reset_btn.TabIndex = 10;
            this.Main_Reset_btn.Text = "Reset";
            this.Main_Reset_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Next_btn
            // 
            this.Main_Next_btn.Location = new System.Drawing.Point(833, 488);
            this.Main_Next_btn.Name = "Main_Next_btn";
            this.Main_Next_btn.Size = new System.Drawing.Size(108, 44);
            this.Main_Next_btn.TabIndex = 9;
            this.Main_Next_btn.Text = "Next";
            this.Main_Next_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Datagridview_big
            // 
            this.Main_Datagridview_big.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_Datagridview_big.Location = new System.Drawing.Point(343, 85);
            this.Main_Datagridview_big.Name = "Main_Datagridview_big";
            this.Main_Datagridview_big.RowTemplate.Height = 24;
            this.Main_Datagridview_big.Size = new System.Drawing.Size(607, 387);
            this.Main_Datagridview_big.TabIndex = 8;
            // 
            // Main_datagridview_small
            // 
            this.Main_datagridview_small.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_datagridview_small.Location = new System.Drawing.Point(59, 85);
            this.Main_datagridview_small.Name = "Main_datagridview_small";
            this.Main_datagridview_small.RowTemplate.Height = 24;
            this.Main_datagridview_small.Size = new System.Drawing.Size(237, 387);
            this.Main_datagridview_small.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, -31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Main_Add_btn);
            this.Controls.Add(this.Main_Reset_btn);
            this.Controls.Add(this.Main_Next_btn);
            this.Controls.Add(this.Main_Datagridview_big);
            this.Controls.Add(this.Main_datagridview_small);
            this.Controls.Add(this.label1);
            this.Name = "Mainpage";
            this.Text = "Mainpage";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Datagridview_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_datagridview_small)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_Add_btn;
        private System.Windows.Forms.Button Main_Reset_btn;
        private System.Windows.Forms.Button Main_Next_btn;
        private System.Windows.Forms.DataGridView Main_Datagridview_big;
        private System.Windows.Forms.DataGridView Main_datagridview_small;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}