﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_quest_test
{
    public partial class Form1 : Form
    {
        Pen my_pen;
        Bitmap my_bitmap;
        SolidBrush current_brush;
        SolidBrush my_brush;
        Graphics graph;
        int step;
        Color my_color;
        Color[,] matrix = new Color[1005,1005];

        /////////////////////////
        void draw_grid()
        {
            graph.Clear(Color.Black);
            pb_canvas.Image = my_bitmap;
            for (int i = step; i <= pb_canvas.Width; i += step)
            {
                graph.DrawLine(my_pen, i, 0, i, pb_canvas.Height);
            }
            for (int i = step; i <= pb_canvas.Height; i += step)
            {
                graph.DrawLine(my_pen, 0, i, pb_canvas.Width, i);
            }
            
            for(int i = 0; i<=1000; i++)
                for(int j = 0; j<=1000; j++)
                {
                    if (matrix[i, j] != Color.Empty)
                    {
                        //    MessageBox.Show(i.ToString() + " : " + j.ToString());
                     //   MessageBox.Show(i.ToString() + " : " + j.ToString() + " " + matrix[i,j].ToString());
                        current_brush = new SolidBrush(matrix[i, j]);
                        
                        graph.FillRectangle(current_brush, new Rectangle(i*step,j*step,step,step));
                        pb_canvas.Image = my_bitmap;
                    }
                }

        }
        
        
        ////////////////////
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
                for (int j = 0; j <= 1000; j++)
                    matrix[i, j] = Color.Empty;
            step = 50;
            my_pen = new Pen(Color.Green, 1);
            my_bitmap = new Bitmap(pb_canvas.Width, pb_canvas.Height);
            my_brush = new SolidBrush(Color.SteelBlue);
            graph = Graphics.FromImage(my_bitmap);
            Form1_Resize(sender, e);
            tb_step.Text = step.ToString();
            tb_width.Text = my_pen.Width.ToString();
            my_color = Color.SteelBlue;
            panel_my_color.BackColor = Color.SteelBlue;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pb_canvas.Width = (this.Width - panel_main.Width - 44)/step*step;
            pb_canvas.Height = (this.Height - 60) / step * step;
            panel_main.Height = (this.Height - 60) / step * step;

            try
            {
                my_bitmap = new Bitmap(pb_canvas.Width, pb_canvas.Height);
            }
            catch
            {

            }
            graph = Graphics.FromImage(my_bitmap);
            draw_grid();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 1000; i++)
                for(int j = 0; j <= 1000; j++)
                {
                    matrix[i,j] = Color.Black;
                }
            draw_grid();
        }

        private void tb_step_Validated(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(tb_step.Text);
                if (value <= 50 && value >= 10)
                {
                    step = value;
                }
                else
                {
                    tb_step.Text = Convert.ToString(step);
                }
            }
            catch
            {
                tb_step.Text = Convert.ToString(step);
            }
            draw_grid();
        }

        private void tb_step_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int value = Convert.ToInt32(tb_step.Text);
                    if (value <= 50 && value >= 10)
                    {
                        step = value;
                    }
                    else
                    {
                        tb_step.Text = Convert.ToString(step);
                    }
                }
                catch
                {
                    tb_step.Text = Convert.ToString(step);
                }
                draw_grid();
            }
        }

        private void pb_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = this.PointToClient(Cursor.Position);
            pos.X -= pb_canvas.Location.X;
            pos.Y -= pb_canvas.Location.Y;
            pos.X /= step; pos.X *= step;
            pos.Y /= step; pos.Y *= step;
            Size size = new Size(step, step);
            tb_pos.Text = pos.X.ToString() + ":" + pos.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                pb_canvas.Image = my_bitmap;
                graph.FillRectangle(my_brush, new Rectangle(pos, size));
                matrix[pos.X / step, pos.Y / step] = my_color;
            }
        }

        private void pb_canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point pos = this.PointToClient(Cursor.Position);
            pos.X -= pb_canvas.Location.X;
            pos.Y -= pb_canvas.Location.Y;
            pos.X /= step; pos.X *= step;
            pos.Y /= step; pos.Y *= step;
            Size size = new Size(step, step);
            tb_pos.Text = pos.X.ToString() + ":" + pos.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                pb_canvas.Image = my_bitmap;
                graph.FillRectangle(my_brush, new Rectangle(pos, size));
                matrix[pos.X / step, pos.Y / step] = my_color;
            }
        }

        private void btn_paint_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel_my_color.BackColor = colorDialog.Color;
                my_brush = new SolidBrush(colorDialog.Color);
                my_color = colorDialog.Color;
            //    draw_grid();
            }
        }
    }
}
