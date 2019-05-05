using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBFaculty__lab4_
{
    public partial class FormAddTeacher : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";
        public FormAddTeacher()
        {
            InitializeComponent();
            //заполняем комбо бокс с кафедрами
            string sqlDepartmantNames = "SELECT dp_name FROM Department";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlDepartmantNames, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {   
                cbTchDepartment.Items.Add(reader.GetValue(0));
            }           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTchName.Text.Contains('0') || tbTchName.Text.Contains('1') || tbTchName.Text.Contains('2') || tbTchName.Text.Contains('3')
                    || tbTchName.Text.Contains('4') || tbTchName.Text.Contains('5') || tbTchName.Text.Contains('6')
                    || tbTchName.Text.Contains('7') || tbTchName.Text.Contains('8') || tbTchName.Text.Contains('9'))
                {
                    MessageBox.Show("Incorrect name");
                    return;
                }
                string sql = String.Format("INSERT INTO Teachers (tc_name, tc_nameDp) VALUES ('{0}', '{1}')",
                    tbTchName.Text, cbTchDepartment.Text);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
