using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExerciseProgram
{
    public partial class ExerciseRegister : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=EXERCISE;Uid=root;Pwd=mingle4860~!;");
        MySqlConnection connection2 =
        new MySqlConnection("Server=localhost;Database=user_exercise;Uid=root;Pwd=mingle4860~!;");

        public ExerciseRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExerciseLogin form1 = new ExerciseLogin();

            form1.Show();


            this.Hide();
        }

        private void ExerciseRegister_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO UNANDUP(user_name, user_id, user_password, user_age, user_kg) VALUES('" + textBox1.Text + "'," + " '" + textBox2.Text + "'," + " '" + textBox3.Text + "'," + " '" + textBox4.Text + "'," + " '" + textBox5.Text + "'" + ");";           

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                
                if (command.ExecuteNonQuery() == 1)
                {
                    connection2.Open();
                    string sql = "create table " + textBox2.Text + "(exercise_date DATE, exercise_kcal INT(100), exercise_type VARCHAR(50), exercise_momentum VARCHAR(50));";
                    MySqlCommand cmd = new MySqlCommand(sql, connection2);
                    cmd.ExecuteNonQuery();
                    connection2.Close();
                    MessageBox.Show("회원가입이 되었습니다.");
                    
                    /*ExerciseLoading form3 = new ExerciseLoading();
                    this.Hide();

                    form3.Show();*/


                    
                }
                else
                {
                    MessageBox.Show("회원가입이 되지 않았습니다.");
                }
            }
            catch
            {
                MessageBox.Show("중복된 아이디입니다.");
            }


            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                label4.Enabled = false;
            }
            else
            {
                label4.Enabled = true;
            }
        }
    }
}
