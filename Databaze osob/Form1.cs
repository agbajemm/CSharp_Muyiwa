using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// pou�it� free ikony - https://www.iconfinder.com/
// fotky neexistuj�c�ch osob - https://thispersondoesnotexist.com/
// texty - http://www.lorem-ipsum.cz/

namespace Databaze_osob
{
    public partial class FormHlavni : Form
    {
        Databaze databaze = new Databaze();
        pridatForm pridatF;     // formul�� P�id�n� Osoby
        editForm editF;         // formul�� Editace Osoby
        public FormHlavni()
        {
            InitializeComponent();

            //a p�ipoj� listbox k databazi
            osobyListBox.DataSource = databaze.Data;

            // nastav� zobrazovan� hodnoty na zakladn�
            ResetHodnot();
        }


        //tla��tko p�idat novou osobu
        private void pridatButton_Click(object sender, EventArgs e)
        {
            try
            {
                pridatF = new pridatForm(databaze);
                pridatF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i p�id�n� osoby do datab�ze. Chyba: {ex.Message}");
            }


            RefreshData();
        }


        //vybr�n� polo�ky z listboxu a zobrazen� hodnot
        private void osobyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {

                jmenoLabel.Text = ((Osoba)osobyListBox.SelectedItem).Jmeno;
                prijmeniLabel.Text = ((Osoba)osobyListBox.SelectedItem).Prijmeni;
                pohlaviLabel.Text = ((Osoba)osobyListBox.SelectedItem).Pohlavi ? "Loading" : "Loading";

                vekLabel.Text = ((Osoba)osobyListBox.SelectedItem).ID.ToString();
            }
        }


        //vyma�e osobu z datab�ze
        private void odebratButton_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.OdeberZaznam((Osoba)osobyListBox.SelectedItem);
                ResetHodnot();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i odebr�n� osoby z datab�ze. Chyba: {ex.Message}");
            }

            

        }



        //editace vybran� Osoby
        private void upravitButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (osobyListBox.SelectedItem != null)
                {
                    editF = new editForm((Osoba)osobyListBox.SelectedItem);
                    editF.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i editaci osoby v datab�zi. Chyba: {ex.Message}");
            }


            RefreshData();

        }

   

        //serializace a ulo�en� databaze do xml po zav�en� hlavn�ho formul��e
        private void FormHlavni_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                databaze.Uloz();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i ukl�d�n� dat do souboru. Chyba: {ex.Message}");
            }
        }

        //deserializace a nahr�n� datab�ze z xml po zapnut� programu
        private void FormHlavni_Load(object sender, EventArgs e)
        {

            try
            {
                databaze.Nahraj();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i nahr�v�n� dat ze souboru. Chyba: {ex.Message}");
            }


        }

    
        // resetuje vypsan� hodnoty o Osob� na "-" a na "";
        public void ResetHodnot()
        {
            jmenoLabel.Text = "-";
            prijmeniLabel.Text = "-";
            pohlaviLabel.Text = "-";
            datumNarozeniLabel.Text = "-";
            vekLabel.Text = "";
        }

        //odpovj� a p�ipoj� data k listu aby se listbox obnovil
        public void RefreshData()
        {
            osobyListBox.DataSource = null;
            osobyListBox.DataSource = databaze.Data;
        }

        //info
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        //konec programu
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //se�ad� list podle toho co se klikne
        private void podleJm�naToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int podleCeho = 0;
            if ((sender as ToolStripMenuItem).Text == "By First Name")
                podleCeho = 1;
            if ((sender as ToolStripMenuItem).Text == "By Last Name")
                podleCeho = 2;
            if ((sender as ToolStripMenuItem).Text == "By ID")
                podleCeho = 3;


            try 
            {
            databaze.Serad(podleCeho);
            RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i �azen� dat. Chyba: {ex.Message}");
            }
        }


        //  zapne/vypne nabidku filtru
        private void filterButton_Click(object sender, EventArgs e)
        {

            filterPanel.Visible = filterPanel.Visible ? false : true;
            filterComboBox.SelectedItem = filterComboBox.Items[0];
        }

        //potvrd� filtr
        private void filterOK_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
            filterButton.Visible = false;
            filterNoButton.Visible = true;

            try
            { 
            databaze.Filtruj(filterComboBox.Text);
            osobyListBox.DataSource = databaze.FiltrovanaData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba p�i filtrov�n� dat. Chyba: {ex.Message}");
            }
        }

        // kdy� je zapnut� filtr tak ho zru��
        private void filterNoButton_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
            filterButton.Visible = true;
            filterNoButton.Visible = false;
            
            databaze.ResetFiltru();
            RefreshData();

            

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
    }

}
