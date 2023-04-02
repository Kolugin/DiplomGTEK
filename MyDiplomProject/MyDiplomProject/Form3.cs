using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
namespace MyDiplomProject
{
    public partial class Form3 : Form
    {
        public Form3(string Fam, string Namee, string SurName, string Spec, string Otdel, string Daytest)
        {
            InitializeComponent();
            this.Fam = Fam;
            this.Namee = Namee;
            this.SurName = SurName;
            this.Spec = Spec;
            this. Otdel = Otdel;
            this.DayTest = Daytest; 
        }
        public string Fam;
        public string Namee;
        public string SurName;
        public string Spec;
        public string Otdel;
        public string DayTest;
        string PravOtvet = "";
        string ChtoOtvetil = "";
        string TypeTest = "";
        int i = 0; // счетчик массива
        int kq = 0; // счетчик всего вопросов
        int kpo = 0; // счетчик правильных ответов
        int p = 0; // счетчик попыток ответа
        int CheckP = 0;
        int a = 0;
        string Quest = "";
        int Type = 0;
        string Answ1 = "";
        string Answ2 = "";
        string Answ3 = "";
        string Answ4 = "";
        string Answ5 = "";
        string Answ6 = "";
        string Answ7 = "";
        string Answ8 = "";
        string Answ9 = "";
        string Answ10 = "";
        string PAnsw1 = "";
        string PAnsw2 = "";
        string PAnsw3 = "";
        string PAnsw4 = "";
        string PAnsw5 = "";
        int KPA = 0;
        string LastQuest = "";
        int LastType = 0;
        string LastAnsw1 = "";
        string LastAnsw2 = "";
        string LastAnsw3 = "";
        string LastAnsw4 = "";
        string LastAnsw5 = "";
        string LastAnsw6 = "";
        string LastAnsw7 = "";
        string LastAnsw8 = "";
        string LastAnsw9 = "";
        string LastAnsw10 = "";
        string PLastAnsw1 = "";
        string PLastAnsw2 = "";
        string PLastAnsw3 = "";
        string PLastAnsw4 = "";
        string PLastAnsw5 = "";
        int KPALast = 0;
        List<string> Quests = new List<string>();
        List<int> Types = new List<int>();
        List<string> Ans1 = new List<string>();
        List<string> Ans2 = new List<string>();
        List<string> Ans3 = new List<string>();
        List<string> Ans4 = new List<string>();
        List<string> Ans5 = new List<string>();
        List<string> Ans6 = new List<string>();
        List<string> Ans7 = new List<string>();
        List<string> Ans8 = new List<string>();
        List<string> Ans9 = new List<string>();
        List<string> Ans10 = new List<string>();
        List<string> PAns1 = new List<string>();
        List<string> PAns2 = new List<string>();
        List<string> PAns3 = new List<string>();
        List<string> PAns4 = new List<string>();
        List<string> PAns5 = new List<string>();
        List<int> KPAS = new List<int>();
        public void TypeTests()
        {
            if (radioButton11.Checked == true)
            {
                TypeTest = "Тестирование";
            }
            if (radioButton12.Checked == true)
            {
                TypeTest = "Экзамен";
            }
        }
        public void Zapoln() // метод заполнения таблицы с результатами
        {
            if (Fam != "" && Namee != "" && SurName != "" && Spec != "" && Otdel != "" && DayTest != "" && PravOtvet != "" && ChtoOtvetil != "" && TypeTest != "")
            {
                OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
                dbCon.Open();
                using (dbCon)
                {
                    string Query = "INSERT INTO Registry (Family, Namee, SurName, Speciality, Otdel, DataTest, NameTest, Typetest, Quest, PravOtvet, ChtoOtvetil) VALUES (@Family, @Namee, @SurName, @Speciality, @Otdel, @DataTest, @NameTest, @TypeTest, @Quest, @PravOtvet, @ChtoOtvetil)";
                    OleDbCommand com = new OleDbCommand(Query, dbCon);
                    com.Parameters.AddWithValue("@Family", Fam);
                    com.Parameters.AddWithValue("@Namee", Namee);
                    com.Parameters.AddWithValue("@SurName", SurName);
                    com.Parameters.AddWithValue("@Speciality", Spec);
                    com.Parameters.AddWithValue("@Otdel", Otdel);
                    com.Parameters.AddWithValue("@DataTest", DayTest);
                    com.Parameters.AddWithValue("@NameTest", comboBox1.Text.ToString());
                    com.Parameters.AddWithValue("@TypeTest", TypeTest);
                    com.Parameters.AddWithValue("@Quest", Quest);
                    com.Parameters.AddWithValue("@PravOtvet", PravOtvet);
                    com.Parameters.AddWithValue("@ChtoOtvetil", ChtoOtvetil);
                    com.ExecuteNonQuery();
                }
                dbCon.Close();
            }
        }
        public void ChtoOtvet() // что ответил пользователь
        {
            if (Type == 1)
            {
                if (radioButton1.Checked == true)
                {
                    ChtoOtvetil = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    ChtoOtvetil = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    ChtoOtvetil = radioButton3.Text;
                }
                if (radioButton4.Checked == true)
                {
                    ChtoOtvetil = radioButton4.Text;
                }
                if (radioButton5.Checked == true)
                {
                    ChtoOtvetil = radioButton5.Text;
                }
                if (radioButton6.Checked == true)
                {
                    ChtoOtvetil = radioButton6.Text;
                }
                if (radioButton7.Checked == true)
                {
                    ChtoOtvetil = radioButton7.Text;
                }
                if (radioButton8.Checked == true)
                {
                    ChtoOtvetil = radioButton8.Text;
                }
                if (radioButton9.Checked == true)
                {
                    ChtoOtvetil = radioButton9.Text;
                }
                if (radioButton10.Checked == true)
                {
                    ChtoOtvetil = radioButton10.Text;
                }
            }
            if (Type == 2)
            {
                while (checkBox1.Checked == true)
                {
                    if (checkBox1.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox1.Text;
                    }
                    break;
                }
                while (checkBox2.Checked == true)
                {
                    if (checkBox2.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox2.Text;
                    }
                    break;
                }
                while (checkBox3.Checked == true)
                {
                    if (checkBox3.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox3.Text;
                    }
                    break;
                }
                while (checkBox4.Checked == true)
                {
                    if (checkBox4.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox4.Text;
                    }
                    break;
                }
                while (checkBox5.Checked == true)
                {
                    if (checkBox5.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox5.Text;
                    }
                    break;
                }
                while (checkBox6.Checked == true)
                {
                    if (checkBox6.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox6.Text;
                    }
                    break;
                }
                while (checkBox7.Checked == true)
                {
                    if (checkBox7.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox7.Text;
                    }
                    break;
                }
                while (checkBox8.Checked == true)
                {
                    if (checkBox8.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox8.Text;
                    }
                    break;
                }
                while (checkBox9.Checked == true)
                {
                    if (checkBox9.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox9.Text;
                    }
                    break;
                }
                while (checkBox10.Checked == true)
                {
                    if (checkBox10.Text == PAnsw1 && ChtoOtvetil == "")
                    {
                        ChtoOtvetil = checkBox10.Text;
                    }
                    break;
                }
                if (ChtoOtvetil != "")
                {
                    while (checkBox1.Checked == true)
                    {
                        if (checkBox1.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                        }
                        if (checkBox1.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                        }
                        if (checkBox1.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                        }
                        if (checkBox1.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                        }
                        break;
                    }
                    while (checkBox2.Checked == true)
                    {
                        if (checkBox2.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                        }
                        if (checkBox2.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                        }
                        if (checkBox2.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                        }
                        if (checkBox2.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                        }
                        break;
                    }
                    while (checkBox3.Checked == true)
                    {
                        if (checkBox3.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                        }
                        if (checkBox3.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                        }
                        if (checkBox3.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                        }
                        if (checkBox3.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                        }
                        break;
                    }
                    while (checkBox4.Checked == true)
                    {
                        if (checkBox4.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                        }
                        if (checkBox4.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                        }
                        if (checkBox4.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                        }
                        if (checkBox4.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                        }
                        break;
                    }
                    while (checkBox5.Checked == true)
                    {
                        if (checkBox5.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                        }
                        if (checkBox5.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                        }
                        if (checkBox5.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                        }
                        if (checkBox5.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                        }
                        break;
                    }
                    while (checkBox6.Checked == true)
                    {
                        if (checkBox6.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                        }
                        if (checkBox6.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                        }
                        if (checkBox6.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                        }
                        if (checkBox6.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                        }
                        break;
                    }
                    while (checkBox7.Checked == true)
                    {
                        if (checkBox7.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                        }
                        if (checkBox7.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                        }
                        if (checkBox7.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                        }
                        if (checkBox7.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                        }
                        break;
                    }
                    while (checkBox8.Checked == true)
                    {
                        if (checkBox8.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                        }
                        if (checkBox8.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                        }
                        if (checkBox8.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                        }
                        if (checkBox8.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                        }
                        break;
                    }
                    while (checkBox9.Checked == true)
                    {
                        if (checkBox9.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                        }
                        if (checkBox9.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                        }
                        if (checkBox9.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                        }
                        if (checkBox9.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                        }
                        break;
                    }
                    while (checkBox10.Checked == true)
                    {
                        if (checkBox10.Text == PAnsw2)
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                        }
                        if (checkBox10.Text == PAnsw3)
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                        }
                        if (checkBox10.Text == PAnsw4)
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                        }
                        if (checkBox10.Text == PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                        }
                        break;
                    }
                    if (ChtoOtvetil == PravOtvet)
                    {
                        while (checkBox1.Checked == true && checkBox1.Text != PAnsw1 && checkBox1.Text != PAnsw2 && checkBox1.Text != PAnsw3 && checkBox1.Text != PAnsw4 && checkBox1.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                            break;
                        }
                        while (checkBox2.Checked == true && checkBox2.Text != PAnsw1 && checkBox2.Text != PAnsw2 && checkBox2.Text != PAnsw3 && checkBox2.Text != PAnsw4 && checkBox2.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                            break;
                        }
                        while (checkBox3.Checked == true && checkBox3.Text != PAnsw1 && checkBox3.Text != PAnsw2 && checkBox3.Text != PAnsw3 && checkBox3.Text != PAnsw4 && checkBox3.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                            break;
                        }
                        while (checkBox4.Checked == true && checkBox4.Text != PAnsw1 && checkBox4.Text != PAnsw2 && checkBox4.Text != PAnsw3 && checkBox4.Text != PAnsw4 && checkBox4.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                            break;
                        }
                        while (checkBox5.Checked == true && checkBox5.Text != PAnsw1 && checkBox5.Text != PAnsw2 && checkBox5.Text != PAnsw3 && checkBox5.Text != PAnsw4 && checkBox5.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                            break;
                        }
                        while (checkBox6.Checked == true && checkBox6.Text != PAnsw1 && checkBox6.Text != PAnsw2 && checkBox6.Text != PAnsw3 && checkBox6.Text != PAnsw4 && checkBox6.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                            break;
                        }
                        while (checkBox7.Checked == true && checkBox7.Text != PAnsw1 && checkBox7.Text != PAnsw2 && checkBox7.Text != PAnsw3 && checkBox7.Text != PAnsw4 && checkBox7.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                            break;
                        }
                        while (checkBox8.Checked == true && checkBox8.Text != PAnsw1 && checkBox8.Text != PAnsw2 && checkBox8.Text != PAnsw3 && checkBox8.Text != PAnsw4 && checkBox8.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                            break;
                        }
                        while (checkBox9.Checked == true && checkBox9.Text != PAnsw1 && checkBox9.Text != PAnsw2 && checkBox9.Text != PAnsw3 && checkBox9.Text != PAnsw4 && checkBox9.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                            break;
                        }
                        while (checkBox10.Checked == true && checkBox10.Text != PAnsw1 && checkBox10.Text != PAnsw2 && checkBox10.Text != PAnsw3 && checkBox10.Text != PAnsw4 && checkBox10.Text != PAnsw5)
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                            break;
                        }
                    }
                }
                else
                {
                    while (checkBox1.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox1.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox1.Text;
                        }
                        break;
                    }
                    while (checkBox2.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox2.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox2.Text;
                        }
                        break;
                    }
                    while (checkBox3.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox3.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox3.Text;
                        }
                        break;
                    }
                    while (checkBox4.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox4.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox4.Text;
                        }
                        break;
                    }
                    while (checkBox5.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox5.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox5.Text;
                        }
                        break;
                    }
                    while (checkBox6.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox6.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox6.Text;
                        }
                        break;
                    }
                    while (checkBox7.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox7.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox7.Text;
                        }
                        break;
                    }
                    while (checkBox8.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox8.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox8.Text;
                        }
                        break;
                    }
                    while (checkBox9.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox9.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox9.Text;
                        }
                        break;
                    }
                    while (checkBox10.Checked == true)
                    {
                        if (ChtoOtvetil == "")
                        {
                            ChtoOtvetil = checkBox10.Text;
                        }
                        else
                        {
                            ChtoOtvetil += " " + checkBox10.Text;
                        }
                        break;
                    }
                }
            }
            if (Type == 3)
            {
                ChtoOtvetil = textBox1.Text;
            }
        }
        public void VernOtvet() // верный ответ
        {
            if (Type == 1 || Type == 3)
            {
                PravOtvet = PAnsw1;
            }
            if (Type == 2)
            {
                if ((PAnsw1 != "NONE") && (PAnsw2 == "NONE" && PAnsw3 == "NONE" && PAnsw4 == "NONE" && PAnsw5 == "NONE"))
                {
                    PravOtvet = PAnsw1;
                }
                if ((PAnsw1 != "NONE" && PAnsw2 != "NONE") && (PAnsw3 == "NONE" && PAnsw4 == "NONE" && PAnsw5 == "NONE"))
                {
                    PravOtvet = PAnsw1 + " " + PAnsw2;
                }
                if ((PAnsw1 != "NONE" && PAnsw2 != "NONE" && PAnsw3 != "NONE") && (PAnsw4 == "NONE" && PAnsw5 == "NONE"))
                {
                    PravOtvet = PAnsw1 + " " + PAnsw2 + " " + PAnsw3;
                }
                if ((PAnsw1 != "NONE" && PAnsw2 != "NONE" && PAnsw3 != "NONE" && PAnsw4 != "NONE") && (PAnsw5 == "NONE"))
                {
                    PravOtvet = PAnsw1 + " " + PAnsw2 + " " + PAnsw3 + " " + PAnsw4;
                }
                if (PAnsw1 != "NONE" && PAnsw2 != "NONE" && PAnsw3 != "NONE" && PAnsw4 != "NONE" && PAnsw5 != "NONE")
                {
                    PravOtvet = PAnsw1 + " " + PAnsw2 + " " + PAnsw3 + " " + PAnsw4 + " " + PAnsw5;
                }
            }
        }
        public void TheEnd()//завершение теста
        {
            if (Quest == LastQuest && Type == LastType && Answ1 == LastAnsw1 && Answ2 == LastAnsw2 && Answ3 == LastAnsw3 && Answ4 == LastAnsw4 && Answ5 == LastAnsw5 && Answ6 == LastAnsw6
                     && Answ7 == LastAnsw7 && Answ8 == LastAnsw8 && Answ9 == LastAnsw9 && Answ10 == LastAnsw10 && PAnsw1 == PLastAnsw1 && PAnsw2 == PLastAnsw2 && PAnsw3 == PLastAnsw3
                     && PAnsw4 == PLastAnsw4 && PAnsw5 == PLastAnsw5 && KPA == KPALast)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
        }
        public void SbrosVisibl() // сброс видимости
        {
            label1.Visible = false;
            textBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            groupBox1.Visible = true;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            button2.Visible = false;
            button3.Visible = false;
        }
        public void SbrosCheck() // сбрасыватель чеков
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }
        public void CheckPAnswer() // проверка на правильный ответ 
        {
            if (Type == 1 && radioButton11.Checked == true) // первый тип вопроса
            {
                 if ((radioButton1.Checked == true && radioButton1.Text == PAnsw1)||
                    (radioButton2.Checked == true && radioButton2.Text == PAnsw1) ||
                    (radioButton3.Checked == true && radioButton3.Text == PAnsw1) ||
                    (radioButton4.Checked == true && radioButton4.Text == PAnsw1) ||
                    (radioButton5.Checked == true && radioButton5.Text == PAnsw1) ||
                    (radioButton6.Checked == true && radioButton6.Text == PAnsw1) ||
                    (radioButton7.Checked == true && radioButton7.Text == PAnsw1) ||
                    (radioButton8.Checked == true && radioButton8.Text == PAnsw1) ||
                    (radioButton9.Checked == true && radioButton9.Text == PAnsw1) ||
                    (radioButton10.Checked == true && radioButton10.Text == PAnsw1))
                    //----------------------------------------------------------------
                 {
                    MessageBox.Show("Ваш ответ правильный", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    kpo++;
                    p = 0;
                    i++;
                    kq++;
                    return;
                 }
                 if ((radioButton1.Checked == true && radioButton1.Text != PAnsw1) ||
                    (radioButton2.Checked == true && radioButton2.Text != PAnsw1) ||
                    (radioButton3.Checked == true && radioButton3.Text != PAnsw1) ||
                    (radioButton4.Checked == true && radioButton4.Text != PAnsw1) ||
                    (radioButton5.Checked == true && radioButton5.Text != PAnsw1) ||
                    (radioButton6.Checked == true && radioButton6.Text != PAnsw1) ||
                    (radioButton7.Checked == true && radioButton7.Text != PAnsw1) ||
                    (radioButton8.Checked == true && radioButton8.Text != PAnsw1) ||
                    (radioButton9.Checked == true && radioButton9.Text != PAnsw1) ||
                    (radioButton10.Checked == true && radioButton10.Text != PAnsw1))
                    //----------------------------------------------------------------
                 {
                    DialogResult result = MessageBox.Show("Ваш ответ неправильный. Хотите повторить?", "Неверный ответ", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result == DialogResult.Yes)
                    {
                        p++;
                        if (p == 3)
                        {
                            MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ChtoOtvet();
                            Zapoln();
                            PravOtvet = "";
                            ChtoOtvetil = "";
                            i++;
                            kq++;
                            p = 0;
                        }
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        i++;
                        kq++;
                        p = 0;
                        return;
                    }
                    if (result == DialogResult.No && p == 3)
                    {
                        MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        i++;
                        kq++;
                        p = 0;
                    }
                }   
            }
            if (Type == 2 && radioButton11.Checked == true) // 2 тип вопрсоа
            {
                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true ||
                    checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true ||
                    checkBox9.Checked == true || checkBox10.Checked == true)
                {
                    while (checkBox1.Checked == true)
                    {
                        if (checkBox1.Text == PAnsw1 || checkBox1.Text == PAnsw2 || checkBox1.Text == PAnsw3 || checkBox1.Text == PAnsw4 || checkBox1.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox2.Checked == true)
                    {
                        if (checkBox2.Text == PAnsw1 || checkBox2.Text == PAnsw2 || checkBox2.Text == PAnsw3 || checkBox2.Text == PAnsw4 || checkBox2.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox3.Checked == true)
                    {
                        if (checkBox3.Text == PAnsw1 || checkBox3.Text == PAnsw2 || checkBox3.Text == PAnsw3 || checkBox3.Text == PAnsw4 || checkBox3.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox4.Checked == true)
                    {
                        if (checkBox4.Text == PAnsw1 || checkBox4.Text == PAnsw2 || checkBox4.Text == PAnsw3 || checkBox4.Text == PAnsw4 || checkBox4.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox5.Checked == true)
                    {
                        if (checkBox5.Text == PAnsw1 || checkBox5.Text == PAnsw2 || checkBox5.Text == PAnsw3 || checkBox5.Text == PAnsw4 || checkBox5.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox6.Checked == true)
                    {
                        if (checkBox6.Text == PAnsw1 || checkBox6.Text == PAnsw2 || checkBox6.Text == PAnsw3 || checkBox6.Text == PAnsw4 || checkBox6.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox7.Checked == true)
                    {
                        if (checkBox7.Text == PAnsw1 || checkBox7.Text == PAnsw2 || checkBox7.Text == PAnsw3 || checkBox7.Text == PAnsw4 || checkBox7.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox8.Checked == true)
                    {
                        if (checkBox8.Text == PAnsw1 || checkBox8.Text == PAnsw2 || checkBox8.Text == PAnsw3 || checkBox8.Text == PAnsw4 || checkBox8.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox9.Checked == true)
                    {
                        if (checkBox9.Text == PAnsw1 || checkBox9.Text == PAnsw2 || checkBox9.Text == PAnsw3 || checkBox9.Text == PAnsw4 || checkBox9.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox10.Checked == true)
                    {
                        if (checkBox10.Text == PAnsw1 || checkBox10.Text == PAnsw2 || checkBox10.Text == PAnsw3 || checkBox10.Text == PAnsw4 || checkBox10.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    //------------------------------------------------------------------------------------------------------------------------------------------------
                    if (CheckP == KPA)
                    {
                        MessageBox.Show("Ваш ответ правильный", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        kpo++;
                        i++;
                        kq++;
                        p = 0;
                        CheckP = 0;
                        return;
                    }
                    if (CheckP != KPA)
                    {
                        DialogResult result = MessageBox.Show("Ваш ответ неправильный. Хотите повторить?", "Неверный ответ", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        if (result == DialogResult.Yes)
                        {
                            p++;
                            CheckP = 0;
                            if (p == 3)
                            {
                                MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ChtoOtvet();
                                Zapoln();
                                PravOtvet = "";
                                ChtoOtvetil = "";
                                i++;
                                kq++;
                                p = 0;
                                CheckP = 0;
                            }
                            return;
                        }
                        if (result == DialogResult.No)
                        {
                            ChtoOtvet();
                            Zapoln();
                            PravOtvet = "";
                            ChtoOtvetil = "";
                            i++;
                            kq++;
                            p = 0;
                            CheckP = 0;
                            return;
                        }
                        if (result == DialogResult.No && p == 3)
                        {
                            MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ChtoOtvet();
                            Zapoln();
                            PravOtvet = "";
                            ChtoOtvetil = "";
                            i++;
                            kq++;
                            p = 0;
                            CheckP = 0;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            if (Type == 3 && radioButton11.Checked == true)
            {
                if (textBox1.Text == PAnsw1 || textBox1.Text == PAnsw2 || textBox1.Text == PAnsw3 || textBox1.Text == PAnsw4 || textBox1.Text == PAnsw5)
                {
                    MessageBox.Show("Ваш ответ правильный", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    kpo++;
                    p = 0;
                    i++;
                    kq++;
                    return;
                }
                if (textBox1.Text != "" && (textBox1.Text != PAnsw1 || textBox1.Text != PAnsw2 || textBox1.Text != PAnsw3 || textBox1.Text != PAnsw4 || textBox1.Text != PAnsw5))
                {
                    DialogResult result = MessageBox.Show("Ваш ответ неправильный. Хотите повторить?", "Неверный ответ", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result == DialogResult.Yes)
                    {
                        p++;
                        if (p == 3)
                        {
                            MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ChtoOtvet();
                            Zapoln();
                            PravOtvet = "";
                            ChtoOtvetil = "";
                            i++;
                            kq++;
                            p = 0;
                        }
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        i++;
                        kq++;
                        p = 0;
                        return;
                    }
                    if (result == DialogResult.No && p == 3)
                    {
                        MessageBox.Show("Вы исчерпали 3 попытки что бы ответить. После закрытия сообщения вы перейдете к следующему вопросу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        i++;
                        kq++;
                        p = 0;
                    }
                }
                else
                {
                    return;
                }
            }
            if (Type == 1 && radioButton12.Checked == true)
            {
                if ((radioButton1.Checked == true && radioButton1.Text == PAnsw1) ||
                    (radioButton2.Checked == true && radioButton2.Text == PAnsw1) ||
                    (radioButton3.Checked == true && radioButton3.Text == PAnsw1) ||
                    (radioButton4.Checked == true && radioButton4.Text == PAnsw1) ||
                    (radioButton5.Checked == true && radioButton5.Text == PAnsw1) ||
                    (radioButton6.Checked == true && radioButton6.Text == PAnsw1) ||
                    (radioButton7.Checked == true && radioButton7.Text == PAnsw1) ||
                    (radioButton8.Checked == true && radioButton8.Text == PAnsw1) ||
                    (radioButton9.Checked == true && radioButton9.Text == PAnsw1) ||
                    (radioButton10.Checked == true && radioButton10.Text == PAnsw1))
                    //----------------------------------------------------------------
                {
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    kpo++;
                    i++;
                    kq++;
                    return;
                }
                if ((radioButton1.Checked == true && radioButton1.Text != PAnsw1) ||
                   (radioButton2.Checked == true && radioButton2.Text != PAnsw1) ||
                   (radioButton3.Checked == true && radioButton3.Text != PAnsw1) ||
                   (radioButton4.Checked == true && radioButton4.Text != PAnsw1) ||
                   (radioButton5.Checked == true && radioButton5.Text != PAnsw1) ||
                   (radioButton6.Checked == true && radioButton6.Text != PAnsw1) ||
                   (radioButton7.Checked == true && radioButton7.Text != PAnsw1) ||
                   (radioButton8.Checked == true && radioButton8.Text != PAnsw1) ||
                   (radioButton9.Checked == true && radioButton9.Text != PAnsw1) ||
                   (radioButton10.Checked == true && radioButton10.Text != PAnsw1))
                   //----------------------------------------------------------------
                {
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    i++;
                    kq++;
                }
            }
            if (Type == 2 && radioButton12.Checked == true)
            {
                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true ||
                    checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true ||
                    checkBox9.Checked == true || checkBox10.Checked == true)
                {
                    while (checkBox1.Checked == true)
                    {
                        if (checkBox1.Text == PAnsw1 || checkBox1.Text == PAnsw2 || checkBox1.Text == PAnsw3 || checkBox1.Text == PAnsw4 || checkBox1.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox2.Checked == true)
                    {
                        if (checkBox2.Text == PAnsw1 || checkBox2.Text == PAnsw2 || checkBox2.Text == PAnsw3 || checkBox2.Text == PAnsw4 || checkBox2.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox3.Checked == true)
                    {
                        if (checkBox3.Text == PAnsw1 || checkBox3.Text == PAnsw2 || checkBox3.Text == PAnsw3 || checkBox3.Text == PAnsw4 || checkBox3.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox4.Checked == true)
                    {
                        if (checkBox4.Text == PAnsw1 || checkBox4.Text == PAnsw2 || checkBox4.Text == PAnsw3 || checkBox4.Text == PAnsw4 || checkBox4.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox5.Checked == true)
                    {
                        if (checkBox5.Text == PAnsw1 || checkBox5.Text == PAnsw2 || checkBox5.Text == PAnsw3 || checkBox5.Text == PAnsw4 || checkBox5.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox6.Checked == true)
                    {
                        if (checkBox6.Text == PAnsw1 || checkBox6.Text == PAnsw2 || checkBox6.Text == PAnsw3 || checkBox6.Text == PAnsw4 || checkBox6.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox7.Checked == true)
                    {
                        if (checkBox7.Text == PAnsw1 || checkBox7.Text == PAnsw2 || checkBox7.Text == PAnsw3 || checkBox7.Text == PAnsw4 || checkBox7.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox8.Checked == true)
                    {
                        if (checkBox8.Text == PAnsw1 || checkBox8.Text == PAnsw2 || checkBox8.Text == PAnsw3 || checkBox8.Text == PAnsw4 || checkBox8.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox9.Checked == true)
                    {
                        if (checkBox9.Text == PAnsw1 || checkBox9.Text == PAnsw2 || checkBox9.Text == PAnsw3 || checkBox9.Text == PAnsw4 || checkBox9.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    while (checkBox10.Checked == true)
                    {
                        if (checkBox10.Text == PAnsw1 || checkBox10.Text == PAnsw2 || checkBox10.Text == PAnsw3 || checkBox10.Text == PAnsw4 || checkBox10.Text == PAnsw5)
                        {
                            CheckP++;
                        }
                        else
                        {
                            CheckP--;
                        }
                        break;
                    }
                    //----------------------------------------------------------------------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------------------------------------
                    if (CheckP == KPA)
                    {
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        kpo++;
                        i++;
                        kq++;
                        p = 0;
                        CheckP = 0;
                        return;
                    }
                    if (CheckP != KPA)
                    {
                        ChtoOtvet();
                        Zapoln();
                        PravOtvet = "";
                        ChtoOtvetil = "";
                        i++;
                        kq++;
                        p = 0;
                        CheckP = 0;
                    }
                }
                else
                {
                    return;
                }
            }
            if (Type == 3 && radioButton12.Checked == true)
            {
                if (textBox1.Text == PAnsw1 || textBox1.Text == PAnsw2 || textBox1.Text == PAnsw3 || textBox1.Text == PAnsw4 || textBox1.Text == PAnsw5)
                {
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    kpo++;
                    i++;
                    kq++;
                    return;
                }
                if (textBox1.Text != "" && (textBox1.Text != PAnsw1 || textBox1.Text != PAnsw2 || textBox1.Text != PAnsw3 || textBox1.Text != PAnsw4 || textBox1.Text != PAnsw5))
                {
                    ChtoOtvet();
                    Zapoln();
                    PravOtvet = "";
                    ChtoOtvetil = "";
                    i++;
                    kq++;
                }
                else
                {
                    return;
                }
            }
        }
        public void CheckNull() // метод проверки на ключевые слова в бд и показ компонентов в зависимости от содержания ячейки
        {
            if (Type == 1)
            {
                textBox1.Visible = false;
                if (Answ1 == "NULL" || Answ1 == "Null" || Answ1 == "null" || Answ1 == "NONE" || Answ1 == "None" || Answ1 == "none")
                {
                    radioButton1.Visible = false;
                    checkBox1.Visible = false;
                }
                else
                {
                    radioButton1.Visible = true;
                    checkBox1.Visible = false;
                }
                if (Answ2 == "NULL" || Answ2 == "Null" || Answ2 == "null" || Answ2 == "NONE" || Answ2 == "None" || Answ2 == "none")
                {
                    radioButton2.Visible = false;
                    checkBox2.Visible = false;
                }
                else
                {
                    radioButton2.Visible = true;
                    checkBox2.Visible = false;
                }
                if (Answ3 == "NULL" || Answ3 == "Null" || Answ3 == "null" || Answ3 == "NONE" || Answ3 == "None" || Answ3 == "none")
                {
                    radioButton3.Visible = false;
                    checkBox3.Visible = false;
                }
                else
                {
                    radioButton3.Visible = true;
                    checkBox3.Visible = false;
                }
                if (Answ4 == "NULL" || Answ4 == "Null" || Answ4 == "null" || Answ4 == "NONE" || Answ4 == "None" || Answ4 == "none")
                {
                    radioButton4.Visible = false;
                    checkBox4.Visible = false;
                }
                else
                {
                    radioButton4.Visible = true;
                    checkBox4.Visible = false;
                }
                if (Answ5 == "NULL" || Answ5 == "Null" || Answ5 == "null" || Answ5 == "NONE" || Answ5 == "None" || Answ5 == "none")
                {
                    radioButton5.Visible = false;
                    checkBox5.Visible = false;
                }
                else
                {
                    radioButton5.Visible = true;
                    checkBox5.Visible = false;
                }
                if (Answ6 == "NULL" || Answ6 == "Null" || Answ6 == "null" || Answ6 == "NONE" || Answ6 == "None" || Answ6 == "none")
                {
                    radioButton6.Visible = false;
                    checkBox6.Visible = false;
                }
                else
                {
                    radioButton6.Visible = true;
                    checkBox6.Visible = false;
                }
                if (Answ7 == "NULL" || Answ7 == "Null" || Answ7 == "null" || Answ7 == "NONE" || Answ7 == "None" || Answ7 == "none")
                {
                    radioButton7.Visible = false;
                    checkBox7.Visible = false;
                }
                else
                {
                    radioButton7.Visible = true;
                    checkBox7.Visible = false;
                }
                if (Answ8 == "NULL" || Answ8 == "Null" || Answ8 == "null" || Answ8 == "NONE" || Answ8 == "None" || Answ8 == "none")
                {
                    radioButton8.Visible = false;
                    checkBox8.Visible = false;
                }
                else
                {
                    radioButton8.Visible = true;
                    checkBox8.Visible = false;
                }
                if (Answ9 == "NULL" || Answ9 == "Null" || Answ9 == "null" || Answ9 == "NONE" || Answ9 == "None" || Answ9 == "none")
                {
                    radioButton9.Visible = false;
                    checkBox9.Visible = false;
                }
                else
                {
                    radioButton9.Visible = true;
                    checkBox9.Visible = false;
                }
                if (Answ10 == "NULL" || Answ10 == "Null" || Answ10 == "null" || Answ10 == "NONE" || Answ10 == "None" || Answ10 == "none")
                {
                    radioButton10.Visible = false;
                    checkBox10.Visible = false;
                }
                else
                {
                    radioButton10.Visible = true;
                    checkBox10.Visible = false;
                }
            }
            else if (Type == 2)
            {
                textBox1.Visible = false;
                //Проверка на содержание в переменной ключевых слов
                if (Answ1 == "NULL" || Answ1 == "Null" || Answ1 == "null" || Answ1 == "NONE" || Answ1 == "None" || Answ1 == "none")
                {
                    checkBox1.Visible = false;
                    radioButton1.Visible = false;
                }
                else
                {
                    checkBox1.Visible = true;
                    radioButton1.Visible = false;
                }
                if (Answ2 == "NULL" || Answ2 == "Null" || Answ2 == "null" || Answ2 == "NONE" || Answ2 == "None" || Answ2 == "none")
                {
                    checkBox2.Visible = false;
                    radioButton2.Visible = false;
                }
                else
                {
                    checkBox2.Visible = true;
                    radioButton2.Visible = false;
                }
                if (Answ3 == "NULL" || Answ3 == "Null" || Answ3 == "null" || Answ3 == "NONE" || Answ3 == "None" || Answ3 == "none")
                {
                    checkBox3.Visible = false;
                    radioButton3.Visible = false;
                }
                else
                {
                    checkBox3.Visible = true;
                    radioButton3.Visible = false;
                }
                if (Answ4 == "NULL" || Answ4 == "Null" || Answ4 == "null" || Answ4 == "NONE" || Answ4 == "None" || Answ4 == "none")
                {
                    checkBox4.Visible = false;
                    radioButton4.Visible = false;
                }
                else
                {
                    checkBox4.Visible = true;
                    radioButton4.Visible = false;
                }
                if (Answ5 == "NULL" || Answ5 == "Null" || Answ5 == "null" || Answ5 == "NONE" || Answ5 == "None" || Answ5 == "none")
                {
                    checkBox5.Visible = false;
                    radioButton5.Visible = false;
                }
                else
                {
                    checkBox5.Visible = true;
                    radioButton5.Visible = false;
                }
                if (Answ6 == "NULL" || Answ6 == "Null" || Answ6 == "null" || Answ6 == "NONE" || Answ6 == "None" || Answ6 == "none")
                {
                    checkBox6.Visible = false;
                    radioButton6.Visible = false;
                }
                else
                {
                    checkBox6.Visible = true;
                    radioButton6.Visible = false;
                }
                if (Answ7 == "NULL" || Answ7 == "Null" || Answ7 == "null" || Answ7 == "NONE" || Answ7 == "None" || Answ7 == "none")
                {
                    checkBox7.Visible = false;
                    radioButton7.Visible = false;
                }
                else
                {
                    checkBox7.Visible = true;
                    radioButton7.Visible = false;
                }
                if (Answ8 == "NULL" || Answ8 == "Null" || Answ8 == "null" || Answ8 == "NONE" || Answ8 == "None" || Answ8 == "none")
                {
                    checkBox8.Visible = false;
                    radioButton8.Visible = false;
                }
                else
                {
                    checkBox8.Visible = true;
                    radioButton8.Visible = false;
                }
                if (Answ9 == "NULL" || Answ9 == "Null" || Answ9 == "null" || Answ9 == "NONE" || Answ9 == "None" || Answ9 == "none")
                {
                    checkBox9.Visible = false;
                    radioButton9.Visible = false;
                }
                else
                {
                    checkBox9.Visible = true;
                    radioButton9.Visible = false;
                }
                if (Answ10 == "NULL" || Answ10 == "Null" || Answ10 == "null" || Answ10 == "NONE" || Answ10 == "None" || Answ10 == "none")
                {
                    checkBox10.Visible = false;
                    radioButton10.Visible = false;
                }
                else
                {
                    checkBox10.Visible = true;
                    radioButton10.Visible = false;
                }
            }
            else if (Type == 3)
            {
                textBox1.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
            }
        }
        public void Full () //метод наполнения компонентов;
        {
            if (Type == 1)
            {
                label1.Text = Quest;
                label1.Visible = true;
                radioButton1.Text = Answ1;
                radioButton2.Text = Answ2;
                radioButton3.Text = Answ3;
                radioButton4.Text = Answ4;
                radioButton5.Text = Answ5;
                radioButton6.Text = Answ6;
                radioButton7.Text = Answ7;
                radioButton8.Text = Answ8;
                radioButton9.Text = Answ9;
                radioButton10.Text = Answ10;
            }
            else if (Type == 2)
            {
                label1.Text = Quest;
                label1.Visible = true;
                checkBox1.Text = Answ1;
                checkBox2.Text = Answ2;
                checkBox3.Text = Answ3;
                checkBox4.Text = Answ4;
                checkBox5.Text = Answ5;
                checkBox6.Text = Answ6;
                checkBox7.Text = Answ7;
                checkBox8.Text = Answ8;
                checkBox9.Text = Answ9;
                checkBox10.Text = Answ10;
            }
            else if (Type == 3)
            {
                label1.Text = Quest;
                label1.Visible = true;
            }
        }
        public void Integra () // метод присваивания значения в зависимости от и)))
        {
            Quest = Convert.ToString(Quests[i]);
            Type = Convert.ToInt32(Types[i]);
            Answ1 = Convert.ToString(Ans1[i]);
            Answ2 = Convert.ToString(Ans2[i]);
            Answ3 = Convert.ToString(Ans3[i]);
            Answ4 = Convert.ToString(Ans4[i]);
            Answ5 = Convert.ToString(Ans5[i]);
            Answ6 = Convert.ToString(Ans6[i]);
            Answ7 = Convert.ToString(Ans7[i]);
            Answ8 = Convert.ToString(Ans8[i]);
            Answ9 = Convert.ToString(Ans9[i]);
            Answ10 = Convert.ToString(Ans10[i]);
            PAnsw1 = Convert.ToString(PAns1[i]);
            PAnsw2 = Convert.ToString(PAns2[i]);
            PAnsw3 = Convert.ToString(PAns3[i]);
            PAnsw4 = Convert.ToString(PAns4[i]);
            PAnsw5 = Convert.ToString(PAns5[i]);
            KPA = Convert.ToInt32(KPAS[i]);
        }
        public void Reader() // метод чтения теста
        {
            OleDbConnection dbCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
            dbCon.Open();
            using (dbCon)
            {
                // чтение вопросов
                OleDbCommand cmd = new OleDbCommand("SELECT Q FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Quests.Add(reader.GetString(0));
                }
                reader.Close();
                // чтение типа вопроса
                OleDbCommand cmd2 = new OleDbCommand("SELECT TQ FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    Types.Add(reader2.GetInt32(0));
                }
                reader2.Close();
                // чтение ответа1
                OleDbCommand cmd3 = new OleDbCommand("SELECT A1 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    Ans1.Add(reader3.GetString(0));
                }
                reader3.Close();
                // чтение ответа2
                OleDbCommand cmd4 = new OleDbCommand("SELECT A2 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    Ans2.Add(reader4.GetString(0));
                }
                reader4.Close();
                // чтение ответа3
                OleDbCommand cmd5 = new OleDbCommand("SELECT A3 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    Ans3.Add(reader5.GetString(0));
                }
                reader5.Close();
                // чтение ответа4
                OleDbCommand cmd6 = new OleDbCommand("SELECT A4 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader6 = cmd6.ExecuteReader();
                while (reader6.Read())
                {
                    Ans4.Add(reader6.GetString(0));
                }
                reader6.Close();
                // чтение ответа5
                OleDbCommand cmd7 = new OleDbCommand("SELECT A5 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader7 = cmd7.ExecuteReader();
                while (reader7.Read())
                {
                    Ans5.Add(reader7.GetString(0));
                }
                reader7.Close();
                // чтение ответа6
                OleDbCommand cmd8 = new OleDbCommand("SELECT A6 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader8 = cmd8.ExecuteReader();
                while (reader8.Read())
                {
                    Ans6.Add(reader8.GetString(0));
                }
                reader8.Close();
                // чтение ответа7
                OleDbCommand cmd9 = new OleDbCommand("SELECT A7 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader9 = cmd9.ExecuteReader();
                while (reader9.Read())
                {
                    Ans7.Add(reader9.GetString(0));
                }
                reader9.Close();
                // чтение ответа8
                OleDbCommand cmd10 = new OleDbCommand("SELECT A8 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader10 = cmd10.ExecuteReader();
                while (reader10.Read())
                {
                    Ans8.Add(reader10.GetString(0));
                }
                reader10.Close();
                // чтение ответа9
                OleDbCommand cmd11 = new OleDbCommand("SELECT A9 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader11 = cmd11.ExecuteReader();
                while (reader11.Read())
                {
                    Ans9.Add(reader11.GetString(0));
                }
                reader11.Close();
                // чтение ответа10
                OleDbCommand cmd12 = new OleDbCommand("SELECT A10 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader12 = cmd12.ExecuteReader();
                while (reader12.Read())
                {
                    Ans10.Add(reader12.GetString(0));
                }
                reader12.Close();
                // чтение правильного ответа1
                OleDbCommand cmd13 = new OleDbCommand("SELECT PA1 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader13 = cmd13.ExecuteReader();
                while (reader13.Read())
                {
                    PAns1.Add(reader13.GetString(0));
                }
                reader13.Close();
                // чтение правильного ответа2
                OleDbCommand cmd14 = new OleDbCommand("SELECT PA2 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader14 = cmd14.ExecuteReader();
                while (reader14.Read())
                {
                    PAns2.Add(reader14.GetString(0));
                }
                reader14.Close();
                // чтение правильного ответа3
                OleDbCommand cmd15 = new OleDbCommand("SELECT PA3 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader15 = cmd15.ExecuteReader();
                while (reader15.Read())
                {
                    PAns3.Add(reader15.GetString(0));
                }
                reader15.Close();
                // чтение правильного ответа4
                OleDbCommand cmd16 = new OleDbCommand("SELECT PA4 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader16 = cmd16.ExecuteReader();
                while (reader16.Read())
                {
                    PAns4.Add(reader16.GetString(0));
                }
                reader16.Close();
                // чтение правильного ответа5
                OleDbCommand cmd17 = new OleDbCommand("SELECT PA5 FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader17 = cmd17.ExecuteReader();
                while (reader17.Read())
                {
                    PAns5.Add(reader17.GetString(0));
                }
                reader17.Close();
                // чтение колва правильных ответов в вопросе
                OleDbCommand cmd18 = new OleDbCommand("SELECT KPA FROM " + comboBox1.SelectedItem.ToString(), dbCon);
                OleDbDataReader reader18 = cmd18.ExecuteReader();
                while (reader18.Read())
                {
                    KPAS.Add(reader18.GetInt32(0));
                }
                reader18.Close();
                dbCon.Close();
            }
        }
        public void ReaderLast() // считывание последних переменных в списках
        {
            LastQuest = Convert.ToString(Quests.Last());
            LastType = Convert.ToInt32(Types.Last());
            LastAnsw1 = Convert.ToString(Ans1.Last());
            LastAnsw2 = Convert.ToString(Ans2.Last());
            LastAnsw3 = Convert.ToString(Ans3.Last());
            LastAnsw4 = Convert.ToString(Ans4.Last());
            LastAnsw5 = Convert.ToString(Ans5.Last());
            LastAnsw6 = Convert.ToString(Ans6.Last());
            LastAnsw7 = Convert.ToString(Ans7.Last());
            LastAnsw8 = Convert.ToString(Ans8.Last());
            LastAnsw9 = Convert.ToString(Ans9.Last());
            LastAnsw10 = Convert.ToString(Ans10.Last());
            PLastAnsw1 = Convert.ToString(PAns1.Last());
            PLastAnsw2 = Convert.ToString(PAns2.Last());
            PLastAnsw3 = Convert.ToString(PAns3.Last());
            PLastAnsw4 = Convert.ToString(PAns4.Last());
            PLastAnsw5 = Convert.ToString(PAns5.Last());
            KPALast = Convert.ToInt32(KPAS.Last());
          // MessageBox.Show(LastQuest);
        }
        private void button1_Click(object sender, EventArgs e) // запуск теста
        {
            if (comboBox1.SelectedIndex != -1 && (radioButton11.Checked == true || radioButton12.Checked == true))
            {
                Reader();
            }
            else
            {
                MessageBox.Show("Не выбран тест из списка либо не выбран тип тестирования.","Предупреждение",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                return;
            }
            groupBox1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            if (radioButton12.Checked == true)
            {
                button3.Visible = false;
            }
        }
        private void Form3_Load(object sender, EventArgs e) // загрузка формы
        {
            OleDbConnection dbCon = new OleDbConnection(
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=False");
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
            groupBox1.Controls.Add(radioButton11);
            groupBox1.Controls.Add(radioButton12);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            dbCon.Close();
        }
        private void button2_Click(object sender, EventArgs e) // Тест
        {
            TypeTests();
            button2.Text = "Далее";
            if (i == 0)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 1)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 2)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 3)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 4)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 5)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 6)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 7)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 8)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i == 9)
            {
                Integra();
                VernOtvet();
                CheckNull();
                Full();
                CheckPAnswer();
                ReaderLast();
                SbrosCheck();
            }
            if (i >= 10)
            {
                TheEnd();
                if (a == 0)
                {
                    Integra();
                    VernOtvet();
                    CheckNull();
                    Full();
                    CheckPAnswer();
                    ReaderLast();
                    SbrosCheck();
                }
                if (a == 1)
                {
                    DialogResult result = MessageBox.Show(string.Format("Вы прошли тестирование/экзамен со следующим результатом \n Всего вопросов - {0} \n Дано верных ответов - {1} из {0} \n После закрытия сообщения результат сохранится в базу данных.", kq, kpo), "Итоговое сообщение", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        SbrosVisibl();
                        SbrosCheck();
                        Quests.Clear();
                        Types.Clear();
                        Ans1.Clear();
                        Ans2.Clear();
                        Ans3.Clear();
                        Ans4.Clear();
                        Ans5.Clear();
                        Ans6.Clear();
                        Ans7.Clear();
                        Ans8.Clear();
                        Ans9.Clear();
                        Ans10.Clear();
                        PAns1.Clear();
                        PAns2.Clear();
                        PAns3.Clear();
                        PAns4.Clear();
                        PAns5.Clear();
                        KPAS.Clear();
                        Form1 NewForm = new Form1();
                        NewForm.Show();
                        this.Close();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e) //прерывание тестирования
        {
            DialogResult result = MessageBox.Show(string.Format("Вы досрочно завершили прохождение тестирования со следующим результатом \n Всего вопросов - {0} \n Дано верных ответов - {1} из {0}", kq, kpo), "Итоговое сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                SbrosVisibl();
                SbrosCheck();
                Quests.Clear();
                Types.Clear();
                Ans1.Clear();
                Ans2.Clear();
                Ans3.Clear();
                Ans4.Clear();
                Ans5.Clear();
                Ans6.Clear();
                Ans7.Clear();
                Ans8.Clear();
                Ans9.Clear();
                Ans10.Clear();
                PAns1.Clear();
                PAns2.Clear();
                PAns3.Clear();
                PAns4.Clear();
                PAns5.Clear();
                KPAS.Clear();
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Close();
            }
        }
    }
}