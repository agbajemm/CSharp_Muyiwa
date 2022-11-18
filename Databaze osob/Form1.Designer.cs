namespace Databaze_osob
{
    partial class FormHlavni
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHlavni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seřaditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleJménaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poldePříjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleVěkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.filterNoButton = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterOK = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.upravitButton = new System.Windows.Forms.Button();
            this.odebratButton = new System.Windows.Forms.Button();
            this.pridatButton = new System.Windows.Forms.Button();
            this.osobyListBox = new System.Windows.Forms.ListBox();
            this.detailyPanel = new System.Windows.Forms.Panel();
            this.vekLabel = new System.Windows.Forms.Label();
            this.pohlaviLabel = new System.Windows.Forms.Label();
            this.datumNarozeniLabel = new System.Windows.Forms.Label();
            this.prijmeniLabel = new System.Windows.Forms.Label();
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.osobyPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.detailyPanel.SuspendLayout();
            this.osobyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.seřaditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1228, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konecToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.konecToolStripMenuItem.Text = "Close";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // seřaditToolStripMenuItem
            // 
            this.seřaditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podleJménaToolStripMenuItem,
            this.poldePříjmeníToolStripMenuItem,
            this.podleVěkuToolStripMenuItem});
            this.seřaditToolStripMenuItem.Name = "seřaditToolStripMenuItem";
            this.seřaditToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.seřaditToolStripMenuItem.Text = "Sort";
            // 
            // podleJménaToolStripMenuItem
            // 
            this.podleJménaToolStripMenuItem.Name = "podleJménaToolStripMenuItem";
            this.podleJménaToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.podleJménaToolStripMenuItem.Text = "By First Name";
            this.podleJménaToolStripMenuItem.Click += new System.EventHandler(this.podleJménaToolStripMenuItem_Click);
            // 
            // poldePříjmeníToolStripMenuItem
            // 
            this.poldePříjmeníToolStripMenuItem.Name = "poldePříjmeníToolStripMenuItem";
            this.poldePříjmeníToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.poldePříjmeníToolStripMenuItem.Text = "By Last Name";
            this.poldePříjmeníToolStripMenuItem.Click += new System.EventHandler(this.podleJménaToolStripMenuItem_Click);
            // 
            // podleVěkuToolStripMenuItem
            // 
            this.podleVěkuToolStripMenuItem.Name = "podleVěkuToolStripMenuItem";
            this.podleVěkuToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.podleVěkuToolStripMenuItem.Text = "By ID";
            this.podleVěkuToolStripMenuItem.Click += new System.EventHandler(this.podleJménaToolStripMenuItem_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightGray;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.filterNoButton);
            this.menuPanel.Controls.Add(this.filterPanel);
            this.menuPanel.Controls.Add(this.filterButton);
            this.menuPanel.Controls.Add(this.upravitButton);
            this.menuPanel.Controls.Add(this.odebratButton);
            this.menuPanel.Controls.Add(this.pridatButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 33);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1228, 141);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // filterNoButton
            // 
            this.filterNoButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterNoButton.Location = new System.Drawing.Point(474, 26);
            this.filterNoButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterNoButton.Name = "filterNoButton";
            this.filterNoButton.Size = new System.Drawing.Size(138, 106);
            this.filterNoButton.TabIndex = 5;
            this.filterNoButton.Text = "Close";
            this.filterNoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filterNoButton.UseVisualStyleBackColor = true;
            this.filterNoButton.Visible = false;
            this.filterNoButton.Click += new System.EventHandler(this.filterNoButton_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.filterOK);
            this.filterPanel.Controls.Add(this.filterComboBox);
            this.filterPanel.Controls.Add(this.label8);
            this.filterPanel.Location = new System.Drawing.Point(619, 18);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(592, 106);
            this.filterPanel.TabIndex = 4;
            this.filterPanel.Visible = false;
            // 
            // filterOK
            // 
            this.filterOK.Location = new System.Drawing.Point(198, 55);
            this.filterOK.Margin = new System.Windows.Forms.Padding(4);
            this.filterOK.Name = "filterOK";
            this.filterOK.Size = new System.Drawing.Size(124, 36);
            this.filterOK.TabIndex = 24;
            this.filterOK.Text = "Filter";
            this.filterOK.UseVisualStyleBackColor = true;
            this.filterOK.Click += new System.EventHandler(this.filterOK_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Vše",
            "Muž",
            "Žena"});
            this.filterComboBox.Location = new System.Drawing.Point(45, 55);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(120, 33);
            this.filterComboBox.TabIndex = 23;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(45, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Group";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.Location = new System.Drawing.Point(474, 18);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(138, 106);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter by Group";
            this.filterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // upravitButton
            // 
            this.upravitButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upravitButton.Image = ((System.Drawing.Image)(resources.GetObject("upravitButton.Image")));
            this.upravitButton.Location = new System.Drawing.Point(318, 18);
            this.upravitButton.Margin = new System.Windows.Forms.Padding(4);
            this.upravitButton.Name = "upravitButton";
            this.upravitButton.Size = new System.Drawing.Size(138, 106);
            this.upravitButton.TabIndex = 2;
            this.upravitButton.Text = "Edit Student";
            this.upravitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.upravitButton.UseVisualStyleBackColor = true;
            this.upravitButton.Click += new System.EventHandler(this.upravitButton_Click);
            // 
            // odebratButton
            // 
            this.odebratButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odebratButton.Image = ((System.Drawing.Image)(resources.GetObject("odebratButton.Image")));
            this.odebratButton.Location = new System.Drawing.Point(164, 18);
            this.odebratButton.Margin = new System.Windows.Forms.Padding(4);
            this.odebratButton.Name = "odebratButton";
            this.odebratButton.Size = new System.Drawing.Size(138, 106);
            this.odebratButton.TabIndex = 1;
            this.odebratButton.Text = "Delete Student";
            this.odebratButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.odebratButton.UseVisualStyleBackColor = true;
            this.odebratButton.Click += new System.EventHandler(this.odebratButton_Click);
            // 
            // pridatButton
            // 
            this.pridatButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pridatButton.Image = ((System.Drawing.Image)(resources.GetObject("pridatButton.Image")));
            this.pridatButton.Location = new System.Drawing.Point(14, 18);
            this.pridatButton.Margin = new System.Windows.Forms.Padding(4);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(138, 106);
            this.pridatButton.TabIndex = 0;
            this.pridatButton.Text = "Add Student";
            this.pridatButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pridatButton.UseVisualStyleBackColor = true;
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // osobyListBox
            // 
            this.osobyListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.osobyListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osobyListBox.FormattingEnabled = true;
            this.osobyListBox.ItemHeight = 28;
            this.osobyListBox.Location = new System.Drawing.Point(0, 0);
            this.osobyListBox.Margin = new System.Windows.Forms.Padding(4);
            this.osobyListBox.Name = "osobyListBox";
            this.osobyListBox.Size = new System.Drawing.Size(360, 642);
            this.osobyListBox.TabIndex = 2;
            this.osobyListBox.SelectedIndexChanged += new System.EventHandler(this.osobyListBox_SelectedIndexChanged);
            // 
            // detailyPanel
            // 
            this.detailyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailyPanel.Controls.Add(this.vekLabel);
            this.detailyPanel.Controls.Add(this.pohlaviLabel);
            this.detailyPanel.Controls.Add(this.datumNarozeniLabel);
            this.detailyPanel.Controls.Add(this.prijmeniLabel);
            this.detailyPanel.Controls.Add(this.jmenoLabel);
            this.detailyPanel.Controls.Add(this.label6);
            this.detailyPanel.Controls.Add(this.label5);
            this.detailyPanel.Controls.Add(this.label3);
            this.detailyPanel.Controls.Add(this.label2);
            this.detailyPanel.Controls.Add(this.label1);
            this.detailyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailyPanel.Location = new System.Drawing.Point(0, 174);
            this.detailyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailyPanel.Name = "detailyPanel";
            this.detailyPanel.Size = new System.Drawing.Size(1228, 642);
            this.detailyPanel.TabIndex = 3;
            // 
            // vekLabel
            // 
            this.vekLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vekLabel.Location = new System.Drawing.Point(589, 130);
            this.vekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vekLabel.Name = "vekLabel";
            this.vekLabel.Size = new System.Drawing.Size(115, 31);
            this.vekLabel.TabIndex = 14;
            this.vekLabel.Text = "Věk:";
            this.vekLabel.Click += new System.EventHandler(this.vekLabel_Click);
            // 
            // pohlaviLabel
            // 
            this.pohlaviLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pohlaviLabel.Location = new System.Drawing.Point(589, 179);
            this.pohlaviLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pohlaviLabel.Name = "pohlaviLabel";
            this.pohlaviLabel.Size = new System.Drawing.Size(115, 31);
            this.pohlaviLabel.TabIndex = 13;
            this.pohlaviLabel.Text = "Pohlaví:";
            // 
            // datumNarozeniLabel
            // 
            this.datumNarozeniLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datumNarozeniLabel.Location = new System.Drawing.Point(589, 230);
            this.datumNarozeniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumNarozeniLabel.Name = "datumNarozeniLabel";
            this.datumNarozeniLabel.Size = new System.Drawing.Size(115, 31);
            this.datumNarozeniLabel.TabIndex = 11;
            this.datumNarozeniLabel.Text = "Dat";
            // 
            // prijmeniLabel
            // 
            this.prijmeniLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prijmeniLabel.Location = new System.Drawing.Point(589, 79);
            this.prijmeniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prijmeniLabel.Name = "prijmeniLabel";
            this.prijmeniLabel.Size = new System.Drawing.Size(86, 31);
            this.prijmeniLabel.TabIndex = 10;
            this.prijmeniLabel.Text = "Příjmení";
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jmenoLabel.Location = new System.Drawing.Point(589, 34);
            this.jmenoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(78, 31);
            this.jmenoLabel.TabIndex = 9;
            this.jmenoLabel.Text = "Jméno:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(428, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(428, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Group";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(428, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(428, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(428, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // osobyPanel
            // 
            this.osobyPanel.Controls.Add(this.osobyListBox);
            this.osobyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.osobyPanel.Location = new System.Drawing.Point(0, 174);
            this.osobyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.osobyPanel.Name = "osobyPanel";
            this.osobyPanel.Size = new System.Drawing.Size(361, 642);
            this.osobyPanel.TabIndex = 4;
            // 
            // FormHlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 816);
            this.Controls.Add(this.osobyPanel);
            this.Controls.Add(this.detailyPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muyiwa Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHlavni_FormClosing);
            this.Load += new System.EventHandler(this.FormHlavni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.detailyPanel.ResumeLayout(false);
            this.osobyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel menuPanel;
        private PictureBox pictureBox1;
        private Button pridatButton;
        private Button odebratButton;
        private ListBox osobyListBox;
        private Panel detailyPanel;
        private Panel osobyPanel;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button upravitButton;
        private Label vekLabel;
        private Label pohlaviLabel;
        private Label datumNarozeniLabel;
        private Label prijmeniLabel;
        private Label jmenoLabel;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem seřaditToolStripMenuItem;
        private ToolStripMenuItem podleJménaToolStripMenuItem;
        private ToolStripMenuItem poldePříjmeníToolStripMenuItem;
        private ToolStripMenuItem podleVěkuToolStripMenuItem;
        private Button filterButton;
        private Panel filterPanel;
        private Button filterOK;
        private ComboBox filterComboBox;
        private Label label8;
        private Button filterNoButton;
    }
}