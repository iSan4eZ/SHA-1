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
    public partial class StepOne : Form
    {
        Random rnd = new Random();
        LabForm labForm;

        public StepOne(LabForm labForm)
        {
            InitializeComponent();
            this.labForm = labForm;
            GenerateTask();
        }

        private void GenerateTask()
        {
            txbTask.Text = Convert.ToString(rnd.Next(Int32.MaxValue), 2);
        }

        public string prepare(string messageBytes)
        {
            int initMessageLength = messageBytes.Length;
            messageBytes += "1";
            while (messageBytes.Length % 512 != 448)
            {
                messageBytes += "0";
            }
            string toAppend = Convert.ToString(initMessageLength, 2);
            return messageBytes + toAppend.PadRight(64, '0');
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (prepare(txbTask.Text) == rtbResult.Text)
            {
                MessageBox.Show("Правильно!", "Результат");
                labForm.correctAnswers += 1;
                NextStep();
            }
            else if (MessageBox.Show("Не правильно! Попробовать ещё раз?", "Результат", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                rtbResult.Text = "";
                GenerateTask();
            } 
            else
            {
                NextStep();
            }
        }

        private void NextStep()
        {
            labForm.showStep(new StepTwo(labForm));
            this.Close();
        }

        private void rtbResult_TextChanged(object sender, EventArgs e)
        {
            lbSymbols.Text = "Символов: " + rtbResult.Text.Length;
        }
    }
}
