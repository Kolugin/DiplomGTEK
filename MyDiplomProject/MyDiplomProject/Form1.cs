using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace MyDiplomProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Обучение
        {
            Form4 NewForm = new Form4();
            this.Hide();
            NewForm.Show();
        }
        private void button2_Click(object sender, EventArgs e) // Переход на форму регистрации
        {
            Form2 NewForm = new Form2();
            this.Hide();
            NewForm.Show();
        }
        private void button8_Click(object sender, EventArgs e) // Выход
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button7_Click(object sender, EventArgs e) // Об Авторе
        {
            MessageBox.Show("Автор данного дипломного проекта учащийся группы Г-41 Гомельского Торгово-Экономического Колледжа Белкоопсоюза Чиж Никита Владимирович. Все права защищены. 2020 год.", "Об Авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e) // Конструктор тестов
        {
            Form6 NewForm = new Form6();
            this.Hide();
            NewForm.Show();
        }
        private void button4_Click(object sender, EventArgs e) // Просмотр результатов
        {
            Form7 NewForm = new Form7();
            this.Hide();
            NewForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath, @"Materials\\Spravka.chm"));
        }
    }
}
