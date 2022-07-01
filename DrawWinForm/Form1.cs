using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DrawWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0; comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Color col;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                maskedTextBox1.Visible = true; maskedTextBox1.Text = ""; label1.Text = "X1:"; label1.Visible = true;
                maskedTextBox2.Visible = true; maskedTextBox2.Text = ""; label2.Text = "Y1:"; label2.Visible = true;
                maskedTextBox3.Visible = true; maskedTextBox3.Text = ""; label3.Text = "Шир:"; label3.Visible = true;
                maskedTextBox4.Visible = true; maskedTextBox4.Text = ""; label4.Text = "Выс:"; label4.Visible = true;
                maskedTextBox5.Visible = false; label5.Visible = false;
                maskedTextBox6.Visible = false; label6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                maskedTextBox1.Visible = true; maskedTextBox1.Text = ""; label1.Text = "X1:"; label1.Visible = true;
                maskedTextBox2.Visible = true; maskedTextBox2.Text = ""; label2.Text = "Y1:"; label2.Visible = true;
                maskedTextBox3.Visible = true; maskedTextBox3.Text = ""; label3.Text = "X2:"; label3.Visible = true;
                maskedTextBox4.Visible = true; maskedTextBox4.Text = ""; label4.Text = "Y2:"; label4.Visible = true;
                maskedTextBox5.Visible = true; maskedTextBox5.Text = ""; label5.Text = "X3:"; label5.Visible = true;
                maskedTextBox6.Visible = true; maskedTextBox6.Text = ""; label6.Text = "Y3:"; label6.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                maskedTextBox1.Visible = true; maskedTextBox1.Text = ""; label1.Text = "X1:"; label1.Visible = true;
                maskedTextBox2.Visible = true; maskedTextBox2.Text = ""; label2.Text = "Y1:"; label2.Visible = true;
                maskedTextBox3.Visible = true; maskedTextBox3.Text = ""; label3.Text = "Rad:"; label3.Visible = true;
                maskedTextBox4.Visible = false; label4.Visible = false;
                maskedTextBox5.Visible = false; label5.Visible = false;
                maskedTextBox6.Visible = false; label6.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                col = Color.Red;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                col = Color.Blue;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                col = Color.Orange;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                col = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(col, 5.0f);
            if (comboBox1.SelectedIndex == 0)
            {
                g.DrawRectangle(pen, int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox2.Text) + 100, int.Parse(maskedTextBox3.Text), int.Parse(maskedTextBox4.Text));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                g.DrawLine(pen, int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox2.Text) + 100, int.Parse(maskedTextBox3.Text), int.Parse(maskedTextBox4.Text) + 100);
                g.DrawLine(pen, int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox2.Text) + 100, int.Parse(maskedTextBox5.Text), int.Parse(maskedTextBox6.Text) + 100);
                g.DrawLine(pen, int.Parse(maskedTextBox3.Text), int.Parse(maskedTextBox4.Text) + 100, int.Parse(maskedTextBox5.Text), int.Parse(maskedTextBox6.Text) + 100);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                g.DrawEllipse(pen, int.Parse(maskedTextBox1.Text), int.Parse(maskedTextBox2.Text) + 100, int.Parse(maskedTextBox3.Text), int.Parse(maskedTextBox3.Text));
            }
        }
    }
}
