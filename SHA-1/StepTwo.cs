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
    public partial class StepTwo : Form
    {
        Random rnd = new Random();
        LabForm labForm;
        int step = 0;

        public StepTwo(LabForm labForm)
        {
            InitializeComponent();
            this.labForm = labForm;
            GenerateTask();
        }

        private void GenerateTask()
        {
            step += 1;
            txbResult.Text = "";
            lblTask.Text = "Закончите обработку сообщения под индексом ";
            switch (step)
            {
                case 1:
                    lblTask.Text += rnd.Next(0, 20);
                    break;
                case 2:
                    lblTask.Text += rnd.Next(20, 40);
                    break;
                case 3:
                    lblTask.Text += rnd.Next(40, 60);
                    break;
                case 4:
                    lblTask.Text += rnd.Next(60, 80);
                    break;
                default:
                    labForm.showStep(new StepThree(labForm));
                    this.Close();
                    return;
            }
            lblATask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblBTask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblCTask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblDTask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
            lblETask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string correctAnswer;
            int b = Convert.ToInt32(lblBTask.Text, 2), 
                c = Convert.ToInt32(lblCTask.Text, 2), 
                d = Convert.ToInt32(lblDTask.Text, 2);
            switch (step)
            {
                case 1:
                    correctAnswer = Convert.ToString((b & c) | ((~b) & d), 2);
                    break;
                case 2:
                    correctAnswer = Convert.ToString(b ^ c ^ d, 2);
                    break;
                case 3:
                    correctAnswer = Convert.ToString((b & c) | (b & d) | (c & d), 2);
                    break;
                case 4:
                    correctAnswer = Convert.ToString(b ^ c ^ d, 2);
                    break;
                default:
                    labForm.showStep(new StepThree(labForm));
                    this.Close();
                    return;
            }
            if (correctAnswer == txbResult.Text)
            {
                MessageBox.Show("Правильно!", "Результат");
                labForm.correctAnswers += 1;
                GenerateTask();
            }
            else if (MessageBox.Show("Не правильно! Попробовать ещё раз?", "Результат", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                step -= 1;
                GenerateTask();
            }
            else
            {
                GenerateTask();
            }
        }
    }
}
