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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath = @"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7"; 
        string path1 = @"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7\Teacher.csv";
        string path2 = @"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7\Classroom.csv";
        string path3 = @"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7\Department.csv";
        string path4 = @"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin.\DataSprint7\Lesson.csv";
        
        DataService ds = new DataService();

        private void dataGridViewOut_DDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //Пространство "Преподавателии"********************************************************************************
        private void buttonLoadTeacher_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path1);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_DDA.RowCount = rows;
                dataGridViewOut_DDA.ColumnCount = columns;

                dataGridViewOut_DDA.Columns[0].HeaderText = "ID";
                dataGridViewOut_DDA.Columns[1].HeaderText = "ФИО преподавателя";
                dataGridViewOut_DDA.Columns[2].HeaderText = "Номер преподавателя";
                dataGridViewOut_DDA.Columns[3].HeaderText = "Должность преподавателя";


                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_DDA.Columns[i].Width = 160;
                    dataGridViewOut_DDA.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_DDA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonRed_DDA.Visible = true;
            buttonChekFileTeacher_DDA.Visible = true;
            buttonKol_DDA.Visible = true;
            groupBoxFunc_DDA.Visible = true;
            groupBoxKolPre_DDA.Visible = false;
            groupBoxRed_DDA.Visible = true;
            buttonAddTeach_DDA.Visible = true;
            buttonSaveTeachers_DDA.Visible = false;
            panelLeftAudi_DDA.Visible = false;
            buttonRed_DDA.Visible = true;
            buttonSaveTeachers_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonCansel_DDA.Visible = false;
            panelLeftPred_DDA.Visible = false;
        }

        private void buttonOpenFile_DDA_Click(object sender, EventArgs e)
        {
            string[] PathCsv = Directory.GetFiles(openFilePath, "*.csv");

            if (PathCsv.Length > 0)
            {
                Process.Start("explorer.exe", openFilePath);
            }
            else
            {
                MessageBox.Show("В выбранной папке нет файлов с расширением .csv", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonChekFileTeacher_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path1;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveTeachers_DDA_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();

            for (int i = 0; i < dataGridViewOut_DDA.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_DDA.ColumnCount];

                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_DDA.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке,  удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_DDA.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path1, data);

            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            buttonLoadTeacher_DDA.PerformClick();
            buttonRed_DDA.Visible = true;
            buttonSaveTeachers_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonCansel_DDA.Visible = false;
        }
        private void buttonRed_DDA_Click(object sender, EventArgs e)
        {
            dataGridViewOut_DDA.ReadOnly = false;
            buttonSaveTeachers_DDA.Visible = true;
            buttonRed_DDA.Visible = false;
            buttonCansel_DDA.Visible = true; ;
        }
        private void buttonCansel_DDA_Click(object sender, EventArgs e)
        {
            buttonRed_DDA.Visible = true;
            buttonSaveTeachers_DDA.Visible = false;
            buttonCansel_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonLoadTeacher_DDA.PerformClick();
        }
        private void buttonSumTeacher_DDA_Click(object sender, EventArgs e)
        {
            int rows = ds.GetCountRows(path1);

            textBoxSum_DDA.Text = Convert.ToString(rows);
        }
        private void buttonKol_DDA_Click(object sender, EventArgs e)
        {
            groupBoxKolTeach_DDA.Visible = true;
            buttonSumTeacher_DDA.Visible = true;
            textBoxSum_DDA.Visible = true;
        }
        private void buttonAddTeach_DDA_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }

        //Пространство "Аудитория"********************************************************************************
        private void buttonLoadClass_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path2);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_DDA.RowCount = rows;
                dataGridViewOut_DDA.ColumnCount = columns;

                dataGridViewOut_DDA.Columns[0].HeaderText = "ID";
                dataGridViewOut_DDA.Columns[1].HeaderText = "Номер аудитории";
                dataGridViewOut_DDA.Columns[2].HeaderText = "Назавание аудитории";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_DDA.Columns[i].Width = 160;
                    dataGridViewOut_DDA.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_DDA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelLeftKaf_DDA.Visible = false;
            panelLeftAudi_DDA.Visible = true;
            panelLeftPred_DDA.Visible = false;
            groupBoxKolPre_DDA.Visible = false;
            groupBoxKolTeach_DDA.Visible = false;
        }
        private void buttonChekFileAudi_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path2;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveAudi_DDA_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_DDA.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_DDA.ColumnCount];

                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_DDA.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_DDA.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path2, data);

            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadClass_DDA.PerformClick();
            buttonRedAudi_DDA.Visible = true;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonCansaleAudi_DDA.Visible = false;
            buttonSaveAudi_DDA.Visible = false;
        }
        private void buttonRedAudi_KDR_Click(object sender, EventArgs e)
        {
            buttonRedAudi_DDA.Visible = false;
            buttonSaveAudi_DDA.Visible = true;
            dataGridViewOut_DDA.ReadOnly = false;
            buttonCansaleAudi_DDA.Visible = true;
            buttonLoadClass_DDA.PerformClick();
        }
        private void buttonAddAudi_KDR_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }
        private void buttonCansaleAudi_KDR_Click(object sender, EventArgs e)
        {
            buttonRedAudi_DDA.Visible = true;
            buttonSaveAudi_DDA.Visible = false;
            buttonCansaleAudi_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonLoadClass_DDA.PerformClick();
        }

        //Пространство "Кафедры"********************************************************************************
        private void buttonLoadDepartment_KDR_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path3);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_DDA.RowCount = rows;
                dataGridViewOut_DDA.ColumnCount = columns;

                dataGridViewOut_DDA.Columns[0].HeaderText = "ID";
                dataGridViewOut_DDA.Columns[1].HeaderText = "Название кафедры";
                dataGridViewOut_DDA.Columns[2].HeaderText = "Номер зав. кафедры";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_DDA.Columns[i].Width = 160;
                    dataGridViewOut_DDA.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_DDA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelLeftKaf_DDA.Visible = true;
            panelLeftAudi_DDA.Visible = true;
            panelLeftPred_DDA.Visible = false;
            groupBoxKolPre_DDA.Visible = false;
            groupBoxKolTeach_DDA.Visible = false;
        }
        private void buttonChekFileKaf_DDA_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path3;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRedKaf_DDA_Click(object sender, EventArgs e)
        {
            buttonRedKaf_DDA.Visible = false;
            buttonSaveKaf_DDA.Visible = true;
            dataGridViewOut_DDA.ReadOnly = false;
            buttonCansaleKaf_DDA.Visible = true;
            buttonLoadDepartment_DDA.PerformClick();
        }
        private void buttonSaveKaf_DDA_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_DDA.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_DDA.ColumnCount];
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_DDA.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_DDA.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path3, data);
            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadDepartment_DDA.PerformClick();
            buttonRedKaf_DDA.Visible = true;
            buttonSaveKaf_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonCansaleKaf_DDA.Visible = false;
        }
        private void buttonCansaleKaf_DDA_Click(object sender, EventArgs e)
        {
            buttonRedKaf_DDA.Visible = true;
            buttonSaveKaf_DDA.Visible = false;
            buttonCansaleKaf_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonLoadDepartment_DDA.PerformClick();
        }
        private void buttonAddKaf_DDA_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }

        //Пространство "Предметы"********************************************************************************
        private void buttonLoadLesson_KDR_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_DDA.Visible = false;
            groupBoxKolTeach_DDA.Visible = false;
            panelLeftButton_DDA.Visible = true;
            panelLeftAudi_DDA.Visible = true;
            panelLeftKaf_DDA.Visible = true;
            panelLeftPred_DDA.Visible = true;

            try
            {
                string[,] DataMatrix = ds.GetData(path4);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_DDA.RowCount = rows;
                dataGridViewOut_DDA.ColumnCount = columns;

                dataGridViewOut_DDA.Columns[0].HeaderText = "ID";
                dataGridViewOut_DDA.Columns[1].HeaderText = "Название предмета";
                dataGridViewOut_DDA.Columns[2].HeaderText = "Кол-во часов за семестр";
                dataGridViewOut_DDA.Columns[3].HeaderText = "Тип контроля";
                dataGridViewOut_DDA.Columns[4].HeaderText = "Раздел предмета";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_DDA.Columns[i].Width = 160;
                    dataGridViewOut_DDA.Columns[0].Width = 40;
                    dataGridViewOut_DDA.Columns[2].Width = 100;
                    dataGridViewOut_DDA.Columns[3].Width = 100;
                    dataGridViewOut_DDA.Columns[4].Width = 100;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_DDA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonFuncPred_DDA_Click(object sender, EventArgs e)
        {
            panelBottom_DDA.Visible = true;
            groupBoxKolTeach_DDA.Visible = true;
            groupBoxKolPre_DDA.Visible = true;
            textBoxKolPred_DDA.Visible = true;
            buttonSumPred_DDA.Visible = true;
            groupBoxKolPre_DDA.Text = "Общее количество учебных часов в семестре:";
            textBoxKolPred_DDA.Text = "";
        }
        private void buttonRedPred_DDA_Click(object sender, EventArgs e)
        {
            buttonRedPred_DDA.Visible = false;
            buttonSavePred_DDA.Visible = true;
            dataGridViewOut_DDA.ReadOnly = false;
            buttonCansalePred_DDA.Visible = true;
            buttonLoadLesson_DDA.PerformClick();
        }
        private void buttonSavePred_DDA_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_DDA.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_DDA.ColumnCount];
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_DDA.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_DDA.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_DDA.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path4, data);
            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadLesson_DDA.PerformClick();
            buttonRedPred_DDA.Visible = true;
            buttonSavePred_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonCansalePred_DDA.Visible = false;
        }
        private void buttonChekFilePred_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path4;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddPred_DDA_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }
        private void buttonCansalePred_DDA_Click(object sender, EventArgs e)
        {
            buttonRedPred_DDA.Visible = true;
            buttonSavePred_DDA.Visible = false;
            buttonCansalePred_DDA.Visible = false;
            dataGridViewOut_DDA.ReadOnly = true;
            buttonLoadLesson_DDA.PerformClick();
        }
        private void buttonSumPred_DDA_Click(object sender, EventArgs e)
        {
            if (groupBoxKolPre_DDA.Text == "Общее количество учебных часов в семестре:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                double sum = 0;
                for (int i = 0; i < res.Length; i++)
                {
                    sum += res[i];
                }
                textBoxKolPred_DDA.Text = Convert.ToString(sum);
            }
            if (groupBoxKolPre_DDA.Text == "Минимальное количество часов по предмету:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                int min = ds.MinValue(res);
                textBoxKolPred_DDA.Text = Convert.ToString(min);
            }
            if (groupBoxKolPre_DDA.Text == "Максимальное количество часов по предмету:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                int max = ds.MaxValue(res);
                textBoxKolPred_DDA.Text = Convert.ToString(max);
            }
        }

        private void buttonMinPred_DDA_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_DDA.Text = "Минимальное количество часов по предмету:";
            textBoxKolPred_DDA.Text = "";
            panelBottom_DDA.Visible = true;
            groupBoxKolTeach_DDA.Visible = true;
            groupBoxKolPre_DDA.Visible = true;
            textBoxKolPred_DDA.Visible = true;
            buttonSumPred_DDA.Visible = true;
        }
        private void buttonMaxPred_DDA_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_DDA.Text = "Максимальное количество часов по предмету:";
            textBoxKolPred_DDA.Text = "";
            panelBottom_DDA.Visible = true;
            groupBoxKolTeach_DDA.Visible = true;
            groupBoxKolPre_DDA.Visible = true;
            textBoxKolPred_DDA.Visible = true;
            buttonSumPred_DDA.Visible = true;
        }
        private void buttonGraphTech_DDA_Click(object sender, EventArgs e)
        {
            Func func = new Func();
            func.ShowDialog();
        }


        private void buttonManagement_DDA_Click(object sender, EventArgs e)
        {
            Management manag = new Management();
            manag.ShowDialog();
        }

            private void buttonInfo_DDA_Click(object sender, EventArgs e)
            {
                Info info = new Info();
                info.ShowDialog();
            }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxKolPre_DDA_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxKolTeach_DDA_Enter(object sender, EventArgs e)
        {

        }
    } 
}