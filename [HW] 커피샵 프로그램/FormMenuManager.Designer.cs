namespace _HW__커피샵_프로그램
{
    partial class FormMenuManager
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.buttonShowMenuAddForm = new System.Windows.Forms.Button();
            this.buttonShowMenuModifyForm = new System.Windows.Forms.Button();
            this.buttonLoadMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "판매할 메뉴를 관리하는 창입니다.";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(35, 60);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 27;
            this.dataGridViewMenu.Size = new System.Drawing.Size(726, 270);
            this.dataGridViewMenu.TabIndex = 1;
            // 
            // buttonShowMenuAddForm
            // 
            this.buttonShowMenuAddForm.Location = new System.Drawing.Point(188, 361);
            this.buttonShowMenuAddForm.Name = "buttonShowMenuAddForm";
            this.buttonShowMenuAddForm.Size = new System.Drawing.Size(194, 53);
            this.buttonShowMenuAddForm.TabIndex = 2;
            this.buttonShowMenuAddForm.Text = "신규 메뉴 추가";
            this.buttonShowMenuAddForm.UseVisualStyleBackColor = true;
            this.buttonShowMenuAddForm.Click += new System.EventHandler(this.buttonShowMenuAddForm_Click);
            // 
            // buttonShowMenuModifyForm
            // 
            this.buttonShowMenuModifyForm.Location = new System.Drawing.Point(418, 361);
            this.buttonShowMenuModifyForm.Name = "buttonShowMenuModifyForm";
            this.buttonShowMenuModifyForm.Size = new System.Drawing.Size(194, 53);
            this.buttonShowMenuModifyForm.TabIndex = 3;
            this.buttonShowMenuModifyForm.Text = "메뉴 수정";
            this.buttonShowMenuModifyForm.UseVisualStyleBackColor = true;
            this.buttonShowMenuModifyForm.Click += new System.EventHandler(this.buttonShowMenuModifyForm_Click);
            // 
            // buttonLoadMenu
            // 
            this.buttonLoadMenu.Location = new System.Drawing.Point(649, 20);
            this.buttonLoadMenu.Name = "buttonLoadMenu";
            this.buttonLoadMenu.Size = new System.Drawing.Size(112, 32);
            this.buttonLoadMenu.TabIndex = 4;
            this.buttonLoadMenu.Text = "새로고침";
            this.buttonLoadMenu.UseVisualStyleBackColor = true;
            this.buttonLoadMenu.Click += new System.EventHandler(this.buttonLoadMenu_Click);
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadMenu);
            this.Controls.Add(this.buttonShowMenuModifyForm);
            this.Controls.Add(this.buttonShowMenuAddForm);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuManager";
            this.Text = "FormMenuManager";
            this.Load += new System.EventHandler(this.FormMenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowMenuAddForm;
        private System.Windows.Forms.Button buttonShowMenuModifyForm;
        private System.Windows.Forms.Button buttonLoadMenu;
        public System.Windows.Forms.DataGridView dataGridViewMenu;
    }
}