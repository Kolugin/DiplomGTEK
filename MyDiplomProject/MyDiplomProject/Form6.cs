using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace MyDiplomProject
{
    public partial class Form6 : Form
    {
        private string a;
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // Выход из конструктора
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть конструктор?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Form1 NewForm = new Form1();
                this.Close();
                NewForm.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e) // Создание нового теста
        {
            if (textBox1.Text != "")
            {
                try
                {
                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                    dbCon.Open();
                    OleDbCommand com = new OleDbCommand("CREATE TABLE " + textBox1.Text.ToString() + "(TQ INTEGER, Q TEXT, A1 TEXT, A2 TEXT, A3 TEXT, A4 TEXT, A5 TEXT, A6 TEXT, A7 TEXT, A8 TEXT, A9 TEXT, A10 TEXT, PA1 TEXT, PA2 TEXT, PA3 TEXT, PA4 TEXT, PA5 TEXT, KPA INTEGER)", dbCon);
                    com.ExecuteNonQuery();
                    DataTable tbls = dbCon.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
                    comboBox1.Items.Clear();
                    foreach (DataRow row in tbls.Rows)
                    {
                        string TableName = row["TABLE_NAME"].ToString();
                        if (TableName == "Registry")
                        {
                            comboBox1.Items.Add(TableName);
                            comboBox1.Items.Remove("Registry");
                        }
                        else
                        {
                            comboBox1.Items.Add(TableName);
                        }
                    }
                    DataTable dataTable = new DataTable();
                    dataGridView1.DataSource = dataTable;
                    dbCon.Close();
                    MessageBox.Show("Новая таблица для теста успешно создана.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show("Вы пытаетесь присвоить тесту имя которое уже есть. Введите другое название в поле.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы не ввели название для теста. Введите название в поле.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    textBox1.Text = "";
                }
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            dbCon.Open();
            DataTable tbls = dbCon.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
            foreach (DataRow row in tbls.Rows)
            {
                string TableName = row["TABLE_NAME"].ToString();
                if (TableName == "Registry")
                {
                    comboBox1.Items.Add(TableName);
                    comboBox1.Items.Remove("Registry");
                }
                else
                {
                    comboBox1.Items.Add(TableName);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) // редактирование теста
        {
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            dbCon.Open();
            if (comboBox1.SelectedIndex != -1)
            {
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(@"SELECT * FROM " + comboBox1.SelectedItem, dbCon);
                DataTable dataTable = new DataTable();
                dbAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.CurrentCell = null;
                dataGridView1.Columns[0].HeaderText = "Тип вопроса (1, 2 или 3)";
                dataGridView1.Columns[1].HeaderText = "Текст вопроса";
                dataGridView1.Columns[2].HeaderText = "Вариант ответа 1";
                dataGridView1.Columns[3].HeaderText = "Вариант ответа 2";
                dataGridView1.Columns[4].HeaderText = "Вариант ответа 3";
                dataGridView1.Columns[5].HeaderText = "Вариант ответа 4";
                dataGridView1.Columns[6].HeaderText = "Вариант ответа 5";
                dataGridView1.Columns[7].HeaderText = "Вариант ответа 6";
                dataGridView1.Columns[8].HeaderText = "Вариант ответа 7";
                dataGridView1.Columns[9].HeaderText = "Вариант ответа 8";
                dataGridView1.Columns[10].HeaderText = "Вариант ответа 9";
                dataGridView1.Columns[11].HeaderText = "Вариант ответа 10";
                dataGridView1.Columns[12].HeaderText = "Вариант верного ответа 1";
                dataGridView1.Columns[13].HeaderText = "Вариант верного ответа 2";
                dataGridView1.Columns[14].HeaderText = "Вариант верного ответа 3";
                dataGridView1.Columns[15].HeaderText = "Вариант верного ответа 4";
                dataGridView1.Columns[16].HeaderText = "Вариант верного ответа 5";
                dataGridView1.Columns[17].HeaderText = "Количество верных ответов (от 1 до 5)";
                dbCon.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали тест для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void button8_Click(object sender, EventArgs e) // сохранение изменений
        {
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            dbCon.Open();
            if (comboBox1.SelectedIndex != -1)
            {
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
                DataTable dataTable = new DataTable();
                dbAdapter.Update(dataTable);
                dbCon.Close();
                MessageBox.Show("Внесенные изменения сохраненыю", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы не выбрали тест для сохранения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button7_Click(object sender, EventArgs e) // удаление вопроса в тесте
        {
            var Index = -1;
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            dbCon.Open();
            if (comboBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную строку с вопросом в тесте?.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes && dataGridView1.CurrentRow != null)
                {
                    Index = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[Index]);
                    OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
                    DataTable dataTable = new DataTable();
                    dbAdapter.Update(dataTable);
                    dataGridView1.CurrentCell = null;
                    dbCon.Close();
                    MessageBox.Show("Внесенные изменения сохраненыю", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали для удаления строку.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentCell = null;
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали таблицу с тестом для удаления строки из нее.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button6_Click(object sender, EventArgs e) // добавление вопроса
        {
            if (comboBox1.SelectedIndex != -1)
            {
                a = comboBox1.Text;
                Form5 NewForm = new Form5(a);
                NewForm.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали таблицу с тестом для добавления вопроса. Выберите таблицу из списка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
