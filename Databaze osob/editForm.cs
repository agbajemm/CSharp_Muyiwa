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
    /// Edit Students
    /// </summary>
    public partial class editForm : Form
    {

        public Student student;
        public editForm(Student student, int ID)
        {
            InitializeComponent();

            this.student = student;
            int id = ID;
            try
            {

                student.Group_ID = id;

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($" {ex.Message}");
            }
            this.Close();

        }

        private void editForm_Load(object sender, EventArgs e)
        {

        }
    }
}
