namespace _HW__커피샵_프로그램
{
    partial class FormShowUserLog
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
            this.dataGridViewUserLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "유저들의 로그인, 로그아웃 기록을 볼 수 있습니다.";
            // 
            // dataGridViewUserLog
            // 
            this.dataGridViewUserLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserLog.Location = new System.Drawing.Point(24, 81);
            this.dataGridViewUserLog.Name = "dataGridViewUserLog";
            this.dataGridViewUserLog.RowHeadersWidth = 51;
            this.dataGridViewUserLog.RowTemplate.Height = 27;
            this.dataGridViewUserLog.Size = new System.Drawing.Size(705, 293);
            this.dataGridViewUserLog.TabIndex = 1;
            // 
            // FormShowUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.Controls.Add(this.dataGridViewUserLog);
            this.Controls.Add(this.label1);
            this.Name = "FormShowUserLog";
            this.Text = "FormShowUserLog";
            this.Load += new System.EventHandler(this.FormShowUserLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUserLog;
    }
}