using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace MyDiplomProject
{
    public partial class Form5 : Form
    {
        public Form5(string a)
        {
            InitializeComponent();
            this.a = a;
        }
        public string a;
        private void button1_Click(object sender, EventArgs e) // добавление вопроса
        {
            if (textBox1.Text == "1" || textBox1.Text == "2" || textBox1.Text == "3")
            {
                if (textBox3.Text == "1" || textBox3.Text == "2" || textBox3.Text == "3" || textBox3.Text == "4" || textBox3.Text == "5")
                {

                    if (textBox1.Text == "1" && textBox3.Text != "1")
                    {
                        MessageBox.Show("Вы выбрали 1 тип вопроса и не верно ввели количество правильных ответов. Введите число 1", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox3.Text = "";
                        return;
                    }
                    else
                    {
                        if (textBox1.Text == "3" && textBox3.Text != "1")
                        {
                            MessageBox.Show("Вы выбрали 3 тип вопроса и не верно ввели количество правильных ответов. Введите число 1", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox3.Text = "";
                            return;
                        }
                        else
                        {
                            if (textBox4.Text == "")
                            {
                                MessageBox.Show("Вы не ввели текст вопроса. Введите текст вопроса", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (textBox1.Text == "1")
                                {
                                    if (checkBox1.Checked == true)
                                    {
                                        textBox5.Text = "NULL";
                                    }
                                    if (checkBox2.Checked == true)
                                    {
                                        textBox6.Text = "NULL";
                                    }
                                    if (checkBox3.Checked == true)
                                    {
                                        textBox7.Text = "NULL";
                                    }
                                    if (checkBox4.Checked == true)
                                    {
                                        textBox8.Text = "NULL";
                                    }
                                    if (checkBox5.Checked == true)
                                    {
                                        textBox9.Text = "NULL";
                                    }
                                    if (checkBox6.Checked == true)
                                    {
                                        textBox10.Text = "NULL";
                                    }
                                    if (checkBox7.Checked == true)
                                    {
                                        textBox11.Text = "NULL";
                                    }
                                    if (checkBox8.Checked == true)
                                    {
                                        textBox12.Text = "NULL";
                                    }
                                    if (checkBox9.Checked == true)
                                    {
                                        textBox13.Text = "NULL";
                                    }
                                    if (checkBox10.Checked == true)
                                    {
                                        textBox14.Text = "NULL";
                                    }
                                    if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                    {
                                        if (textBox19.Text != "" && checkBox15.Checked == false)
                                        {
                                            if (checkBox14.Checked == true)
                                            {
                                                textBox18.Text = "NONE";
                                            }
                                            if (checkBox13.Checked == true)
                                            {
                                                textBox17.Text = "NONE";
                                            }
                                            if (checkBox12.Checked == true)
                                            {
                                                textBox16.Text = "NONE";
                                            }
                                            if (checkBox11.Checked == true)
                                            {
                                                textBox15.Text = "NONE";
                                            }
                                            if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                            {
                                                if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                    textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                    textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                    textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                    textBox18.Text != "" && textBox19.Text != "")
                                                {
                                                    if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                    {
                                                        OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                        dbCon.Open();
                                                        using (dbCon)
                                                        {
                                                            string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                            OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                            com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                            com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                            com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                            com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                            com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                            com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                            com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                            com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                            com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                            com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                            com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                            com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                            com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                            com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                            com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                            com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                            com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                            com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                            com.ExecuteNonQuery();
                                                        }
                                                        dbCon.Close();
                                                        MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        if (textBox19.Text == "")
                                        {
                                            MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                        if (checkBox15.Checked == true)
                                        {
                                            MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                if (textBox1.Text == "2")
                                { 
                                    if (textBox3.Text == "1" || textBox3.Text == "2" || textBox3.Text == "3" || textBox3.Text == "4" || textBox3.Text == "5")
                                    {
                                        if (textBox3.Text == "1")
                                        {
                                            if (checkBox1.Checked == true)
                                            {
                                                textBox5.Text = "NULL";
                                            }
                                            if (checkBox2.Checked == true)
                                            {
                                                textBox6.Text = "NULL";
                                            }
                                            if (checkBox3.Checked == true)
                                            {
                                                textBox7.Text = "NULL";
                                            }
                                            if (checkBox4.Checked == true)
                                            {
                                                textBox8.Text = "NULL";
                                            }
                                            if (checkBox5.Checked == true)
                                            {
                                                textBox9.Text = "NULL";
                                            }
                                            if (checkBox6.Checked == true)
                                            {
                                                textBox10.Text = "NULL";
                                            }
                                            if (checkBox7.Checked == true)
                                            {
                                                textBox11.Text = "NULL";
                                            }
                                            if (checkBox8.Checked == true)
                                            {
                                                textBox12.Text = "NULL";
                                            }
                                            if (checkBox9.Checked == true)
                                            {
                                                textBox13.Text = "NULL";
                                            }
                                            if (checkBox10.Checked == true)
                                            {
                                                textBox14.Text = "NULL";
                                            }
                                            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                            {
                                                if (textBox19.Text != "" && checkBox15.Checked == false && textBox19.Text != "NONE")
                                                {
                                                    if (textBox19.Text == textBox5.Text || textBox19.Text == textBox6.Text || textBox19.Text == textBox7.Text ||
                                                        textBox19.Text == textBox8.Text || textBox19.Text == textBox9.Text || textBox19.Text == textBox10.Text ||
                                                        textBox19.Text == textBox11.Text || textBox19.Text == textBox12.Text || textBox19.Text == textBox13.Text ||
                                                        textBox19.Text == textBox14.Text)
                                                    {
                                                        if (checkBox14.Checked == true)
                                                        {
                                                            textBox18.Text = "NONE";
                                                        }
                                                        if (checkBox13.Checked == true)
                                                        {
                                                            textBox17.Text = "NONE";
                                                        }
                                                        if (checkBox12.Checked == true)
                                                        {
                                                            textBox16.Text = "NONE";
                                                        }
                                                        if (checkBox11.Checked == true)
                                                        {
                                                            textBox15.Text = "NONE";
                                                        }
                                                        if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                                        {
                                                            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                                textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                                textBox18.Text != "" && textBox19.Text != "")
                                                            {
                                                                if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                                {
                                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                                    dbCon.Open();
                                                                    using (dbCon)
                                                                    {
                                                                        string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                                        com.ExecuteNonQuery();
                                                                    }
                                                                    dbCon.Close();
                                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.Close();
                                                                    return;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Вы ввели правильный ответ который не соответствует ни одному из вариантов ответа. Воспользуйтесь кнопкой ПРАВ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                if (textBox19.Text == "")
                                                {
                                                    MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (checkBox15.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (textBox19.Text == "NULL" || textBox19.Text == "NONE")
                                                {
                                                    MessageBox.Show("Правильный ответ не может равнятся NONE либо NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    textBox19.Text = "";
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        if (textBox3.Text == "2")
                                        {
                                            if(checkBox1.Checked == true)
                                            {
                                                textBox5.Text = "NULL";
                                            }
                                            if (checkBox2.Checked == true)
                                            {
                                                textBox6.Text = "NULL";
                                            }
                                            if (checkBox3.Checked == true)
                                            {
                                                textBox7.Text = "NULL";
                                            }
                                            if (checkBox4.Checked == true)
                                            {
                                                textBox8.Text = "NULL";
                                            }
                                            if (checkBox5.Checked == true)
                                            {
                                                textBox9.Text = "NULL";
                                            }
                                            if (checkBox6.Checked == true)
                                            {
                                                textBox10.Text = "NULL";
                                            }
                                            if (checkBox7.Checked == true)
                                            {
                                                textBox11.Text = "NULL";
                                            }
                                            if (checkBox8.Checked == true)
                                            {
                                                textBox12.Text = "NULL";
                                            }
                                            if (checkBox9.Checked == true)
                                            {
                                                textBox13.Text = "NULL";
                                            }
                                            if (checkBox10.Checked == true)
                                            {
                                                textBox14.Text = "NULL";
                                            }
                                            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                            {
                                                if ((textBox19.Text != "" && checkBox15.Checked == false && textBox19.Text != "NONE") &&
                                                    textBox18.Text != "" && checkBox14.Checked == false && textBox18.Text != "NONE")
                                                {
                                                    if ((textBox19.Text == textBox5.Text || textBox19.Text == textBox6.Text || textBox19.Text == textBox7.Text ||
                                                        textBox19.Text == textBox8.Text || textBox19.Text == textBox9.Text || textBox19.Text == textBox10.Text ||
                                                        textBox19.Text == textBox11.Text || textBox19.Text == textBox12.Text || textBox19.Text == textBox13.Text ||
                                                        textBox19.Text == textBox14.Text) &&
                                                        (textBox18.Text == textBox5.Text || textBox18.Text == textBox6.Text || textBox18.Text == textBox7.Text ||
                                                        textBox18.Text == textBox8.Text || textBox18.Text == textBox9.Text || textBox18.Text == textBox10.Text ||
                                                        textBox18.Text == textBox11.Text || textBox18.Text == textBox12.Text || textBox18.Text == textBox13.Text ||
                                                        textBox18.Text == textBox14.Text))
                                                    {
                                                        if (checkBox13.Checked == true)
                                                        {
                                                            textBox17.Text = "NONE";
                                                        }
                                                        if (checkBox12.Checked == true)
                                                        {
                                                            textBox16.Text = "NONE";
                                                        }
                                                        if (checkBox11.Checked == true)
                                                        {
                                                            textBox15.Text = "NONE";
                                                        }
                                                        if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                                        {
                                                            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                                textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                                textBox18.Text != "" && textBox19.Text != "")
                                                            {
                                                                if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                                {
                                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                                    dbCon.Open();
                                                                    using (dbCon)
                                                                    {
                                                                        string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                                        com.ExecuteNonQuery();
                                                                    }
                                                                    dbCon.Close();
                                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.Close();
                                                                    return;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Вы ввели правильный ответ который не соответствует ни одному из вариантов ответа. Воспользуйтесь кнопкой ПРАВ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                if (textBox19.Text == "" || textBox18.Text == "")
                                                {
                                                    MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (checkBox15.Checked == true || checkBox14.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if ((textBox19.Text == "NULL" || textBox19.Text == "NONE") || (textBox18.Text == "NULL" || textBox18.Text == "NONE"))
                                                {
                                                    MessageBox.Show("Правильный ответ не может равнятся NONE либо NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    textBox19.Text = ""; textBox18.Text = "";
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        if (textBox3.Text == "3")
                                        {
                                            if(checkBox1.Checked == true)
                                            {
                                                textBox5.Text = "NULL";
                                            }
                                            if (checkBox2.Checked == true)
                                            {
                                                textBox6.Text = "NULL";
                                            }
                                            if (checkBox3.Checked == true)
                                            {
                                                textBox7.Text = "NULL";
                                            }
                                            if (checkBox4.Checked == true)
                                            {
                                                textBox8.Text = "NULL";
                                            }
                                            if (checkBox5.Checked == true)
                                            {
                                                textBox9.Text = "NULL";
                                            }
                                            if (checkBox6.Checked == true)
                                            {
                                                textBox10.Text = "NULL";
                                            }
                                            if (checkBox7.Checked == true)
                                            {
                                                textBox11.Text = "NULL";
                                            }
                                            if (checkBox8.Checked == true)
                                            {
                                                textBox12.Text = "NULL";
                                            }
                                            if (checkBox9.Checked == true)
                                            {
                                                textBox13.Text = "NULL";
                                            }
                                            if (checkBox10.Checked == true)
                                            {
                                                textBox14.Text = "NULL";
                                            }
                                            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                            {
                                                if ((textBox19.Text != "" && checkBox15.Checked == false && textBox19.Text != "NONE") &&
                                                    (textBox18.Text != "" && checkBox14.Checked == false && textBox18.Text != "NONE") &&
                                                    (textBox17.Text != "" && checkBox13.Checked == false && textBox17.Text != "NONE"))
                                                {
                                                    if ((textBox19.Text == textBox5.Text || textBox19.Text == textBox6.Text || textBox19.Text == textBox7.Text ||
                                                        textBox19.Text == textBox8.Text || textBox19.Text == textBox9.Text || textBox19.Text == textBox10.Text ||
                                                        textBox19.Text == textBox11.Text || textBox19.Text == textBox12.Text || textBox19.Text == textBox13.Text ||
                                                        textBox19.Text == textBox14.Text) &&
                                                        (textBox18.Text == textBox5.Text || textBox18.Text == textBox6.Text || textBox18.Text == textBox7.Text ||
                                                        textBox18.Text == textBox8.Text || textBox18.Text == textBox9.Text || textBox18.Text == textBox10.Text ||
                                                        textBox18.Text == textBox11.Text || textBox18.Text == textBox12.Text || textBox18.Text == textBox13.Text ||
                                                        textBox18.Text == textBox14.Text) && 
                                                        (textBox17.Text == textBox5.Text || textBox17.Text == textBox6.Text || textBox17.Text == textBox7.Text ||
                                                        textBox17.Text == textBox8.Text || textBox17.Text == textBox9.Text || textBox17.Text == textBox10.Text ||
                                                        textBox17.Text == textBox11.Text || textBox17.Text == textBox12.Text || textBox17.Text == textBox13.Text ||
                                                        textBox17.Text == textBox14.Text))
                                                    {
                                                        if (checkBox12.Checked == true)
                                                        {
                                                            textBox16.Text = "NONE";
                                                        }
                                                        if (checkBox11.Checked == true)
                                                        {
                                                            textBox15.Text = "NONE";
                                                        }
                                                        if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                                        {
                                                            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                                textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                                textBox18.Text != "" && textBox19.Text != "")
                                                            {
                                                                if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                                {
                                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                                    dbCon.Open();
                                                                    using (dbCon)
                                                                    {
                                                                        string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                                        com.ExecuteNonQuery();
                                                                    }
                                                                    dbCon.Close();
                                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.Close();
                                                                    return;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Вы ввели правильный ответ который не соответствует ни одному из вариантов ответа. Воспользуйтесь кнопкой ПРАВ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                if (textBox19.Text == "" || textBox18.Text == "" || textBox17.Text == "")
                                                {
                                                    MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (checkBox15.Checked == true || checkBox14.Checked == true || checkBox13.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if ((textBox19.Text == "NULL" || textBox19.Text == "NONE") ||
                                                    (textBox18.Text == "NULL" || textBox18.Text == "NONE") ||
                                                    (textBox17.Text == "NULL" || textBox17.Text == "NONE"))
                                                {
                                                    MessageBox.Show("Правильный ответ не может равнятся NONE либо NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    textBox19.Text = ""; textBox18.Text = ""; textBox17.Text = "";
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        if (textBox3.Text == "4")
                                        {
                                            if(checkBox1.Checked == true)
                                            {
                                                textBox5.Text = "NULL";
                                            }
                                            if (checkBox2.Checked == true)
                                            {
                                                textBox6.Text = "NULL";
                                            }
                                            if (checkBox3.Checked == true)
                                            {
                                                textBox7.Text = "NULL";
                                            }
                                            if (checkBox4.Checked == true)
                                            {
                                                textBox8.Text = "NULL";
                                            }
                                            if (checkBox5.Checked == true)
                                            {
                                                textBox9.Text = "NULL";
                                            }
                                            if (checkBox6.Checked == true)
                                            {
                                                textBox10.Text = "NULL";
                                            }
                                            if (checkBox7.Checked == true)
                                            {
                                                textBox11.Text = "NULL";
                                            }
                                            if (checkBox8.Checked == true)
                                            {
                                                textBox12.Text = "NULL";
                                            }
                                            if (checkBox9.Checked == true)
                                            {
                                                textBox13.Text = "NULL";
                                            }
                                            if (checkBox10.Checked == true)
                                            {
                                                textBox14.Text = "NULL";
                                            }
                                            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                            {
                                                if ((textBox19.Text != "" && checkBox15.Checked == false && textBox19.Text != "NONE") &&
                                                    (textBox18.Text != "" && checkBox14.Checked == false && textBox18.Text != "NONE") &&
                                                    (textBox17.Text != "" && checkBox13.Checked == false && textBox17.Text != "NONE") &&
                                                    (textBox16.Text != "" && checkBox12.Checked == false && textBox16.Text != "NONE"))
                                                {
                                                    if ((textBox19.Text == textBox5.Text || textBox19.Text == textBox6.Text || textBox19.Text == textBox7.Text ||
                                                        textBox19.Text == textBox8.Text || textBox19.Text == textBox9.Text || textBox19.Text == textBox10.Text ||
                                                        textBox19.Text == textBox11.Text || textBox19.Text == textBox12.Text || textBox19.Text == textBox13.Text ||
                                                        textBox19.Text == textBox14.Text) &&
                                                        (textBox18.Text == textBox5.Text || textBox18.Text == textBox6.Text || textBox18.Text == textBox7.Text ||
                                                        textBox18.Text == textBox8.Text || textBox18.Text == textBox9.Text || textBox18.Text == textBox10.Text ||
                                                        textBox18.Text == textBox11.Text || textBox18.Text == textBox12.Text || textBox18.Text == textBox13.Text ||
                                                        textBox18.Text == textBox14.Text) &&
                                                        (textBox17.Text == textBox5.Text || textBox17.Text == textBox6.Text || textBox17.Text == textBox7.Text ||
                                                        textBox17.Text == textBox8.Text || textBox17.Text == textBox9.Text || textBox17.Text == textBox10.Text ||
                                                        textBox17.Text == textBox11.Text || textBox17.Text == textBox12.Text || textBox17.Text == textBox13.Text ||
                                                        textBox17.Text == textBox14.Text) &&
                                                        (textBox16.Text == textBox5.Text || textBox16.Text == textBox6.Text || textBox16.Text == textBox7.Text ||
                                                        textBox16.Text == textBox8.Text || textBox16.Text == textBox9.Text || textBox16.Text == textBox10.Text ||
                                                        textBox16.Text == textBox11.Text || textBox16.Text == textBox12.Text || textBox16.Text == textBox13.Text ||
                                                        textBox16.Text == textBox14.Text))
                                                    {
                                                        if (checkBox11.Checked == true)
                                                        {
                                                            textBox15.Text = "NONE";
                                                        }
                                                        if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                                        {
                                                            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                                textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                                textBox18.Text != "" && textBox19.Text != "")
                                                            {
                                                                if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                                {
                                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                                    dbCon.Open();
                                                                    using (dbCon)
                                                                    {
                                                                        string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                                        com.ExecuteNonQuery();
                                                                    }
                                                                    dbCon.Close();
                                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.Close();
                                                                    return;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Вы ввели правильный ответ который не соответствует ни одному из вариантов ответа. Воспользуйтесь кнопкой ПРАВ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                if (textBox19.Text == "" || textBox18.Text == "" || textBox17.Text == "" || textBox16.Text == "")
                                                {
                                                    MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (checkBox15.Checked == true || checkBox14.Checked == true || checkBox13.Checked == true || checkBox12.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if ((textBox19.Text == "NULL" || textBox19.Text == "NONE") ||
                                                    (textBox18.Text == "NULL" || textBox18.Text == "NONE") ||
                                                    (textBox17.Text == "NULL" || textBox17.Text == "NONE") ||
                                                    (textBox16.Text == "NULL" || textBox16.Text == "NONE"))
                                                {
                                                    MessageBox.Show("Правильный ответ не может равнятся NONE либо NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    textBox19.Text = ""; textBox18.Text = ""; textBox17.Text = "";
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        if (textBox3.Text == "5")
                                        {
                                            if(checkBox1.Checked == true)
                                            {
                                                textBox5.Text = "NULL";
                                            }
                                            if (checkBox2.Checked == true)
                                            {
                                                textBox6.Text = "NULL";
                                            }
                                            if (checkBox3.Checked == true)
                                            {
                                                textBox7.Text = "NULL";
                                            }
                                            if (checkBox4.Checked == true)
                                            {
                                                textBox8.Text = "NULL";
                                            }
                                            if (checkBox5.Checked == true)
                                            {
                                                textBox9.Text = "NULL";
                                            }
                                            if (checkBox6.Checked == true)
                                            {
                                                textBox10.Text = "NULL";
                                            }
                                            if (checkBox7.Checked == true)
                                            {
                                                textBox11.Text = "NULL";
                                            }
                                            if (checkBox8.Checked == true)
                                            {
                                                textBox12.Text = "NULL";
                                            }
                                            if (checkBox9.Checked == true)
                                            {
                                                textBox13.Text = "NULL";
                                            }
                                            if (checkBox10.Checked == true)
                                            {
                                                textBox14.Text = "NULL";
                                            }
                                            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                                        textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                                        textBox13.Text != "" && textBox14.Text != "")
                                            {
                                                if ((textBox19.Text != "" && checkBox15.Checked == false && textBox19.Text != "NONE") &&
                                                    (textBox18.Text != "" && checkBox14.Checked == false && textBox18.Text != "NONE") &&
                                                    (textBox17.Text != "" && checkBox13.Checked == false && textBox17.Text != "NONE") &&
                                                    (textBox16.Text != "" && checkBox12.Checked == false && textBox16.Text != "NONE") &&
                                                    (textBox15.Text != "" && checkBox11.Checked == false && textBox15.Text != "NONE"))
                                                {
                                                    if ((textBox19.Text == textBox5.Text || textBox19.Text == textBox6.Text || textBox19.Text == textBox7.Text ||
                                                        textBox19.Text == textBox8.Text || textBox19.Text == textBox9.Text || textBox19.Text == textBox10.Text ||
                                                        textBox19.Text == textBox11.Text || textBox19.Text == textBox12.Text || textBox19.Text == textBox13.Text ||
                                                        textBox19.Text == textBox14.Text) &&
                                                        (textBox18.Text == textBox5.Text || textBox18.Text == textBox6.Text || textBox18.Text == textBox7.Text ||
                                                        textBox18.Text == textBox8.Text || textBox18.Text == textBox9.Text || textBox18.Text == textBox10.Text ||
                                                        textBox18.Text == textBox11.Text || textBox18.Text == textBox12.Text || textBox18.Text == textBox13.Text ||
                                                        textBox18.Text == textBox14.Text) &&
                                                        (textBox17.Text == textBox5.Text || textBox17.Text == textBox6.Text || textBox17.Text == textBox7.Text ||
                                                        textBox17.Text == textBox8.Text || textBox17.Text == textBox9.Text || textBox17.Text == textBox10.Text ||
                                                        textBox17.Text == textBox11.Text || textBox17.Text == textBox12.Text || textBox17.Text == textBox13.Text ||
                                                        textBox17.Text == textBox14.Text) &&
                                                        (textBox16.Text == textBox5.Text || textBox16.Text == textBox6.Text || textBox16.Text == textBox7.Text ||
                                                        textBox16.Text == textBox8.Text || textBox16.Text == textBox9.Text || textBox16.Text == textBox10.Text ||
                                                        textBox16.Text == textBox11.Text || textBox16.Text == textBox12.Text || textBox16.Text == textBox13.Text ||
                                                        textBox16.Text == textBox14.Text) &&
                                                        (textBox15.Text == textBox5.Text || textBox15.Text == textBox6.Text || textBox15.Text == textBox7.Text ||
                                                        textBox15.Text == textBox8.Text || textBox15.Text == textBox9.Text || textBox15.Text == textBox10.Text ||
                                                        textBox15.Text == textBox11.Text || textBox15.Text == textBox12.Text || textBox15.Text == textBox13.Text ||
                                                        textBox15.Text == textBox14.Text))
                                                    {
                                                       
                                                        if (textBox19.Text != "" && textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && textBox15.Text != "")
                                                        {
                                                            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                                textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                                textBox18.Text != "" && textBox19.Text != "")
                                                            {
                                                                if (textBox5.Text != "NULL" && textBox6.Text != "NULL" && textBox7.Text != "NULL" && textBox8.Text != "NULL")
                                                                {
                                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                                    dbCon.Open();
                                                                    using (dbCon)
                                                                    {
                                                                        string Query = "INSERT INTO " + Convert.ToString(a) + " (TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                                        com.ExecuteNonQuery();
                                                                    }
                                                                    dbCon.Close();
                                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.Close();
                                                                    return;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Как минимум один из 4 первых вариантов ответов равен NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Вы не ввели текст правильного ответа. Введите текст ответа или NONE", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Вы ввели правильный ответ который не соответствует ни одному из вариантов ответа. Воспользуйтесь кнопкой ПРАВ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                if (textBox19.Text == "" || textBox18.Text == "" || textBox17.Text == "" || textBox16.Text == "" || textBox15.Text == "")
                                                {
                                                    MessageBox.Show("Вы не ввели правильный ответ. Введите в пустое поле правильный вариант ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if (checkBox15.Checked == true || checkBox14.Checked == true || checkBox13.Checked == true || checkBox12.Checked == true || checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите флажок напротив первого правильного ответа.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                if ((textBox19.Text == "NULL" || textBox19.Text == "NONE") ||
                                                    (textBox18.Text == "NULL" || textBox18.Text == "NONE") ||
                                                    (textBox17.Text == "NULL" || textBox17.Text == "NONE") ||
                                                    (textBox16.Text == "NULL" || textBox16.Text == "NONE") ||
                                                    (textBox15.Text == "NULL" || textBox15.Text == "NONE"))
                                                {
                                                    MessageBox.Show("Правильный ответ не может равнятся NONE либо NULL.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    textBox19.Text = ""; textBox18.Text = ""; textBox17.Text = "";
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не ввели один из вариантов ответов. Введите в пустое поле вариант ответа либо NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы не верно ввели количестов ответов. Введите верное количестов от 1 до 5", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                if (textBox1.Text == "3")
                                {
                                    if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true &&
                                        checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true &&
                                        checkBox7.Checked == true && checkBox8.Checked == true && checkBox9.Checked == true &&
                                        checkBox10.Checked == true)
                                    {
                                        textBox5.Text = "NULL";
                                        textBox6.Text = "NULL";
                                        textBox7.Text = "NULL";
                                        textBox8.Text = "NULL";
                                        textBox9.Text = "NULL";
                                        textBox10.Text = "NULL";
                                        textBox11.Text = "NULL";
                                        textBox12.Text = "NULL";
                                        textBox13.Text = "NULL";
                                        textBox14.Text = "NULL";
                                        if (textBox19.Text != "" && checkBox15.Checked == false)
                                        {
                                            if (checkBox11.Checked == true && checkBox12.Checked == true && checkBox13.Checked == true && checkBox14.Checked == true)
                                            {
                                                textBox18.Text = "NONE";
                                                textBox17.Text = "NONE";
                                                textBox16.Text = "NONE";
                                                textBox15.Text = "NONE";
                                                if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                                                    textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                                                    textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" &&
                                                    textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
                                                    textBox18.Text != "" && textBox19.Text != "")
                                                {
                                                    OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                                                    dbCon.Open();
                                                    using (dbCon)
                                                    {
                                                        string Query = "INSERT INTO " + a + "(TQ, Q, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, PA1, PA2, PA3, PA4, PA5, KPA) VALUES (@TQ, @Q, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @A10, @PA1, @PA2, @PA3, @PA4, @PA5, @KPA)";
                                                        OleDbCommand com = new OleDbCommand(Query, dbCon);
                                                        com.Parameters.AddWithValue("@TQ", Convert.ToInt32(textBox1.Text));
                                                        com.Parameters.AddWithValue("@KPA", Convert.ToInt32(textBox3.Text));
                                                        com.Parameters.AddWithValue("@Q", textBox4.Text);
                                                        com.Parameters.AddWithValue("@A1", textBox5.Text);
                                                        com.Parameters.AddWithValue("@A2", textBox6.Text);
                                                        com.Parameters.AddWithValue("@A3", textBox7.Text);
                                                        com.Parameters.AddWithValue("@A4", textBox8.Text);
                                                        com.Parameters.AddWithValue("@A5", textBox9.Text);
                                                        com.Parameters.AddWithValue("@A6", textBox10.Text);
                                                        com.Parameters.AddWithValue("@A7", textBox11.Text);
                                                        com.Parameters.AddWithValue("@A8", textBox12.Text);
                                                        com.Parameters.AddWithValue("@A9", textBox13.Text);
                                                        com.Parameters.AddWithValue("@A10", textBox14.Text);
                                                        com.Parameters.AddWithValue("@PA5", textBox15.Text);
                                                        com.Parameters.AddWithValue("@PA4", textBox16.Text);
                                                        com.Parameters.AddWithValue("@PA3", textBox17.Text);
                                                        com.Parameters.AddWithValue("@PA2", textBox18.Text);
                                                        com.Parameters.AddWithValue("@PA1", textBox19.Text);
                                                        com.ExecuteNonQuery();
                                                    }
                                                    dbCon.Close();
                                                    MessageBox.Show("ВОПРОС УСПЕШНО ДОБАВЛЕН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.Close();
                                                    return;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Вы не все заполнили. Перепроверте заполненны ли все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы не отметили какой то верный ответ как NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Вы не ввели правильный вариант ответа. Введите правильный вариант ответа на 3 тип вопроса.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы не отметили все поля вариантов ответов как NULL. Отметъте все поля как NULL", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не верно ввели количество правильных ответов. Введите число от 1 до 5", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Вы не верно ввели тип вопроса. Введите число 1, 2 или 3", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) // прав 1
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox5.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox5.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox5.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox5.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox5.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox5.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox5.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox5.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox5.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox5.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox5.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox5.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox5.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox5.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // прав 2
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox6.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox6.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox6.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox6.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox6.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox6.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox6.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox6.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox6.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox6.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox6.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox6.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox6.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox6.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e) // прав 3
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox7.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox7.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox7.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox7.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox7.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox7.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox7.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox7.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox7.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox7.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox7.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox7.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox7.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox7.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e) // прав 4
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox8.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox8.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox8.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox8.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox8.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox8.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox8.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox8.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox8.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox8.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox8.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox8.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox8.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox8.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e) // прав 5
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox9.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox9.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox9.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox9.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox9.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox9.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox9.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox9.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox9.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox9.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox9.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox9.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox9.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox9.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e) // прав 6
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox10.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox10.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox10.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox10.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox10.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox10.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox10.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox10.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox10.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox10.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox10.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox10.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox10.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox10.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e) // прав 7
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox11.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox11.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox11.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox11.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox11.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox11.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox11.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox11.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox11.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox11.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox11.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox11.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox11.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox11.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e) // прав 8
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox12.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox12.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox12.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox12.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox12.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox12.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox12.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox12.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox12.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox12.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox12.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox12.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox12.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox12.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e) // прав 9
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox13.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox13.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox13.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox13.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox13.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox13.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox13.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox13.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox13.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox13.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox13.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox13.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox13.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox13.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button11_Click(object sender, EventArgs e) // прав 10
        {
            if (textBox1.Text == "1")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox14.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox14.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox1.Text == "2")
            {
                if (textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
                {
                    MessageBox.Show("Все поля для верных ответов заполнены. Пожалуйста удалите лишние ответы либо замените их на новые.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox14.Text;
                    MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант правильного ответа №1 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox14.Text;
                        MessageBox.Show("Верный ответ добавлен как №1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        if (textBox18.Text == "" && checkBox14.Checked == false)
                        {
                            textBox18.Text = textBox14.Text;
                            MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (checkBox14.Checked == true)
                        {
                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textBox18.Text != "")
                        {
                            DialogResult result1 = MessageBox.Show("Вариант правильного ответа №2 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result1 == DialogResult.Yes)
                            {
                                textBox18.Text = textBox14.Text;
                                MessageBox.Show("Верный ответ добавлен как №2.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (result1 == DialogResult.No)
                            {
                                if (textBox17.Text == "" && checkBox13.Checked == false)
                                {
                                    textBox17.Text = textBox14.Text;
                                    MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (checkBox13.Checked == true)
                                {
                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (textBox17.Text != "")
                                {
                                    DialogResult result2 = MessageBox.Show("Вариант правильного ответа №3 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        textBox17.Text = textBox14.Text;
                                        MessageBox.Show("Верный ответ добавлен как №3.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    if (result2 == DialogResult.No)
                                    {
                                        if (textBox16.Text == "" && checkBox12.Checked == false)
                                        {
                                            textBox16.Text = textBox14.Text;
                                            MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        if (checkBox12.Checked == true)
                                        {
                                            MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        if (textBox16.Text != "")
                                        {
                                            DialogResult result3 = MessageBox.Show("Вариант правильного ответа №4 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result3 == DialogResult.Yes)
                                            {
                                                textBox16.Text = textBox14.Text;
                                                MessageBox.Show("Верный ответ добавлен как №4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            if (result3 == DialogResult.No)
                                            {
                                                if (textBox15.Text == "" && checkBox11.Checked == false)
                                                {
                                                    textBox16.Text = textBox14.Text;
                                                    MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                                if (checkBox11.Checked == true)
                                                {
                                                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                if (textBox15.Text != "")
                                                {
                                                    DialogResult result4 = MessageBox.Show("Вариант правильного ответа №5 заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (result4 == DialogResult.Yes)
                                                    {
                                                        textBox15.Text = textBox14.Text;
                                                        MessageBox.Show("Верный ответ добавлен как №5.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        return;
                                                    }
                                                    if (result4 == DialogResult.No)
                                                    {
                                                        return;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (textBox1.Text == "3")
            {
                if (textBox19.Text == "" && checkBox15.Checked == false)
                {
                    textBox19.Text = textBox14.Text;
                    MessageBox.Show("Верный ответ добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (textBox19.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вариант ответа заполнен. Хотите его заменить на выбранный?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        textBox19.Text = textBox14.Text;
                        return;
                    }
                }
                if (checkBox15.Checked == true)
                {
                    MessageBox.Show("Снимите отметку с NONE.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
