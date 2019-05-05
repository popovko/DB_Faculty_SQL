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
    public partial class FormSearchStudent : Form
    {
    string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";

    public FormSearchStudent()
        {
            InitializeComponent();
            string sql = "SELECT t.tc_name FROM Teachers AS t " +
                        " INNER JOIN Lesson AS l" +
                        " ON t.tc_ID = l.ls_IDtc" +     
                        " INNER JOIN Subject AS s" +
                        " ON l.ls_nameSb = s.sb_name" +
                        " WHERE s.sb_name = 'OOP'";

            // Соединяемся с сервером
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            // Создаем объект Dataset
            DataSet ds = new DataSet();

            // Заполняем Dataset
            adapter.Fill(ds);
            // Отображаем данные
             dgvStudents.DataSource = ds.Tables[0];
            ////////dgvStudents.Columns["st_ID"].Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
               string sql = "SELECT * FROM Students WHERE st_name LIKE " + "'%" + tbName.Text + "%'" + " OR "+
                              "st_ID LIKE " + "'%" + tbName.Text + "%'" + " OR "+
                              "st_nameGr LIKE " + "'%" + tbName.Text + "%'";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                // Создаем объект Dataset
                DataSet ds = new DataSet();

                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dgvStudents.DataSource = ds.Tables[0];
                dgvStudents.Columns["st_ID"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
