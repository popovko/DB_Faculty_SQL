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
    public partial class FormAddStudent : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";

        public FormAddStudent()
        {
            InitializeComponent();
            //заполняем комбо бокс с группами
            string sqlGroupNames = "SELECT gr_name FROM Groups";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlGroupNames, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cbStGroup.Items.Add(reader.GetValue(0));
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.CorrectName(tbStName.Text);
                    
                string sql = String.Format("INSERT INTO Students (st_name, st_nameGr) VALUES ('{0}', '{1}')",
                    tbStName.Text, cbStGroup.Text);
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
