using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databaze_osob
{
    /// <summary>
    /// Rormulář na editaci Osoby
    /// </summary>
    public partial class editForm : Form
    {

        public Osoba osoba;
        public editForm(Osoba osoba)
        {
            InitializeComponent();

            this.osoba = osoba;

        }

        //tlačítko na uložení editované osoby
        private void ulozOsobuButton_Click(object sender, EventArgs e)
        {
            try 
            {

            osoba.ID = int.Parse(textBox1.Text);
            osoba.Jmeno = jmenoTextBox.Text;
            osoba.Prijmeni = prijmeniTextBox.Text;
            osoba.Pohlavi = muzRadioButton.Checked;

            this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při uložení editované osoby. Chyba: {ex.Message}");
            }
        }

        //nahrání hodnot po loadu editForm
        private void editForm_Load(object sender, EventArgs e)
        {
            osoba.ID = int.Parse(textBox1.Text);
            jmenoTextBox.Text = osoba.Jmeno;
            prijmeniTextBox.Text = osoba.Prijmeni;
            
            if (osoba.Pohlavi) muzRadioButton.Checked = true;
            else zenaRadioButton.Checked = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
