using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace MyDiplomProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        List<string> Result = new List<string>();
        string a = "";
        int PAns = 0;
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                Result.Clear();
                OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                dbCon.Open();
                using (dbCon)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT Registry.Family, Registry.Namee, Registry.SurName, Registry.Speciality, Registry.Otdel, Registry.DataTest, Registry.NameTest, Registry.TypeTest FROM Registry;", dbCon);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Result.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6) + " " + reader.GetString(7));
                    }
                }
                foreach (string item in Result)
                {
                    if (comboBox1.Items.Contains(item))
                    {

                    }
                    else
                    {
                        comboBox1.Items.Add(item);
                    }
                }
                dbCon.Close();
            }
            catch
            {
                MessageBox.Show("Просмотр результатов невозможен, так как их нету в таблице с результатами. Проведите хотя бы 1 тест либо экзамен.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1 NewForm = new Form1();
                this.Close();
                NewForm.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e) // Назад
        {
            comboBox1.Items.Clear();
            Form1 NewForm = new Form1();
            this.Close();
            NewForm.Show();   
        }
        private void button1_Click(object sender, EventArgs e) // Просмотр результатов
        {
            a = comboBox1.Text;
            String[] words = a.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            if (comboBox1.SelectedIndex != -1)
            {
                dbCon.Open();
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(@"SELECT Registry.Quest, Registry.ChtoOtvetil, Registry.PravOtvet FROM Registry WHERE (((Registry.Family)='" + words[0] + "') AND ((Registry.Namee)='" + words[1] + "') AND ((Registry.SurName)='" + words[2] + "') AND ((Registry.Speciality)='" + words[3] + "') AND ((Registry.Otdel)='" + words[4] + "') AND ((Registry.DataTest)='" + words[5] + "') AND ((Registry.NameTest)='" + words[6] + "') AND ((Registry.TypeTest)='" + words[7] + "'))", dbCon);
                DataTable dataTable = new DataTable();
                dbAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Вопрос";
                dataGridView1.Columns[1].HeaderText = "Что ответил";
                dataGridView1.Columns[2].HeaderText = "Правильный ответ";
                dbCon.Close();
                int rows = dataGridView1.Rows.Count;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (Convert.ToString(dataGridView1.Rows[j].Cells[1].Value) != Convert.ToString(dataGridView1.Rows[j].Cells[2].Value))
                    {
                        dataGridView1.Rows[j].Cells[1].Style.BackColor = Color.Red;
                        dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[j].Cells[1].Style.BackColor = Color.Green;
                        dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.Green;
                        PAns++;
                    }
                    if (Convert.ToString(dataGridView1.Rows[j].Cells[1].Value) == "" && Convert.ToString(dataGridView1.Rows[j].Cells[2].Value) == "")
                    {
                        dataGridView1.Rows[j].Cells[1].Style.BackColor = Color.White;
                        dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.White;
                        PAns--;
                    }
                }
                if (PAns < rows / 2)
                {
                    MessageBox.Show("Данный тест был пройден на неудовлетворительную оценку. Количество правильных ответов меньше половины от общего числа вопросов", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (PAns >= rows / 2)
                {
                    MessageBox.Show("Данный тест был пройден на удовлетворительную оценку. Количество правильных ответов больше либо равно половине от общего числа вопросов", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран результат для просмотра результатов.");
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
