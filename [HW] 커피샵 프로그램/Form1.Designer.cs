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
            this.components = new System.ComponentModel.Container();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadCoffee = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.dataGridViewCoffee = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowMonthlyCoffeeSalesLIst = new System.Windows.Forms.Button();
            this.btnShowDailyCoffeeSalesList = new System.Windows.Forms.Button();
            this.btnShowDailyUserSalesList = new System.Windows.Forms.Button();
            this.dataGridViewAdminScreen = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffee)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminScreen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Location = new System.Drawing.Point(634, 47);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(172, 15);
            this.labelLoginUser.TabIndex = 5;
            this.labelLoginUser.Text = "먼저 로그인을 해주세요.";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(832, 42);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadCoffee);
            this.groupBox1.Controls.Add(this.buttonSell);
            this.groupBox1.Controls.Add(this.dataGridViewCoffee);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(48, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 292);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // buttonLoadCoffee
            // 
            this.buttonLoadCoffee.Location = new System.Drawing.Point(321, 25);
            this.buttonLoadCoffee.Name = "buttonLoadCoffee";
            this.buttonLoadCoffee.Size = new System.Drawing.Size(154, 31);
            this.buttonLoadCoffee.TabIndex = 3;
            this.buttonLoadCoffee.Text = "새로고침";
            this.buttonLoadCoffee.UseVisualStyleBackColor = true;
            this.buttonLoadCoffee.Click += new System.EventHandler(this.buttonLoadCoffee_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSell.Location = new System.Drawing.Point(552, 63);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(304, 200);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "판매하기";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // dataGridViewCoffee
            // 
            this.dataGridViewCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoffee.Location = new System.Drawing.Point(7, 63);
            this.dataGridViewCoffee.Name = "dataGridViewCoffee";
            this.dataGridViewCoffee.RowHeadersWidth = 51;
            this.dataGridViewCoffee.RowTemplate.Height = 27;
            this.dataGridViewCoffee.Size = new System.Drawing.Size(508, 200);
            this.dataGridViewCoffee.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 28);
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
            this.groupBox2.Location = new System.Drawing.Point(48, 395);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자메뉴ToolStripMenuItem
            // 
            this.관리자메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매메뉴관리ToolStripMenuItem,
            this.사용자로그ToolStripMenuItem});
            this.관리자메뉴ToolStripMenuItem.Name = "관리자메뉴ToolStripMenuItem";
            this.관리자메뉴ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.관리자메뉴ToolStripMenuItem.Text = "관리자 메뉴";
            // 
            // 판매메뉴관리ToolStripMenuItem
            // 
            this.판매메뉴관리ToolStripMenuItem.Name = "판매메뉴관리ToolStripMenuItem";
            this.판매메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.판매메뉴관리ToolStripMenuItem.Text = "판매 메뉴 관리";
            this.판매메뉴관리ToolStripMenuItem.Click += new System.EventHandler(this.판매메뉴관리ToolStripMenuItem_Click);
            // 
            // 사용자로그ToolStripMenuItem
            // 
            this.사용자로그ToolStripMenuItem.Name = "사용자로그ToolStripMenuItem";
            this.사용자로그ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.사용자로그ToolStripMenuItem.Text = "사용자 로그";
            this.사용자로그ToolStripMenuItem.Click += new System.EventHandler(this.사용자로그ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 746);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelLoginUser);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "맛있는 커피 - 5671309 한상우";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminScreen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAdminScreen;
        private System.Windows.Forms.Button btnShowMonthlyCoffeeSalesLIst;
        private System.Windows.Forms.Button btnShowDailyCoffeeSalesList;
        private System.Windows.Forms.Button btnShowDailyUserSalesList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자로그ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCoffee;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonLoadCoffee;
    }
}

