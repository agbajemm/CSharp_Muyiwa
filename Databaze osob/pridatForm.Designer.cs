namespace Databaze_osob
{
    partial class pridatForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.ulozOsobuButton = new System.Windows.Forms.Button();
            this.muzRadioButton = new System.Windows.Forms.RadioButton();
            this.zenaRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btbrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.csvGridView = new System.Windows.Forms.DataGridView();
            this.csvPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(95, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Group";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(94, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(94, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(256, 109);
            this.jmenoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(279, 31);
            this.jmenoTextBox.TabIndex = 15;
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(256, 176);
            this.prijmeniTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(279, 31);
            this.prijmeniTextBox.TabIndex = 16;
            // 
            // ulozOsobuButton
            // 
            this.ulozOsobuButton.Location = new System.Drawing.Point(336, 295);
            this.ulozOsobuButton.Margin = new System.Windows.Forms.Padding(4);
            this.ulozOsobuButton.Name = "ulozOsobuButton";
            this.ulozOsobuButton.Size = new System.Drawing.Size(199, 55);
            this.ulozOsobuButton.TabIndex = 20;
            this.ulozOsobuButton.Text = "Add Student";
            this.ulozOsobuButton.UseVisualStyleBackColor = true;
            this.ulozOsobuButton.Click += new System.EventHandler(this.ulozOsobuButton_Click);
            // 
            // muzRadioButton
            // 
            this.muzRadioButton.AutoSize = true;
            this.muzRadioButton.Checked = true;
            this.muzRadioButton.Location = new System.Drawing.Point(282, 249);
            this.muzRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.muzRadioButton.Name = "muzRadioButton";
            this.muzRadioButton.Size = new System.Drawing.Size(71, 29);
            this.muzRadioButton.TabIndex = 22;
            this.muzRadioButton.TabStop = true;
            this.muzRadioButton.Text = "Muž";
            this.muzRadioButton.UseVisualStyleBackColor = true;
            this.muzRadioButton.Visible = false;
            // 
            // zenaRadioButton
            // 
            this.zenaRadioButton.AutoSize = true;
            this.zenaRadioButton.Location = new System.Drawing.Point(402, 249);
            this.zenaRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.zenaRadioButton.Name = "zenaRadioButton";
            this.zenaRadioButton.Size = new System.Drawing.Size(75, 29);
            this.zenaRadioButton.TabIndex = 23;
            this.zenaRadioButton.Text = "Žena";
            this.zenaRadioButton.UseVisualStyleBackColor = true;
            this.zenaRadioButton.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Or Upload CSV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btbrowse
            // 
            this.btbrowse.Location = new System.Drawing.Point(255, 352);
            this.btbrowse.Name = "btbrowse";
            this.btbrowse.Size = new System.Drawing.Size(98, 77);
            this.btbrowse.TabIndex = 28;
            this.btbrowse.Text = "Browse";
            this.btbrowse.UseVisualStyleBackColor = true;
            this.btbrowse.Click += new System.EventHandler(this.btbrowse_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add Student(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // csvGridView
            // 
            this.csvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvGridView.Location = new System.Drawing.Point(117, 429);
            this.csvGridView.Name = "csvGridView";
            this.csvGridView.RowHeadersWidth = 62;
            this.csvGridView.RowTemplate.Height = 33;
            this.csvGridView.Size = new System.Drawing.Size(418, 156);
            this.csvGridView.TabIndex = 32;
            // 
            // csvPath
            // 
            this.csvPath.Location = new System.Drawing.Point(359, 352);
            this.csvPath.Name = "csvPath";
            this.csvPath.Size = new System.Drawing.Size(292, 31);
            this.csvPath.TabIndex = 33;
            // 
            // pridatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 648);
            this.Controls.Add(this.csvPath);
            this.Controls.Add(this.csvGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zenaRadioButton);
            this.Controls.Add(this.muzRadioButton);
            this.Controls.Add(this.ulozOsobuButton);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pridatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox jmenoTextBox;
        private TextBox prijmeniTextBox;
        private Button ulozOsobuButton;
        private RadioButton muzRadioButton;
        private RadioButton zenaRadioButton;
        private TextBox textBox1;
        private Label label4;
        private Button btbrowse;
        private Button button1;
        private Button button2;
        private DataGridView csvGridView;
        private TextBox csvPath;
    }
}