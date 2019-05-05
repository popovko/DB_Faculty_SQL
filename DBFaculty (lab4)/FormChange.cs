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
    public partial class FormChange : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";

        public FormChange()
        {

            InitializeComponent();

            string sqlGroupNames = "SELECT gr_name FROM Groups";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlGroupNames, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbGroups.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            string sqlTeachers = "SELECT tc_name FROM Teachers";
            command = new SqlCommand(sqlTeachers, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbCurators.Items.Add(reader.GetValue(0));
            }
            reader.Close();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                if (cbNewLeader.Text != "")
                {
                      string sql = "UPDATE Groups SET gr_IDleader = (SELECT st_ID FROM Students WHERE st_name = '" + cbNewLeader.Text +
                                 "') WHERE gr_name = '" + cbGroups.Text + "'" ;
                    MessageBox.Show(sql);
                    
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                if(cbCurators.Text != "")
                {
                    string sql = "UPDATE Groups SET gr_IDCurator = (SELECT tc_ID FROM Teachers WHERE tc_name = '" + cbCurators.Text +
                            "') WHERE gr_name = '" + cbGroups.Text + "'";
                    MessageBox.Show(sql);
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNewLeader.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlLeaders = "SELECT st_name FROM Students WHERE st_nameGr ='" + cbGroups.Text + "'";
            SqlCommand command = new SqlCommand(sqlLeaders, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbNewLeader.Items.Add(reader.GetValue(0));
            }
        }
    }
}
