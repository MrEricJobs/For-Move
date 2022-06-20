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
    public partial class ExerciseLogin : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=EXERCISE;Uid=root;Pwd=mingle4860~!;");
        public ExerciseLogin()
        {
            InitializeComponent();
            string hello;
            
        }

        private void ExerciseLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("select * from UNANDUP where user_id = '" + textBox1.Text + "' and user_password = '" + textBox2.Text + "';", connection);
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                int count = 0;
                while(reader.Read())
                {
                    count++;
                }
                if(count == 1)
                {
                    MessageBox.Show("환영합니다, " + textBox1.Text + "님.");
                    ExerciseLoading form3 = new ExerciseLoading(this);
                    this.Hide();

                    form3.Show();


                    
                }
                else
                {
                    MessageBox.Show("잘못된 계정입니다.");

                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("로그인이 되지 않았습니다.");
            }
            
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExerciseRegister form2 = new ExerciseRegister();

            form2.Show();


            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Enabled = false;
            }
            else
            {
                label4.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
