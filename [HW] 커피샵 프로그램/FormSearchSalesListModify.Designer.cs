namespace _HW__커피샵_프로그램
{
    partial class FormSearchSalesListModify
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCoffeeKind = new System.Windows.Forms.ComboBox();
            this.textBoxCoffeeCount = new System.Windows.Forms.TextBox();
            this.textBoxCoffeeID = new System.Windows.Forms.TextBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.textBoxSalesID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCoffeeKind);
            this.groupBox1.Controls.Add(this.textBoxCoffeeCount);
            this.groupBox1.Controls.Add(this.textBoxCoffeeID);
            this.groupBox1.Controls.Add(this.textBoxOrderNumber);
            this.groupBox1.Controls.Add(this.textBoxSeller);
            this.groupBox1.Controls.Add(this.textBoxSalesID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 233);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수정할 내용";
            // 
            // comboBoxCoffeeKind
            // 
            this.comboBoxCoffeeKind.FormattingEnabled = true;
            this.comboBoxCoffeeKind.Location = new System.Drawing.Point(181, 152);
            this.comboBoxCoffeeKind.Name = "comboBoxCoffeeKind";
            this.comboBoxCoffeeKind.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCoffeeKind.TabIndex = 24;
            this.comboBoxCoffeeKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoffeeKind_SelectedIndexChanged);
            // 
            // textBoxCoffeeCount
            // 
            this.textBoxCoffeeCount.Location = new System.Drawing.Point(180, 182);
            this.textBoxCoffeeCount.Name = "textBoxCoffeeCount";
            this.textBoxCoffeeCount.Size = new System.Drawing.Size(122, 25);
            this.textBoxCoffeeCount.TabIndex = 23;
            // 
            // textBoxCoffeeID
            // 
            this.textBoxCoffeeID.Location = new System.Drawing.Point(180, 120);
            this.textBoxCoffeeID.Name = "textBoxCoffeeID";
            this.textBoxCoffeeID.ReadOnly = true;
            this.textBoxCoffeeID.Size = new System.Drawing.Size(122, 25);
            this.textBoxCoffeeID.TabIndex = 21;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(180, 89);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(122, 25);
            this.textBoxOrderNumber.TabIndex = 20;
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Location = new System.Drawing.Point(180, 58);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.ReadOnly = true;
            this.textBoxSeller.Size = new System.Drawing.Size(122, 25);
            this.textBoxSeller.TabIndex = 19;
            // 
            // textBoxSalesID
            // 
            this.textBoxSalesID.Location = new System.Drawing.Point(180, 27);
            this.textBoxSalesID.Name = "textBoxSalesID";
            this.textBoxSalesID.ReadOnly = true;
            this.textBoxSalesID.Size = new System.Drawing.Size(122, 25);
            this.textBoxSalesID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "개수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "커피 종류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "커피 ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "주문번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "판매직원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "순번";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(167, 269);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(180, 45);
            this.buttonModify.TabIndex = 13;
            this.buttonModify.Text = "수정하기";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // FormSearchSalesListModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 340);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearchSalesListModify";
            this.Text = "FormSearchSalesListModify";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCoffeeKind;
        private System.Windows.Forms.TextBox textBoxCoffeeCount;
        private System.Windows.Forms.TextBox textBoxCoffeeID;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.TextBox textBoxSalesID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModify;
    }
}