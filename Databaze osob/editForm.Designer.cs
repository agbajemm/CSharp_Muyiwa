namespace Databaze_osob
{
    partial class editForm
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
            this.zenaRadioButton = new System.Windows.Forms.RadioButton();
            this.muzRadioButton = new System.Windows.Forms.RadioButton();
            this.ulozOsobuButton = new System.Windows.Forms.Button();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zenaRadioButton
            // 
            this.zenaRadioButton.AutoSize = true;
            this.zenaRadioButton.Location = new System.Drawing.Point(406, 252);
            this.zenaRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.zenaRadioButton.Name = "zenaRadioButton";
            this.zenaRadioButton.Size = new System.Drawing.Size(75, 29);
            this.zenaRadioButton.TabIndex = 37;
            this.zenaRadioButton.Text = "Žena";
            this.zenaRadioButton.UseVisualStyleBackColor = true;
            // 
            // muzRadioButton
            // 
            this.muzRadioButton.AutoSize = true;
            this.muzRadioButton.Checked = true;
            this.muzRadioButton.Location = new System.Drawing.Point(286, 252);
            this.muzRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.muzRadioButton.Name = "muzRadioButton";
            this.muzRadioButton.Size = new System.Drawing.Size(71, 29);
            this.muzRadioButton.TabIndex = 36;
            this.muzRadioButton.TabStop = true;
            this.muzRadioButton.Text = "Muž";
            this.muzRadioButton.UseVisualStyleBackColor = true;
            // 
            // ulozOsobuButton
            // 
            this.ulozOsobuButton.Location = new System.Drawing.Point(340, 319);
            this.ulozOsobuButton.Margin = new System.Windows.Forms.Padding(4);
            this.ulozOsobuButton.Name = "ulozOsobuButton";
            this.ulozOsobuButton.Size = new System.Drawing.Size(199, 55);
            this.ulozOsobuButton.TabIndex = 34;
            this.ulozOsobuButton.Text = "Save";
            this.ulozOsobuButton.UseVisualStyleBackColor = true;
            this.ulozOsobuButton.Click += new System.EventHandler(this.ulozOsobuButton_Click);
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(260, 180);
            this.prijmeniTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(279, 31);
            this.prijmeniTextBox.TabIndex = 32;
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(260, 112);
            this.jmenoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(279, 31);
            this.jmenoTextBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(99, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Group";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(98, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(98, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 648);
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
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editace osoby";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton zenaRadioButton;
        private RadioButton muzRadioButton;
        private Button ulozOsobuButton;
        private TextBox prijmeniTextBox;
        private TextBox jmenoTextBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}