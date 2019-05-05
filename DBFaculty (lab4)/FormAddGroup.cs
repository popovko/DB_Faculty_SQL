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
   

    public partial class FormAddGroup : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";
      
        public FormAddGroup()
        {
            InitializeComponent();
            //заполняем комбо бокс с кураторами
            string sql = "SELECT tc_ID, tc_name FROM Teachers";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbGrCurator.Items.Add(reader.GetValue(0) + ". " + reader.GetValue(1));
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("INSERT INTO Groups (gr_name, gr_year, gr_IDcurator) VALUES ('{0}', '{1}', '{2}')",
                    tbGrName.Text, cbGrYear.Text, getIDfromString(cbGrCurator.Text));
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


        private int getIDfromString(string str)
        {
            int res = 0;
            int i = 0;
            while (str[i] != '.')
            {
                res = res * 10 + str[i] - '0';
                i++;
            }
            return res;
        }
    }
}
