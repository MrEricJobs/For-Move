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

namespace ExerciseProgram
{
    public partial class ExerciseLoading : Form
    {
        int loading = 0;
        ExerciseLogin f1;


        public ExerciseLoading(ExerciseLogin form)
        {
            InitializeComponent();
            f1 = form;
        }

        private void ExerciseMain_Load(object sender, EventArgs e)
        {

            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (loading != 100)
            {
                progressBar1.Value += 1;
                loading += 1;
                Thread.Sleep(200);


            }
            label2.Text = "Ready";
            timer1.Enabled = false;
            MessageBox.Show("준비되었습니다.");
            ExerciseMain form4 = new ExerciseMain(f1);
            this.Hide();

            form4.Show();

        }
    }
}
