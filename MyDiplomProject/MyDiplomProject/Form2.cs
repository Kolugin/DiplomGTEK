using System;
using System.Windows.Forms;

namespace MyDiplomProject
{
    public partial class Form2 : Form
    {
        private string Fam;
        private string Namee;
        private string SurName;
        private string Spec;
        private string Otdel;
        private string Daytest;
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // Назад
        {
            Form1 NewForm = new Form1();
            this.Close();
            NewForm.Show();
        }
        private void button2_Click(object sender, EventArgs e) // Далее переход на форму выбора теста
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Одно из полей для заполнения пустое. заполните все поля", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Fam = textBox1.Text;
                Namee = textBox2.Text;
                SurName = textBox3.Text;
                Spec = textBox4.Text;
                Otdel = textBox5.Text;
                Daytest = textBox6.Text;
                Form3 NewForm = new Form3(Fam, Namee, SurName, Spec, Otdel, Daytest) ;
                this.Close();
                NewForm.Show();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            textBox6.Text = Convert.ToString(date.ToShortDateString());
        }
    }
}
