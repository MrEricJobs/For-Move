using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExerciseProgram
{
    public partial class ExerciseMain : Form
    {
        ExerciseLogin f1;
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=EXERCISE;Uid=root;Pwd=mingle4860~!;");
        MySqlConnection connection2 =
        new MySqlConnection("Server=localhost;Database=user_exercise;Uid=root;Pwd=mingle4860~!;");



        public ExerciseMain(ExerciseLogin form)
        {
            InitializeComponent();
            f1 = form;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select user_name from unandup where user_id = '" + f1.textBox1.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                string name = rdr[0].ToString();
                label1.Text = name;


            }
            rdr.Close();
            connection.Close();
            label4.Text = f1.textBox1.Text;
            label6.Text = f1.textBox2.Text;
            connection.Open();
            string sql1 = "select user_age from unandup where user_id = '" + f1.textBox1.Text + "';";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();


            while (rdr1.Read())
            {
                string age = rdr1[0].ToString();
                label10.Text = age;


            }
            rdr1.Close();
            connection.Close();
            connection.Open();
            string sql2 = "select user_kg from unandup where user_id = '" + f1.textBox1.Text + "';";
            MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();


            while (rdr2.Read())
            {
                string kg = rdr2[0].ToString();
                label8.Text = kg;


            }
            rdr2.Close();
            connection.Close();
            connection2.Open();
            MySqlCommand cmd5 = new MySqlCommand();
            cmd5.Connection = connection2;
            cmd5.CommandText = "SELECT * FROM " + label4.Text + ";";


            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            DataSet ds = new DataSet();
            da.Fill(ds, label4.Text);


            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = label4.Text;
            connection2.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    Thread.Sleep(300);
                    radioButton1.Checked = false;
                }
                else
                {
                    connection.Open();
                    Thread.Sleep(300);
                    radioButton1.Checked = false;
                    string sql3 = "UPDATE unandup SET user_name = '" + textBox1.Text + "'" + "WHERE user_id = '" + label4.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, connection);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("수정되었습니다.");
                    connection.Close();
                    connection.Open();
                    string sql = "select user_name from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        string name = rdr[0].ToString();
                        label1.Text = name;


                    }
                    rdr.Close();
                    connection.Close();
                    label4.Text = label4.Text;
                    label6.Text = label6.Text;
                    connection.Open();
                    string sql1 = "select user_age from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();


                    while (rdr1.Read())
                    {
                        string age = rdr1[0].ToString();
                        label10.Text = age;


                    }
                    rdr1.Close();
                    connection.Close();
                    connection.Open();
                    string sql2 = "select user_kg from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();


                    while (rdr2.Read())
                    {
                        string kg = rdr2[0].ToString();
                        label8.Text = kg;


                    }
                    rdr2.Close();
                    connection.Close();
                }


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (textBox2.Text == "")
                {
                    Thread.Sleep(300);
                    radioButton2.Checked = false;
                }
                else
                {
                    connection.Open();
                    Thread.Sleep(300);
                    radioButton2.Checked = false;
                    string sql3 = "UPDATE unandup SET user_id = '" + textBox2.Text + "'" + "WHERE user_id = '" + label4.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, connection);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("수정되었습니다.");
                    connection.Close();
                    connection.Open();
                    string sql = "select user_name from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        string name = rdr[0].ToString();
                        label1.Text = name;


                    }
                    rdr.Close();
                    connection.Close();
                    label4.Text = textBox2.Text;
                    label6.Text = label6.Text;
                    connection.Open();
                    string sql1 = "select user_age from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();


                    while (rdr1.Read())
                    {
                        string age = rdr1[0].ToString();
                        label10.Text = age;


                    }
                    rdr1.Close();
                    connection.Close();
                    connection.Open();
                    string sql2 = "select user_kg from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();


                    while (rdr2.Read())
                    {
                        string kg = rdr2[0].ToString();
                        label8.Text = kg;


                    }
                    rdr2.Close();
                    connection.Close();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                if (textBox3.Text == "")
                {
                    Thread.Sleep(300);
                    radioButton3.Checked = false;
                }
                else
                {
                    connection.Open();
                    Thread.Sleep(300);
                    radioButton3.Checked = false;
                    string sql3 = "UPDATE unandup SET user_password = '" + textBox3.Text + "'" + "WHERE user_id = '" + label4.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, connection);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("수정되었습니다.");
                    connection.Close();
                    connection.Open();
                    string sql = "select user_name from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        string name = rdr[0].ToString();
                        label1.Text = name;


                    }
                    rdr.Close();
                    connection.Close();
                    label4.Text = label4.Text;
                    label6.Text = textBox3.Text;
                    connection.Open();
                    string sql1 = "select user_age from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();


                    while (rdr1.Read())
                    {
                        string age = rdr1[0].ToString();
                        label10.Text = age;


                    }
                    rdr1.Close();
                    connection.Close();
                    connection.Open();
                    string sql2 = "select user_kg from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();


                    while (rdr2.Read())
                    {
                        string kg = rdr2[0].ToString();
                        label8.Text = kg;


                    }
                    rdr2.Close();
                    connection.Close();
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                if (textBox4.Text == "")
                {
                    Thread.Sleep(300);
                    radioButton4.Checked = false;
                }
                else
                {
                    connection.Open();
                    Thread.Sleep(300);
                    radioButton4.Checked = false;
                    string sql3 = "UPDATE unandup SET user_age = '" + textBox4.Text + "'" + "WHERE user_id = '" + label4.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, connection);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("수정되었습니다.");
                    connection.Close();
                    connection.Open();
                    string sql = "select user_name from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        string name = rdr[0].ToString();
                        label1.Text = name;


                    }
                    rdr.Close();
                    connection.Close();
                    label4.Text = label4.Text;
                    label6.Text = label6.Text;
                    connection.Open();
                    string sql1 = "select user_age from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();


                    while (rdr1.Read())
                    {
                        string age = rdr1[0].ToString();
                        label10.Text = age;


                    }
                    rdr1.Close();
                    connection.Close();
                    connection.Open();
                    string sql2 = "select user_kg from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();


                    while (rdr2.Read())
                    {
                        string kg = rdr2[0].ToString();
                        label8.Text = kg;


                    }
                    rdr2.Close();
                    connection.Close();
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                if (textBox5.Text == "")
                {
                    Thread.Sleep(300);
                    radioButton5.Checked = false;
                }
                else
                {
                    connection.Open();
                    Thread.Sleep(300);
                    radioButton5.Checked = false;
                    string sql3 = "UPDATE unandup SET user_kg = '" + textBox5.Text + "'" + "WHERE user_id = '" + label4.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, connection);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("수정되었습니다.");
                    connection.Close();
                    connection.Open();
                    string sql = "select user_name from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        string name = rdr[0].ToString();
                        label1.Text = name;


                    }
                    rdr.Close();
                    connection.Close();
                    label4.Text = label4.Text;
                    label6.Text = label6.Text;
                    connection.Open();
                    string sql1 = "select user_age from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();


                    while (rdr1.Read())
                    {
                        string age = rdr1[0].ToString();
                        label10.Text = age;


                    }
                    rdr1.Close();
                    connection.Close();
                    connection.Open();
                    string sql2 = "select user_kg from unandup where user_id = '" + label4.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, connection);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();


                    while (rdr2.Read())
                    {
                        string kg = rdr2[0].ToString();
                        label8.Text = kg;


                    }
                    rdr2.Close();
                    connection.Close();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = filename;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExerciseMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ExerciseMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            
        }
        Point lastPoint;

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if(textBox6.Text == "오늘 먹은 칼로리를 입력해주세요")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black; 
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "오늘 먹은 칼로리를 입력해주세요";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double kal;
            try
            {
                kal = Convert.ToDouble(textBox6.Text);
                if (Convert.ToDouble(label8.Text) * 24 * 1.5 < kal) 
                {
                    if (checkBox1.Checked == true)
                    {
                        double kal2 = kal - (Convert.ToDouble(label8.Text) * 24 * 1.5);

                        MessageBox.Show("오늘 운동해야하는 칼로리는 " + Convert.ToString(Convert.ToInt32(kal2)) + "kcal 이므로 줄넘기 " + Convert.ToString(Convert.ToInt32(kal2 / 0.18))+ "회를 해야 합니다");

                        string today = DateTime.Today.ToShortDateString();
                        connection2.Open();
                        MySqlCommand command = new MySqlCommand("select exercise_date from " + label4.Text + " where exercise_date = '" + today + "';", connection2);
                        MySqlDataReader reader;
                        
                        reader = command.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        reader.Close();
                        
                        
                        if (count >= 1)
                        {

                            
                            string sql = "UPDATE " + label4.Text + " SET exercise_kcal = " + Convert.ToInt32(kal2) + ", exercise_type = '줄넘기', exercise_momentum = '" + Convert.ToString(Convert.ToInt32(kal2 / 0.18)) + "회' WHERE exercise_date = '" + today + "';";
                            MySqlCommand cmd = new MySqlCommand(sql, connection2);
                            cmd.ExecuteNonQuery();
                            
                            
                            
                            
                            MySqlCommand cmd5 = new MySqlCommand();
                            cmd5.Connection = connection2;
                            cmd5.CommandText = "SELECT * FROM " + label4.Text + ";";


                            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
                            DataSet ds = new DataSet();
                            da.Fill(ds, label4.Text);


                            dataGridView1.DataSource = ds;
                            dataGridView1.DataMember = label4.Text;
                            
                            




                        }
                        else
                        {
                            
                            
                            string sql2 = "insert into " + label4.Text + " (exercise_date, exercise_kcal, exercise_type, exercise_momentum) values ('" + today + "', " + Convert.ToInt32(kal2) + ", '줄넘기', '" + Convert.ToString(Convert.ToInt32(kal2 / 0.18)) + "회');";
                            MySqlCommand cmd2 = new MySqlCommand(sql2, connection2);
                            cmd2.ExecuteNonQuery();
                            


                            
                            MySqlCommand cmd5 = new MySqlCommand();
                            cmd5.Connection = connection2;
                            cmd5.CommandText = "SELECT * FROM " + label4.Text + ";";


                            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
                            DataSet ds = new DataSet();
                            da.Fill(ds, label4.Text);


                            dataGridView1.DataSource = ds;
                            dataGridView1.DataMember = label4.Text;
                            
                            
                            

                        }
                        connection2.Close();
                        
                    }
                    else if(checkBox2.Checked == true)
                    {
                        double kal2 = kal - (Convert.ToDouble(label8.Text) * 24 * 1.5);
                        MessageBox.Show("오늘 운동해야하는 칼로리는 " + Convert.ToString(kal2) + "kcal 이므로 달리기 " + Convert.ToString(Convert.ToInt32(kal2 / (Convert.ToDouble(label8.Text) * 0.1208))) + "분을 해야 합니다");
                        string today = DateTime.Today.ToShortDateString();
                        connection2.Open();
                        MySqlCommand command = new MySqlCommand("select exercise_date from " + label4.Text + " where exercise_date = '" + today + "';", connection2);
                        MySqlDataReader reader;

                        reader = command.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        reader.Close();


                        if (count >= 1)
                        {


                            string sql = "UPDATE " + label4.Text + " SET exercise_kcal = " + Convert.ToInt32(kal2) + ", exercise_type = '달리기', exercise_momentum = '" + Convert.ToString(Convert.ToInt32(kal2 / (Convert.ToDouble(label8.Text) * 0.1208))) + "분' WHERE exercise_date = '" + today + "';";
                            MySqlCommand cmd = new MySqlCommand(sql, connection2);
                            cmd.ExecuteNonQuery();




                            MySqlCommand cmd5 = new MySqlCommand();
                            cmd5.Connection = connection2;
                            cmd5.CommandText = "SELECT * FROM " + label4.Text + ";";


                            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
                            DataSet ds = new DataSet();
                            da.Fill(ds, label4.Text);


                            dataGridView1.DataSource = ds;
                            dataGridView1.DataMember = label4.Text;






                        }
                        else
                        {


                            string sql2 = "insert into " + label4.Text + " (exercise_date, exercise_kcal, exercise_type, exercise_momentum) values ('" + today + "', " + Convert.ToInt32(kal2) + ", '달리기', '" + Convert.ToString(Convert.ToInt32(kal2 / (Convert.ToDouble(label8.Text) * 0.1208))) + "분');";
                            MySqlCommand cmd2 = new MySqlCommand(sql2, connection2);
                            cmd2.ExecuteNonQuery();




                            MySqlCommand cmd5 = new MySqlCommand();
                            cmd5.Connection = connection2;
                            cmd5.CommandText = "SELECT * FROM " + label4.Text + ";";


                            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
                            DataSet ds = new DataSet();
                            da.Fill(ds, label4.Text);


                            dataGridView1.DataSource = ds;
                            dataGridView1.DataMember = label4.Text;




                        }
                        connection2.Close();
                    }

                }
                else
                {
                    MessageBox.Show("오늘은 운동을 안해도 됩니다.");
                }
                
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                button3.Enabled = false;
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }
    }
}
            