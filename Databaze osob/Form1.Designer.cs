namespace Databaze_osob
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seřaditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleJménaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poldePříjmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleVěkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.osobyListBox = new System.Windows.Forms.ListBox();
            this.detailyPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.osobyPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.detailyPanel.SuspendLayout();
            this.osobyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.podleJménaToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // poldePříjmeníToolStripMenuItem
            // 
            this.poldePříjmeníToolStripMenuItem.Name = "poldePříjmeníToolStripMenuItem";
            this.poldePříjmeníToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.poldePříjmeníToolStripMenuItem.Text = "By Last Name";
            this.poldePříjmeníToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // podleVěkuToolStripMenuItem
            // 
            this.podleVěkuToolStripMenuItem.Name = "podleVěkuToolStripMenuItem";
            this.podleVěkuToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.podleVěkuToolStripMenuItem.Text = "By ID";
            this.podleVěkuToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightGray;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.deleteButton);
            this.menuPanel.Controls.Add(this.addButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 33);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1228, 141);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 106);
            this.button3.TabIndex = 7;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // odebratButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("odebratButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(164, 18);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "odebratButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 106);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Student";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("pridatButton.Image")));
            this.addButton.Location = new System.Drawing.Point(14, 18);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "pridatButton";
            this.addButton.Size = new System.Drawing.Size(138, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Student";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // osobyListBox
            // 
            this.osobyListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osobyListBox.FormattingEnabled = true;
            this.osobyListBox.HorizontalScrollbar = true;
            this.osobyListBox.ItemHeight = 28;
            this.osobyListBox.Location = new System.Drawing.Point(0, 35);
            this.osobyListBox.Margin = new System.Windows.Forms.Padding(4);
            this.osobyListBox.Name = "osobyListBox";
            this.osobyListBox.Size = new System.Drawing.Size(357, 284);
            this.osobyListBox.TabIndex = 2;
            this.osobyListBox.SelectedIndexChanged += new System.EventHandler(this.osobyListBox_SelectedIndexChanged);
            // 
            // detailyPanel
            // 
            this.detailyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailyPanel.Controls.Add(this.button2);
            this.detailyPanel.Controls.Add(this.textBox1);
            this.detailyPanel.Controls.Add(this.label13);
            this.detailyPanel.Controls.Add(this.idLabel);
            this.detailyPanel.Controls.Add(this.groupLabel);
            this.detailyPanel.Controls.Add(this.emailLabel);
            this.detailyPanel.Controls.Add(this.lastnameLabel);
            this.detailyPanel.Controls.Add(this.firstnameLabel);
            this.detailyPanel.Controls.Add(this.label6);
            this.detailyPanel.Controls.Add(this.label5);
            this.detailyPanel.Controls.Add(this.label3);
            this.detailyPanel.Controls.Add(this.label2);
            this.detailyPanel.Controls.Add(this.label1);
            this.detailyPanel.Location = new System.Drawing.Point(0, 174);
            this.detailyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailyPanel.Name = "detailyPanel";
            this.detailyPanel.Size = new System.Drawing.Size(1228, 319);
            this.detailyPanel.TabIndex = 3;
            this.detailyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.detailyPanel_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(852, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(852, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Add to Group (Enter Group ID)";
            // 
            // vekLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(589, 130);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "vekLabel";
            this.idLabel.Size = new System.Drawing.Size(115, 31);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "Věk:";
            this.idLabel.Click += new System.EventHandler(this.vekLabel_Click);
            // 
            // pohlaviLabel
            // 
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupLabel.Location = new System.Drawing.Point(589, 179);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupLabel.Name = "pohlaviLabel";
            this.groupLabel.Size = new System.Drawing.Size(115, 31);
            this.groupLabel.TabIndex = 13;
            this.groupLabel.Text = "Pohlaví:";
            this.groupLabel.Click += new System.EventHandler(this.pohlaviLabel_Click);
            // 
            // datumNarozeniLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(589, 230);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "datumNarozeniLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 31);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Dat";
            this.emailLabel.Click += new System.EventHandler(this.datumNarozeniLabel_Click);
            // 
            // prijmeniLabel
            // 
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(589, 79);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "prijmeniLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(86, 31);
            this.lastnameLabel.TabIndex = 10;
            this.lastnameLabel.Text = "Příjmení";
            // 
            // jmenoLabel
            // 
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(589, 34);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "jmenoLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(78, 31);
            this.firstnameLabel.TabIndex = 9;
            this.firstnameLabel.Text = "Jméno:";
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
            this.osobyPanel.Controls.Add(this.label7);
            this.osobyPanel.Controls.Add(this.listBox1);
            this.osobyPanel.Controls.Add(this.label4);
            this.osobyPanel.Controls.Add(this.osobyListBox);
            this.osobyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.osobyPanel.Location = new System.Drawing.Point(0, 174);
            this.osobyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.osobyPanel.Name = "osobyPanel";
            this.osobyPanel.Size = new System.Drawing.Size(361, 642);
            this.osobyPanel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Groups";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 342);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 279);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Students";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(363, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 279);
            this.panel1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Group Members";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(388, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(474, 254);
            this.listBox2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(264, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(264, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Group Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Group ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Group Mark";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(264, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(63, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Award Mark";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 31);
            this.textBox2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Award";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormHlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.osobyPanel);
            this.Controls.Add(this.detailyPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muyiwa Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.detailyPanel.ResumeLayout(false);
            this.detailyPanel.PerformLayout();
            this.osobyPanel.ResumeLayout(false);
            this.osobyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel menuPanel;
        private PictureBox pictureBox1;
        private Button addButton;
        private Button deleteButton;
        private ListBox osobyListBox;
        private Panel detailyPanel;
        private Panel osobyPanel;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label idLabel;
        private Label groupLabel;
        private Label emailLabel;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem seřaditToolStripMenuItem;
        private ToolStripMenuItem podleJménaToolStripMenuItem;
        private ToolStripMenuItem poldePříjmeníToolStripMenuItem;
        private ToolStripMenuItem podleVěkuToolStripMenuItem;
        private Button button1;
        private Label label4;
        private Label label7;
        private ListBox listBox1;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ListBox listBox2;
        private Label label12;
        private Button button2;
        private TextBox textBox1;
        private Label label13;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}