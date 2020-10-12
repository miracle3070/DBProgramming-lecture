namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxCalculate = new System.Windows.Forms.Button();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxOperand2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperand1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioOperatorMinus = new System.Windows.Forms.RadioButton();
            this.RadioOperatorPlus = new System.Windows.Forms.RadioButton();
            this.RadioResult = new System.Windows.Forms.TextBox();
            this.RadioCalculate = new System.Windows.Forms.Button();
            this.RadioOperand2 = new System.Windows.Forms.TextBox();
            this.RadioOperand1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxResult);
            this.groupBox1.Controls.Add(this.comboBoxCalculate);
            this.groupBox1.Controls.Add(this.comboBoxOperator);
            this.groupBox1.Controls.Add(this.comboBoxOperand2);
            this.groupBox1.Controls.Add(this.comboBoxOperand1);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox Based Calculator";
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.Location = new System.Drawing.Point(532, 65);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(100, 25);
            this.comboBoxResult.TabIndex = 4;
            // 
            // comboBoxCalculate
            // 
            this.comboBoxCalculate.Location = new System.Drawing.Point(402, 61);
            this.comboBoxCalculate.Name = "comboBoxCalculate";
            this.comboBoxCalculate.Size = new System.Drawing.Size(93, 31);
            this.comboBoxCalculate.TabIndex = 3;
            this.comboBoxCalculate.Text = "Calculate";
            this.comboBoxCalculate.UseVisualStyleBackColor = true;
            this.comboBoxCalculate.Click += new System.EventHandler(this.comboBoxCalculate_Click);
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(145, 66);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(104, 23);
            this.comboBoxOperator.TabIndex = 2;
            // 
            // comboBoxOperand2
            // 
            this.comboBoxOperand2.Location = new System.Drawing.Point(266, 65);
            this.comboBoxOperand2.Name = "comboBoxOperand2";
            this.comboBoxOperand2.Size = new System.Drawing.Size(100, 25);
            this.comboBoxOperand2.TabIndex = 0;
            // 
            // comboBoxOperand1
            // 
            this.comboBoxOperand1.Location = new System.Drawing.Point(29, 65);
            this.comboBoxOperand1.Name = "comboBoxOperand1";
            this.comboBoxOperand1.Size = new System.Drawing.Size(100, 25);
            this.comboBoxOperand1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "실감응용데이터베이스프로그래밍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "5671309 한상우";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioOperatorMinus);
            this.groupBox2.Controls.Add(this.RadioOperatorPlus);
            this.groupBox2.Controls.Add(this.RadioResult);
            this.groupBox2.Controls.Add(this.RadioCalculate);
            this.groupBox2.Controls.Add(this.RadioOperand2);
            this.groupBox2.Controls.Add(this.RadioOperand1);
            this.groupBox2.Location = new System.Drawing.Point(37, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RadioButton Based Calculator";
            // 
            // RadioOperatorMinus
            // 
            this.RadioOperatorMinus.AutoSize = true;
            this.RadioOperatorMinus.Location = new System.Drawing.Point(176, 91);
            this.RadioOperatorMinus.Name = "RadioOperatorMinus";
            this.RadioOperatorMinus.Size = new System.Drawing.Size(36, 19);
            this.RadioOperatorMinus.TabIndex = 5;
            this.RadioOperatorMinus.TabStop = true;
            this.RadioOperatorMinus.Text = "-";
            this.RadioOperatorMinus.UseVisualStyleBackColor = true;
            // 
            // RadioOperatorPlus
            // 
            this.RadioOperatorPlus.AutoSize = true;
            this.RadioOperatorPlus.Location = new System.Drawing.Point(176, 66);
            this.RadioOperatorPlus.Name = "RadioOperatorPlus";
            this.RadioOperatorPlus.Size = new System.Drawing.Size(36, 19);
            this.RadioOperatorPlus.TabIndex = 5;
            this.RadioOperatorPlus.TabStop = true;
            this.RadioOperatorPlus.Text = "+";
            this.RadioOperatorPlus.UseVisualStyleBackColor = true;
            // 
            // RadioResult
            // 
            this.RadioResult.Location = new System.Drawing.Point(532, 64);
            this.RadioResult.Name = "RadioResult";
            this.RadioResult.Size = new System.Drawing.Size(100, 25);
            this.RadioResult.TabIndex = 4;
            // 
            // RadioCalculate
            // 
            this.RadioCalculate.Location = new System.Drawing.Point(403, 60);
            this.RadioCalculate.Name = "RadioCalculate";
            this.RadioCalculate.Size = new System.Drawing.Size(93, 31);
            this.RadioCalculate.TabIndex = 3;
            this.RadioCalculate.Text = "Calculate";
            this.RadioCalculate.UseVisualStyleBackColor = true;
            this.RadioCalculate.Click += new System.EventHandler(this.RadioCalculate_Click);
            // 
            // RadioOperand2
            // 
            this.RadioOperand2.Location = new System.Drawing.Point(266, 65);
            this.RadioOperand2.Name = "RadioOperand2";
            this.RadioOperand2.Size = new System.Drawing.Size(100, 25);
            this.RadioOperand2.TabIndex = 0;
            // 
            // RadioOperand1
            // 
            this.RadioOperand1.Location = new System.Drawing.Point(29, 65);
            this.RadioOperand1.Name = "RadioOperand1";
            this.RadioOperand1.Size = new System.Drawing.Size(100, 25);
            this.RadioOperand1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox comboBoxResult;
        private System.Windows.Forms.Button comboBoxCalculate;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.TextBox comboBoxOperand2;
        private System.Windows.Forms.TextBox comboBoxOperand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RadioResult;
        private System.Windows.Forms.Button RadioCalculate;
        private System.Windows.Forms.TextBox RadioOperand2;
        private System.Windows.Forms.TextBox RadioOperand1;
        private System.Windows.Forms.RadioButton RadioOperatorMinus;
        private System.Windows.Forms.RadioButton RadioOperatorPlus;
    }
}

