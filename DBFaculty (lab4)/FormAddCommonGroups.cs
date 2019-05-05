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
    public partial class FormAddCommonGroups : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";

        public FormAddCommonGroups()
        {
            InitializeComponent();
            //заполняем комбо бокс с группами
            string sqlGroupNames = "SELECT gr_name FROM Groups";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlGroupNames, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cb1.Items.Add(reader.GetValue(0));
                cb2.Items.Add(reader.GetValue(0));
                cb3.Items.Add(reader.GetValue(0));
                cb4.Items.Add(reader.GetValue(0));
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlHelp1 = "INSERT INTO CommonGroups( ";
                string sqlHelp2 = "VALUES (";
                if (tbCgrInfo.Text != "")
                {
                    sqlHelp1 += "cgr_info";
                    sqlHelp2 += "'" +  tbCgrInfo.Text +"' ";
                }
                else
                {
                    MessageBox.Show("Заповніть INFO");
                    return;
                }
                if(cb1.Text != "")
                {
                    sqlHelp1 += ",cgr_nameGr1 ";
                    sqlHelp2 += ", " + "'" + cb1.Text + "'";
                }
                if (cb2.Text != "")
                {
                    sqlHelp1 += ",cgr_nameGr2 ";
                    sqlHelp2 += ", "  + "'" + cb2.Text + "'";
                }
                if (cb3.Text != "")
                {
                    sqlHelp1 += ",cgr_nameGr3 ";
                    sqlHelp2 += ", " + "'" + cb3.Text + "'";
                }
                if (cb4.Text !="")
                {
                    sqlHelp1 += ",cgr_nameGr4 ";
                    sqlHelp2 += ", " + "'" + cb4.Text + "'";
                }
                sqlHelp1 += ") ";
                sqlHelp2 += ")";

               // string sql = String.Format("INSERT INTO CommonGroups (cgr_info ,cgr_nameGr1, cgr_nameGr2, cgr_nameGr3, cgr_nameGr4)" +
               //                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                //  tbCgrInfo.Text, cb1.Text, cb2.Text, cb3.Text, cb4.Text);
                string sql = sqlHelp1 + sqlHelp2;
                MessageBox.Show(sql);
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
