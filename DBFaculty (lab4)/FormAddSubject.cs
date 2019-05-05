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
    public partial class FormAddSubject : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";
        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("INSERT INTO Subject (sb_name, sb_info) VALUES ('{0}', '{1}')",
                    tbSbName.Text, tbSbInfo.Text);
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
