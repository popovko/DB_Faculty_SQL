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
    public partial class FormAddLesson : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";

        public FormAddLesson()
        {
            InitializeComponent();
            string sqlTchName = "SELECT tc_name FROM Teachers";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlTchName, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbLsnTch1.Items.Add(reader.GetValue(0));
                cbLsnTch2.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            string sqlCgrInfo = "SELECT cgr_info FROM CommonGroups";
            command = new SqlCommand(sqlCgrInfo, connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                cbLsnCGInfo.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            string sqlSubName = "SELECT sb_name FROM Subject";
            command = new SqlCommand(sqlSubName, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbSbName.Items.Add(reader.GetValue(0));
            }

            string[] DOW = new string[5] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            cbDOW.Items.AddRange(DOW);

            string[] NumLsn = new string[4] { "1", "2", "3", "4" };
            cbNumLs.Items.AddRange(NumLsn);
            reader.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string sqlInsert = "INSERT INTO Lesson( ls_nameSB";
                string sqlValue = " VALUES( ";
               // string sqlWhere = "CASE WHEN ";
                sqlValue += "'" + cbSbName.Text + "' ";
                if(tbLsnRoom1.Text!="")
                {
                    sqlInsert += ", ls_aud ";
                    sqlValue += ", " + "'" + tbLsnRoom1.Text+ "'";
                }
                if (tbLsnRoom2.Text != "")
                {
                    sqlInsert += ", ls_aud2 ";
                    sqlValue += ", " + "'" + tbLsnRoom2.Text + "'";
                }
                if (cbLsnTch1.Text != "")
                {
                    sqlInsert += ", ls_IDtc ";
                    string sqlTcID = "SELECT tc_ID FROM Teachers WHERE tc_name = '" + cbLsnTch1.Text + "'";
                    SqlCommand commandGetTcID = new SqlCommand(sqlTcID, connection);
                    SqlDataReader reader = commandGetTcID.ExecuteReader();
                    reader.Read();
                    string tcID = reader.GetValue(0).ToString();
                    sqlValue += ", " + tcID ;
                    reader.Close();
                    //sqlWhere += "tcID = (SELECT tc_ID FROM Teachers WHERE tc_name = '" + cbLsnTch1.Text + "') AND ";
                }
                if (cbLsnTch2.Text != "")
                {
                    sqlInsert += ", ls_IDtc2 ";
                    string sqlTcID = "SELECT tc_ID FROM Teachers WHERE tc_name = '" + cbLsnTch2.Text + "'";
                    SqlCommand commandGetTcID = new SqlCommand(sqlTcID, connection);
                    SqlDataReader reader = commandGetTcID.ExecuteReader();
                    reader.Read();
                    string tcID2 = reader.GetValue(0).ToString();
                    sqlValue += ", "  + tcID2 ;
                    reader.Close();
                    //  sqlWhere += "tcID2 = (SELECT tc_ID FROM Teachers WHERE tc_name =' " + cbLsnTch1.Text + "') AND ";
                }

                sqlInsert += ",ls_IDcGr, ls_DOW, ls_numLs)";

                string sqlCgrID = "SELECT cgr_ID FROM CommonGroups WHERE cgr_info = '" + cbLsnCGInfo.Text + "'";
                SqlCommand commandGetCgrID = new SqlCommand(sqlCgrID, connection);
                SqlDataReader readerCgr = commandGetCgrID.ExecuteReader();
                readerCgr.Read();
                string CgrID = readerCgr.GetValue(0).ToString();
                readerCgr.Close();

                sqlValue += ", " + CgrID + ", '" + cbDOW.Text +"', '"+ cbNumLs.Text +"')";
                //sqlWhere += "cgrID = (SELECT cgr_ID FROM CommonGroups WHERE cgr_info = '" + cbLsnCGInfo.Text + "')";
                string sql = sqlInsert + sqlValue;
                MessageBox.Show(sql);

                
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
