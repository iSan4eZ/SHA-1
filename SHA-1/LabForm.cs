using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA_1
{
    public partial class LabForm : Form
    {
        public int correctAnswers;
        public const int totalTests = 6;

        public LabForm()
        {
            InitializeComponent();
            showStep(new StepOne(this));
        }

        public string GetResult()
        {
            return "Правильных: " + correctAnswers + "/" + totalTests + ". Балл: " + Math.Ceiling((decimal)correctAnswers / totalTests * 5);
        }

        public void showStep(Form formToShow)
        {
            formToShow.TopLevel = false;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(formToShow);
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            formToShow.Show();
        }

        //public string prepare(string messageBytes)
        //{
        //    int initMessageLength = messageBytes.Length;
        //    messageBytes += "1";
        //    while (messageBytes.Length % 512 != 448)
        //    {
        //        messageBytes += "0";
        //    }
        //    string toAppend = Convert.ToString(initMessageLength, 2);
        //    return messageBytes + toAppend.PadRight(64, '0');
        //}

        //private void txbToEncrypt_TextChanged(object sender, EventArgs evArgs)
        //{
        //    txbResult.Text = hashIt(txbToEncrypt.Text);
        //    Given
        //    string message = "";//txbToEncrypt.Text;
        //    uint h0 = 0x67452301, h1 = 0xEFCDAB89, h2 = 0x98BADCFE, h3 = 0x10325476, h4 = 0xC3D2E1F0, a, b, c, d, e;
        //    string messageBytes = StringToBinary(message);

        //    Preparation
        //    messageBytes = prepare(messageBytes);

        //    Processing
        //    int i = 0;
        //    while (messageBytes.Length > 512 * i)
        //    {
        //        string part = messageBytes.Substring(512 * i, 512);
        //        List<uint> words = Split(part, 32).ToList();
        //        for (int j = 16; j < 80; j++)
        //        {
        //            words.Add((words[j - 3] ^ words[j - 8] ^ words[j - 14] ^ words[j - 16]) << 1);
        //        }
        //        a = h0;
        //        b = h1;
        //        c = h2;
        //        d = h3;
        //        e = h4;
        //        uint f, k;
        //        for (int j = 0; j < 80; j++)
        //        {
        //            if (j < 20)
        //            {
        //                f = (b & c) | ((~b) & d);
        //                k = 0x5A827999;
        //            }
        //            else if (j < 40)
        //            {
        //                f = b ^ c ^ d;
        //                k = 0x6ED9EBA1;
        //            }
        //            else if (j < 60)
        //            {
        //                f = (b & c) | (b & d) | (c & d);
        //                k = 0x8F1BBCDC;
        //            }
        //            else
        //            {
        //                f = b ^ c ^ d;
        //                k = 0xCA62C1D6;
        //            }
        //            uint temp = (a << 5) + f + e + k + words[j];
        //            e = d;
        //            d = c;
        //            c = b << 30;
        //            b = a;
        //            a = temp;
        //        }
        //        h0 += a;
        //        h1 += b;
        //        h2 += c;
        //        h3 += d;
        //        h4 += e;
        //        i++;
        //    }

        //    Result
        //    ((h0 << 128) | (h1 << 96) | (h2 << 64) | (h3 << 32) | h4).ToString();
        //}

        //public static string StringToBinary(string data)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (char c in data.ToCharArray())
        //    {
        //        sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        //    }
        //    return sb.ToString();
        //}

        //public static string BinaryToString(string data)
        //{
        //    List<Byte> byteList = new List<Byte>();
        //    for (int i = 0; i < data.Length; i += 8)
        //    {
        //        byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
        //    }
        //    return Encoding.ASCII.GetString(byteList.ToArray());
        //}

        //static IEnumerable<uint> Split(string str, int chunkSize)
        //{
        //    return Enumerable.Range(0, str.Length / chunkSize)
        //        .Select(i => Convert.ToUInt32(str.Substring(i * chunkSize, chunkSize), 2));
        //}
    }
}
