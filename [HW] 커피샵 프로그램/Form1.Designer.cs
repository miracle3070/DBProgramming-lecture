namespace _HW__커피샵_프로그램
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSellCafeMocha = new System.Windows.Forms.Button();
            this.btnSellLatte = new System.Windows.Forms.Button();
            this.btnSellAmericano = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowMonthlyCoffeeSalesLIst = new System.Windows.Forms.Button();
            this.btnShowDailyCoffeeSalesList = new System.Windows.Forms.Button();
            this.btnShowDailyUserSalesList = new System.Windows.Forms.Button();
            this.dataGridViewAdminScreen = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(48, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(112, 25);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(219, 23);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(112, 25);
            this.textBoxPW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(346, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Location = new System.Drawing.Point(631, 27);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(172, 15);
            this.labelLoginUser.TabIndex = 5;
            this.labelLoginUser.Text = "먼저 로그인을 해주세요.";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(840, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 25);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSellCafeMocha);
            this.groupBox1.Controls.Add(this.btnSellLatte);
            this.groupBox1.Controls.Add(this.btnSellAmericano);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(48, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // btnSellCafeMocha
            // 
            this.btnSellCafeMocha.Location = new System.Drawing.Point(602, 73);
            this.btnSellCafeMocha.Name = "btnSellCafeMocha";
            this.btnSellCafeMocha.Size = new System.Drawing.Size(235, 81);
            this.btnSellCafeMocha.TabIndex = 3;
            this.btnSellCafeMocha.Text = "카페모카\r\n\r\n2000원";
            this.btnSellCafeMocha.UseVisualStyleBackColor = true;
            this.btnSellCafeMocha.Click += new System.EventHandler(this.btnSellCafeMocha_Click);
            // 
            // btnSellLatte
            // 
            this.btnSellLatte.Location = new System.Drawing.Point(321, 73);
            this.btnSellLatte.Name = "btnSellLatte";
            this.btnSellLatte.Size = new System.Drawing.Size(235, 81);
            this.btnSellLatte.TabIndex = 2;
            this.btnSellLatte.Text = "라떼\r\n\r\n1500원";
            this.btnSellLatte.UseVisualStyleBackColor = true;
            this.btnSellLatte.Click += new System.EventHandler(this.btnSellLatte_Click);
            // 
            // btnSellAmericano
            // 
            this.btnSellAmericano.Location = new System.Drawing.Point(42, 73);
            this.btnSellAmericano.Name = "btnSellAmericano";
            this.btnSellAmericano.Size = new System.Drawing.Size(235, 81);
            this.btnSellAmericano.TabIndex = 1;
            this.btnSellAmericano.Text = "아메리카노\r\n\r\n1000원";
            this.btnSellAmericano.UseVisualStyleBackColor = true;
            this.btnSellAmericano.Click += new System.EventHandler(this.btnSellAmericano_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowMonthlyCoffeeSalesLIst);
            this.groupBox2.Controls.Add(this.btnShowDailyCoffeeSalesList);
            this.groupBox2.Controls.Add(this.btnShowDailyUserSalesList);
            this.groupBox2.Controls.Add(this.dataGridViewAdminScreen);
            this.groupBox2.Location = new System.Drawing.Point(48, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 316);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // btnShowMonthlyCoffeeSalesLIst
            // 
            this.btnShowMonthlyCoffeeSalesLIst.Location = new System.Drawing.Point(602, 247);
            this.btnShowMonthlyCoffeeSalesLIst.Name = "btnShowMonthlyCoffeeSalesLIst";
            this.btnShowMonthlyCoffeeSalesLIst.Size = new System.Drawing.Size(235, 50);
            this.btnShowMonthlyCoffeeSalesLIst.TabIndex = 11;
            this.btnShowMonthlyCoffeeSalesLIst.Text = "커피 종류별 월별 판매 현황";
            this.btnShowMonthlyCoffeeSalesLIst.UseVisualStyleBackColor = true;
            this.btnShowMonthlyCoffeeSalesLIst.Click += new System.EventHandler(this.btnShowMonthlyCoffeeSalesLIst_Click);
            // 
            // btnShowDailyCoffeeSalesList
            // 
            this.btnShowDailyCoffeeSalesList.Location = new System.Drawing.Point(321, 247);
            this.btnShowDailyCoffeeSalesList.Name = "btnShowDailyCoffeeSalesList";
            this.btnShowDailyCoffeeSalesList.Size = new System.Drawing.Size(235, 50);
            this.btnShowDailyCoffeeSalesList.TabIndex = 10;
            this.btnShowDailyCoffeeSalesList.Text = "커피 종류별 일일 판매 현황";
            this.btnShowDailyCoffeeSalesList.UseVisualStyleBackColor = true;
            this.btnShowDailyCoffeeSalesList.Click += new System.EventHandler(this.btnShowDailyCoffeeSalesList_Click);
            // 
            // btnShowDailyUserSalesList
            // 
            this.btnShowDailyUserSalesList.Location = new System.Drawing.Point(42, 247);
            this.btnShowDailyUserSalesList.Name = "btnShowDailyUserSalesList";
            this.btnShowDailyUserSalesList.Size = new System.Drawing.Size(235, 50);
            this.btnShowDailyUserSalesList.TabIndex = 9;
            this.btnShowDailyUserSalesList.Text = "사용자별 일일 판매 현황";
            this.btnShowDailyUserSalesList.UseVisualStyleBackColor = true;
            this.btnShowDailyUserSalesList.Click += new System.EventHandler(this.btnShowDailyUserSalesList_Click);
            // 
            // dataGridViewAdminScreen
            // 
            this.dataGridViewAdminScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminScreen.Location = new System.Drawing.Point(7, 24);
            this.dataGridViewAdminScreen.Name = "dataGridViewAdminScreen";
            this.dataGridViewAdminScreen.RowHeadersWidth = 51;
            this.dataGridViewAdminScreen.RowTemplate.Height = 27;
            this.dataGridViewAdminScreen.Size = new System.Drawing.Size(866, 200);
            this.dataGridViewAdminScreen.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "맛있는 커피 - 5671309 한상우";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSellCafeMocha;
        private System.Windows.Forms.Button btnSellLatte;
        private System.Windows.Forms.Button btnSellAmericano;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAdminScreen;
        private System.Windows.Forms.Button btnShowMonthlyCoffeeSalesLIst;
        private System.Windows.Forms.Button btnShowDailyCoffeeSalesList;
        private System.Windows.Forms.Button btnShowDailyUserSalesList;
    }
}

