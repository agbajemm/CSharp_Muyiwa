using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

using Microsoft.VisualBasic.FileIO;

namespace Databaze_osob
{
    /// <summary>
    /// formulář na přidání osoby
    /// </summary>
    public partial class pridatForm : Form
    {

        Databaze databaze;
        Osoba novaOsoba;
        public pridatForm(Databaze databaze)
        {
            InitializeComponent();
            this.databaze = databaze;
        }


        // tlačítko uložit novou osobu, obrazek převede na pole bytu
        private void ulozOsobuButton_Click(object sender, EventArgs e)
        {

            try
            {
                //vytvoří Osobu ze zadaných udajů
                Osoba novaOsoba = new Osoba(
                int.Parse(textBox1.Text),
                jmenoTextBox.Text,
                prijmeniTextBox.Text,
                muzRadioButton.Checked
             );

                //prida Osobu do databaze
                databaze.PridejZaznam(novaOsoba);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při uložení osoby. Chyba: {ex.Message}");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void datumTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btbrowse_Click(object sender, EventArgs e)
        {

        }

        private void btbrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                // To list only csv files, we need to add this filter
                Filter = "|*.csv"
            };
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                csvPath.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                csvGridView.DataSource = GetDataTableFromCSVFile(csvPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK,
  MessageBoxIcon.Error);
            }
        }
        private static DataTable GetDataTableFromCSVFile(string csvfilePath)
        {
            DataTable csvData = new();
            using (TextFieldParser csvReader = new(csvfilePath))
            {
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;

                //Read columns from CSV file, remove this line if columns not exits  
                string[] colFields = csvReader.ReadFields();

                for (int i = 0; i < colFields.Length; i++)
                {
                    string column = colFields[i];
                    DataColumn datecolumn = new(column)
                    {
                        AllowDBNull = true
                    };
                    csvData.Columns.Add(datecolumn);
                }

                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();
                    //Making empty value as null

                    if (fieldData is not null)
                    {
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            return csvData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtItem = (DataTable)(csvGridView.DataSource);
                string ID, First_Name, Last_Name;
                bool Group_id;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    ID = Convert.ToString(dr["ID"]);
                    First_Name = Convert.ToString(dr["FirstName"]);
                    Last_Name = Convert.ToString(dr["LastName"]);
                    Group_id = true;
                    if (ID != "" && First_Name != "" && Last_Name != "")
                    {
                        try
                        {
                            Osoba novaOsoba = new Osoba(
                            int.Parse(ID),
                            First_Name,
                            Last_Name,
                            Group_id
                         );

                            //prida Osobu do databaze
                            databaze.PridejZaznam(novaOsoba);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
    }
}
