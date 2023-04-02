using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace MyDiplomProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e) // Назад
        {
            Form1 NewForm = new Form1();
            this.Hide();
            NewForm.Show();
        }
        private void button1_Click(object sender, EventArgs e) // Папка
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials"));
        }
        private void button2_Click(object sender, EventArgs e) // Инструкция КИПА
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials\\№ 12 ИНСТРУКЦИЯ по охране труда для слесаря  КИП и А.docx"));
        }
        private void button3_Click(object sender, EventArgs e) // Приложение ОТ
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials\\Положение оо ОТДЕЛЕ ОХРАНЫ ТРУДА И ЭКОЛОГИИ - 2017    ОБРАЗЕЦ 2017  (1).doc"));
        }
        private void button4_Click(object sender, EventArgs e) // Часть 1 Экзамен
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials\\Гос 1.docx"));
        }
        private void button5_Click(object sender, EventArgs e) // Часть 2 Экзамен
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials\\гос 2.docx"));
        }
        private void button6_Click(object sender, EventArgs e) // Часть 3 Экзамен
        {
            Process.Start(Path.Combine(Application.StartupPath, "Materials\\гос 3.docx"));
        }
        private void button7_Click(object sender, EventArgs e) // Spravochnick
        {
            Process.Start(Path.Combine(Application.StartupPath, @"Materials\\Spravochnick.chm"));
        }
    }
}
