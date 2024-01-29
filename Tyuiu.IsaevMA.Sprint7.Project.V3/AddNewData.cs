using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Tyuiu.IsaevMA.Sprint7.Project.V3.Lib;

namespace Tyuiu.IsaevMA.Sprint7.Project.V3
{
    public partial class AddNewData : Form
    {
        public AddNewData()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path1 = @"..\DataSprint7\Teacher.csv";
        string path2 = @"..\DataSprint7\Classroom.csv";
        string path3 = @"..\DataSprint7\Department.csv";
        string path4 = @"..\DataSprint7\Lesson.csv";


        //Кнопка "Преподаватель" *****************************************************************************************************************
        private void AddNewData_Load(object sender, EventArgs e)
        {
            int x = 1 + ds.GetCountRows(path1);
            textBoxIDTeach_DDA.Text = Convert.ToString(x);
        }
        private void textBoxFIOTeach_KDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!IsValidInput(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxFIOTeach_DDA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFIOTeach_DDA.Text.Length == 2 || textBoxFIOTeach_DDA.Text.Length == 4 || textBoxFIOTeach_DDA.Text.Length == 6)
            {
                if (textBoxFIOTeach_DDA.Text.Last() != '.')
                {
                    textBoxFIOTeach_DDA.Text = textBoxFIOTeach_DDA.Text.Insert(textBoxFIOTeach_DDA.Text.Length - 1, ".");
                    textBoxFIOTeach_DDA.SelectionStart = textBoxFIOTeach_DDA.Text.Length;
                }
            }
        }
        private bool IsValidInput(char inputChar)
        {
            return Char.IsLetter(inputChar) || inputChar == '.';
        }

        private void buttonAddNewTeach_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDTeach_DDA.Text=="" || textBoxFIOTeach_DDA.Text == "" || textBoxFIOTeach_DDA.Text.Length != 5 || textBoxNumberTeach_DDA.Text == "" || textBoxWorkTeach_DDA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(textBoxIDTeach_DDA.Text == "")
                    {
                        MessageBox.Show("ID пуст! Пожалуйста перезайдите на страницу \"Преподаватели\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDTeach_DDA.Text}", $"{textBoxFIOTeach_DDA.Text}", $"{textBoxNumberTeach_DDA.Text}",
                    $"{textBoxWorkTeach_DDA.Text}"};
                    bool completed = ds.AddNewData(path1, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxFIOTeach_DDA.Clear();
                    textBoxNumberTeach_DDA.Clear();
                    textBoxWorkTeach_DDA.Clear();
                    textBoxIDTeach_DDA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadTeacher_DDA_Click(object sender, EventArgs e)
        {
            int x = 1 + ds.GetCountRows(path1);
            textBoxIDTeach_DDA.Text = Convert.ToString(x);
            groupBoxTeach_DDA.Visible = true;
            groupBoxAudi_DDA.Visible = false;
            groupBoxPred_DDA.Visible = false;
            groupBoxKaf_DDA.Visible = false;
        }

        //Кнопка "Аудитории" *****************************************************************************************************************
        private void buttonLoadClass_DDA_Click(object sender, EventArgs e)
        {
            groupBoxPred_DDA.Visible = false;
            groupBoxKaf_DDA.Visible = false;
            groupBoxTeach_DDA.Visible = false;
            groupBoxAudi_DDA.Visible = true;
            int x = 1 + ds.GetCountRows(path2);
            textBoxIDAudi_DDA.Text = Convert.ToString(x);
        }
        private void buttonAddAudi_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDAudi_DDA.Text == "" || textBoxNumAudi_DDA.Text == "" || textBoxNameAudi_DDA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDAudi_DDA.Text == "")
                    {
                        MessageBox.Show("ID пуст, Пожалуйста перезайдите на страницу \"Аудитории\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDAudi_DDA.Text}", $"{textBoxNumAudi_DDA.Text}", $"{textBoxNameAudi_DDA.Text}"};
                    bool completed = ds.AddNewData(path2, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxNumAudi_DDA.Clear();
                    textBoxNameAudi_DDA.Clear();
                    textBoxIDAudi_DDA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка "Кафедры" *******************************************************************************************************************
        private void buttonLoadDepartment_DDA_Click(object sender, EventArgs e)
        {
            groupBoxTeach_DDA.Visible = false;
            groupBoxAudi_DDA.Visible = false;
            groupBoxKaf_DDA.Visible = true;
            groupBoxPred_DDA.Visible = false;
            int x = 1 + ds.GetCountRows(path3);
            textBoxIDKaf_DDA.Text = Convert.ToString(x);
        }
        private void buttonAddKaf_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDKaf_DDA.Text == "" || textBoxNumZKaf_DDA.Text == "" || textBoxNameKaf_DDA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDKaf_DDA.Text == "")
                    {
                        MessageBox.Show("ID пуст, Пожалуйста перезайдите на страницу \"Кафедры\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDKaf_DDA.Text}", $"{textBoxNumZKaf_DDA.Text}", $"{textBoxNameKaf_DDA.Text}" };
                    bool completed = ds.AddNewData(path3, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxIDKaf_DDA.Clear();
                    textBoxNumZKaf_DDA.Clear();
                    textBoxNameKaf_DDA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Кнопка "Предметы" ******************************************************************************************************************
        private void buttonLoadLesson_DDA_Click(object sender, EventArgs e)
        {
            groupBoxTeach_DDA.Visible = false;
            groupBoxAudi_DDA.Visible = false;
            groupBoxKaf_DDA.Visible = false;
            groupBoxPred_DDA.Visible = true;
            int x = 1 + ds.GetCountRows(path4);
            textBoxIDPred_DDA.Text = Convert.ToString(x);
        }
        private void buttonAddPred_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDPred_DDA.Text == "" || textBoxNamePred_DDA.Text == "" || textBoxKolPred_DDA.Text == "" 
                    || textBoxClassPred_DDA.Text == "" || 
                    textBoxTypePred_DDA.Text == "" || textBoxTypePred_DDA.Text != "Экзамен" && textBoxTypePred_DDA.Text != "Зачет")
                {
                    MessageBox.Show("Вы не заполнили все данные или допустили ошибку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDPred_DDA.Text == "")
                    {
                        MessageBox.Show("ID пуст! Пожалуйста перезайдите на страницу \"Предметы\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxTypePred_DDA.Text != "" && (textBoxTypePred_DDA.Text != "Экзамен" || textBoxTypePred_DDA.Text != "Зачет"))
                    {
                        MessageBox.Show("В поле \"Тип контроля\" вы допустили ошибку, Тип контроля может быть лишь: \"Экзамен\" или \"Зачет\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDPred_DDA.Text}", $"{textBoxNamePred_DDA.Text}", 
                        $"{textBoxKolPred_DDA.Text}", $"{textBoxTypePred_DDA.Text}", $"{textBoxClassPred_DDA.Text}" };
                    bool completed = ds.AddNewData(path4, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxIDPred_DDA.Clear();
                    textBoxNamePred_DDA.Clear();
                    textBoxKolPred_DDA.Clear();
                    textBoxTypePred_DDA.Clear();
                    textBoxClassPred_DDA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Другие функции *********************************************************************************************************************
     
        private void buttonManagement_DDA_Click(object sender, EventArgs e)
        {
            Management manag = new Management();
            manag.ShowDialog();
        }
        private void textBoxKolPred_DDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxCyrillic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void groupBoxPred_DDA_Enter(object sender, EventArgs e)
        {

        }
    }

}
