using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace wordgame
{
    public partial class Form1 : Form
    {
        public string file = File.ReadAllText("ukenglish.txt");
        public string[] lines = File.ReadAllLines("ukenglish.txt");
        public string[] vlist = new string[2];
        public string[] llist = new string[21];
        public List<char> letters = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        public List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        public List<char> valid = new List<char>();
        public int points = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public static char write(ref List<char> list, ref List<char> valid)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, list.Count);
            char x = list[num];
            valid.Add(x); 
            list.Remove(list[num]);
            return x;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Refresh";
            string[] lines = File.ReadAllLines("ukenglish.txt");
            valid = new List<char>();
            textBox1.ReadOnly= false;
            letters = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            label7.Text = write(ref vowels, ref valid).ToString();
            label8.Text = write(ref vowels, ref valid).ToString();
            label1.Text= write(ref letters, ref valid).ToString();
            label2.Text = write(ref letters, ref valid).ToString();
            label3.Text = write(ref letters, ref valid).ToString();
            label4.Text = write(ref letters, ref valid).ToString();
            label5.Text = write(ref letters, ref valid).ToString();
            label6.Text = write(ref letters, ref valid).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (textBox1.Text == lines[i])
                {
                    lines[i] = null;
                    points += textBox1.Text.Length;
                    label9.Text = "Points : "+points;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (valid[0] == e.KeyChar) { e.Handled = false; }
            if (valid[1] == e.KeyChar) { e.Handled = false; }
            if (valid[2] == e.KeyChar) { e.Handled = false; }
            if (valid[3] == e.KeyChar) { e.Handled = false; }
            if (valid[4] == e.KeyChar) { e.Handled = false; }
            if (valid[5] == e.KeyChar) { e.Handled = false; }
            if (valid[6] == e.KeyChar) { e.Handled = false; }
            if (valid[7] == e.KeyChar) { e.Handled = false; }
            if(e.KeyChar=='\b') {  e.Handled = false; }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
