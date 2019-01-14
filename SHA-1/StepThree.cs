using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA_1
{
    public partial class StepThree : Form
    {
        Random rnd = new Random();
        LabForm labForm = new LabForm();

        public StepThree(LabForm labForm)
        {
            InitializeComponent();
            GenerateTask();
            this.labForm = labForm;
        }

        private void GenerateTask()
        {
            lblH0.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblH1.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblH2.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblH3.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblH4.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
        }

        private string calculate(string H0, string H1, string H2, string H3, string H4)
        {
            int h0 = Convert.ToInt32(H0, 2),
                h1 = Convert.ToInt32(H1, 2),
                h2 = Convert.ToInt32(H2, 2),
                h3 = Convert.ToInt32(H3, 2),
                h4 = Convert.ToInt32(H4, 2);
            return Convert.ToString((h0 << 128) | (h1 << 96) | (h2 << 64) | (h3 << 32) | h4, 2);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (calculate(lblH0.Text, lblH1.Text, lblH2.Text, lblH3.Text, lblH4.Text) == txbResult.Text)
            {
                labForm.correctAnswers += 1;
                MessageBox.Show("Правильно! Итоговый результат: " + labForm.GetResult(), "Результат");
                labForm.Close();
            }
            else if (MessageBox.Show("Не правильно! Попробовать ещё раз?", "Результат", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GenerateTask();
            }
            else
            {
                MessageBox.Show("Итоговый результат: " + labForm.GetResult(), "Результат");
                labForm.Close();
            }
        }
    }
}
