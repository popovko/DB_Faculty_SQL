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
    public partial class MainForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-V0OV6R9;Initial Catalog=Faculty;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
            // Заполняем комбо бокс
            string[] masTables = { "Студенти", "Викладачі", "Предмети", "Групи", "Кафедри", "Пари", "Спільні групи"};
            cbTables.Items.AddRange(masTables);


        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM " + Helper.Translate( cbTables.Text);

            // Соединяемся с сервером
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            // Создаем объект Dataset
            DataSet ds = new DataSet();

            // Заполняем Dataset
            adapter.Fill(ds);
            // Отображаем данные
            dgv.DataSource = ds.Tables[0];     
            if(cbTables.Text == "Студенти" || cbTables.Text == "Викладачі" || cbTables.Text == "Спільні групи")
            {
                dgv.Columns[0].Visible = false;
            }
            if(cbTables.Text == "Пари")
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[4].Visible = false;
                dgv.Columns[5].Visible = false;
                dgv.Columns[6].Visible = false;
            }
            if(cbTables.Text == "Групи")
            {
                dgv.Columns[2].Visible = false;
                dgv.Columns[3].Visible = false;
            }
            if(cbTables.Text == "Кафедри")
            {
                //dgv.Columns[1].Visible = false;
            }
            for(int i=0;i<dgv.ColumnCount; i++)
            {
                dgv.Columns[i].HeaderText = Helper.TableColumnTranslate(dgv.Columns[i].HeaderText);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            switch(cbTables.Text)
            {
                case "": MessageBox.Show("Choise the table"); return;
                case "Студенти":  FormAddStudent formAddStudent = new FormAddStudent();
                        formAddStudent.Show(); break;
                case "Викладачі": FormAddTeacher formAddTeacher = new FormAddTeacher();
                    formAddTeacher.Show(); break;
                case "Предмети": FormAddSubject formAddSubject = new FormAddSubject();
                    formAddSubject.Show(); break;
                case "Групи": FormAddGroup formAddGroup = new FormAddGroup();
                    formAddGroup.Show(); break;
                case "Спільні групи": FormAddCommonGroups formAddCommonGroups = new FormAddCommonGroups();
                    formAddCommonGroups.Show(); break;
                case "Пари": FormAddLesson formAddLesson = new FormAddLesson();
                    formAddLesson.Show(); break;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv.SelectedCells.Count!=1)
                {
                    MessageBox.Show("Choose only 1 cell");
                    return;
                }
                else
                {
                    string sql = "DELETE FROM " + Helper.Translate(cbTables.Text) + " WHERE " + dgv.Columns[0].HeaderCell.Value.ToString() + "= '" +
                                  dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearchStudent formSearchStudent = new FormSearchStudent();
            formSearchStudent.Show();
        }

        private void btnChangeLeader_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange();
            formChange.Show();
        }
    }
}
