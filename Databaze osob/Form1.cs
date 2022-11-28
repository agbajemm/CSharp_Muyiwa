using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Databaze_osob
{
    public partial class FormMain : Form
    {
        Database database = new Database();
        addForm addF;     // Add Student form
        editForm editF;         // form Edit Student
        GroupF GroupF;      // form Add Group
        public Group group;
        public FormMain()
        {
            InitializeComponent();

            //connects the listbox to the database
            osobyListBox.DataSource = database.Data;

            // sets the displayed values ​​to the basic values
            ResetValues();
        }


        //button to add a new person
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                addF = new addForm(database);
                addF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding a person to the database. Error: {ex.Message}");
            }


            RefreshData();
        }


        //selecting an item from the listbox and displaying the values
        private void osobyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {

                firstnameLabel.Text = ((Student)osobyListBox.SelectedItem).FirstName;
                lastnameLabel.Text = ((Student)osobyListBox.SelectedItem).LastName;
                emailLabel.Text = ((Student)osobyListBox.SelectedItem).Email;
                groupLabel.Text = ((Student)osobyListBox.SelectedItem).Group_ID.ToString();

                idLabel.Text = ((Student)osobyListBox.SelectedItem).ID.ToString();
            }
        }


        //deletes the person from the database
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                database.RemoveRecord((Student)osobyListBox.SelectedItem);
                ResetValues();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing a person from the database. Error: {ex.Message}");
            }

            

        }


        // serialization and saving the database to xml after closing the main form
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                database.saveRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving data to the file. Error: {ex.Message}");
            }
        }

        //deserialization and uploading the database from xml after starting the program
        private void FormMain_Load(object sender, EventArgs e)
        {

            try
            {
                database.getRecord();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading data from the file. Error: {ex.Message}");
            }


        }


        // resets the values ​​about Student to "-" and to ""
        public void ResetValues()
        {
            firstnameLabel.Text = "-";
            lastnameLabel.Text = "-";
            groupLabel.Text = "-";
            emailLabel.Text = "-";
            idLabel.Text = "";
        }

        //appends the data to the sheet to refresh the listbox
        public void RefreshData()
        {
            osobyListBox.DataSource = null;
            osobyListBox.DataSource = database.Data;
            listBox1.DataSource = database.Data1;
        }

        //close program
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //sorts the sheet according to what is clicked
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sortby = 0;
            if ((sender as ToolStripMenuItem).Text == "By First Name")
                sortby = 1;
            if ((sender as ToolStripMenuItem).Text == "By Last Name")
                sortby = 2;
            if ((sender as ToolStripMenuItem).Text == "By ID")
                sortby = 3;


            try 
            {
            database.sortRecords(sortby);
            RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sorting the data. Error: {ex.Message}");
            }
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vekLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void datumNarozeniLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                GroupF = new GroupF(database);
                GroupF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }


            RefreshData();
        }

        private void pohlaviLabel_Click(object sender, EventArgs e)
        {

        }

        private void detailyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                label10.Text = ((Group)listBox1.SelectedItem).GroupID.ToString();
                label11.Text = ((Group)listBox1.SelectedItem).GroupName;
                label15.Text = ((Group)listBox1.SelectedItem).GroupMark.ToString();

                database.Group_Members(Convert.ToInt32(label10.Text));
                listBox2.DataSource = database.FilteredData;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.Group_Members(Convert.ToInt32(textBox1.Text));
            int numbers = database.FilteredData.Count();
            if (numbers == 4)
            {
                MessageBox.Show($"Group is full - already has 4 members");
            }
            else
            {
                editF = new editForm((Student)osobyListBox.SelectedItem, int.Parse(textBox1.Text));
            }
            Application.Restart();
            Environment.Exit(0);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Group group = (Group)listBox1.SelectedItem;
            this.group = group;
            int id = int.Parse(textBox2.Text);
            try
            {

                group.GroupMark = id;

            }
            catch (Exception ex)
            {
                MessageBox.Show($" {ex.Message}");
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }

}
