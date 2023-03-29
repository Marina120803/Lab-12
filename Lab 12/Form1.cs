using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Pen pen = new Pen(Color.Black);
        private int x, y;
        int[,] x1 = new int[100, 10];
        int[,] y1 = new int[100, 10];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    g.DrawRectangle(pen, x, y, 40, 40);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x1[i, j] = i * 10 + j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    y1[i, j] = i * 10 + j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x = x1[i, j];
                    y = y1[i, j];
                }
            }
            Invalidate();
        }
    }
}
