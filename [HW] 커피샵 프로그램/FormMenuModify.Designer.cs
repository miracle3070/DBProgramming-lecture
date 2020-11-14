namespace _HW__커피샵_프로그램
{
    partial class FormMenuModify
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoffeeID = new System.Windows.Forms.TextBox();
            this.textBoxCoffeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCoffeePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMenuModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "메뉴를 수정합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "순번";
            // 
            // textBoxCoffeeID
            // 
            this.textBoxCoffeeID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCoffeeID.Location = new System.Drawing.Point(233, 65);
            this.textBoxCoffeeID.Name = "textBoxCoffeeID";
            this.textBoxCoffeeID.ReadOnly = true;
            this.textBoxCoffeeID.Size = new System.Drawing.Size(155, 25);
            this.textBoxCoffeeID.TabIndex = 2;
            // 
            // textBoxCoffeeName
            // 
            this.textBoxCoffeeName.Location = new System.Drawing.Point(233, 103);
            this.textBoxCoffeeName.Name = "textBoxCoffeeName";
            this.textBoxCoffeeName.Size = new System.Drawing.Size(155, 25);
            this.textBoxCoffeeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "이름";
            // 
            // textBoxCoffeePrice
            // 
            this.textBoxCoffeePrice.Location = new System.Drawing.Point(233, 143);
            this.textBoxCoffeePrice.Name = "textBoxCoffeePrice";
            this.textBoxCoffeePrice.Size = new System.Drawing.Size(155, 25);
            this.textBoxCoffeePrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "가격";
            // 
            // buttonMenuModify
            // 
            this.buttonMenuModify.Location = new System.Drawing.Point(207, 192);
            this.buttonMenuModify.Name = "buttonMenuModify";
            this.buttonMenuModify.Size = new System.Drawing.Size(193, 67);
            this.buttonMenuModify.TabIndex = 7;
            this.buttonMenuModify.Text = "수정하기";
            this.buttonMenuModify.UseVisualStyleBackColor = true;
            this.buttonMenuModify.Click += new System.EventHandler(this.buttonMenuModify_Click);
            // 
            // FormMenuModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.Controls.Add(this.buttonMenuModify);
            this.Controls.Add(this.textBoxCoffeePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCoffeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCoffeeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuModify";
            this.Text = "FormMenuModify";
            this.Load += new System.EventHandler(this.FormMenuModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoffeeID;
        private System.Windows.Forms.TextBox textBoxCoffeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCoffeePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMenuModify;
    }
}