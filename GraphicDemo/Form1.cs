using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicDemo
{
    public partial class Form1 : Form
    {
        private int x = 15;
        Font Hello_font = new Font("Verdana", 14, FontStyle.Italic);
        RichTextBox refFontFormRTB;
        Form refCBForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Paint += Hello_World;
        }
        private void Hello_World(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            Graphics g = e.Graphics;
            //refFontFormRTB.
            
            Pen pn = new Pen(Brushes.BlueViolet, 20);
            var pn2 = new Pen(Brushes.DarkOrange, 4);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawEllipse(pn, x, 10, 300, 140);

            Point lt = new Point(x,10);
            Point rb = new Point(x + 300, 150);

            Rectangle rect = new Rectangle(x, 10, 200, 150);
            var myBrush = new LinearGradientBrush(lt, rb, Color.Yellow, Color.Blue);
            g.FillEllipse(myBrush, rect);

            string s = "Hello World!";
            //var _font = new Font("Verdana", 14, FontStyle.Italic);
            var _font = Hello_font;
            g.DrawString(s, _font, Brushes.DarkOrange, x + 50, 70);
            g.DrawLine(pn2, x + 45, 55, x + 45, 115);
            g.DrawLine(pn2, x + 45, 115, x + 245, 85);
            g.DrawLine(pn2, x + 45, 55, x + 245, 85);


        }
        private void DrawChess(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn1 = new Pen(Brushes.Black, 20);
            Pen pn2 = new Pen(Brushes.White, 20);
            Rectangle rec1 = new Rectangle(0, 10, 25, 20);
            Rectangle rec2 = new Rectangle(90, 10, 25, 20);
            Rectangle rec3 = new Rectangle(180, 10, 25, 20);
            Rectangle rec4 = new Rectangle(270, 10, 25, 20);
            Rectangle rec6 = new Rectangle(45, 50, 25, 20);
            Rectangle rec7 = new Rectangle(135, 50, 25, 20);
            Rectangle rec8 = new Rectangle(225, 50, 25, 20);
            Rectangle rec9 = new Rectangle(315, 50, 25, 20);
            Rectangle rec11 = new Rectangle(0, 90, 25, 20);
            Rectangle rec12 = new Rectangle(90, 90, 25, 20);
            Rectangle rec13 = new Rectangle(180, 90, 25, 20);
            Rectangle rec14 = new Rectangle(270, 90, 25, 20);
            Rectangle rec16 = new Rectangle(45, 130, 25, 20);
            Rectangle rec17 = new Rectangle(135, 130, 25, 20);
            Rectangle rec18 = new Rectangle(225, 130, 25, 20);
            Rectangle rec19 = new Rectangle(315, 130, 25, 20);
            Rectangle rec21 = new Rectangle(0, 170, 25, 20);
            Rectangle rec22 = new Rectangle(90, 170, 25, 20);
            Rectangle rec23 = new Rectangle(180, 170, 25, 20);
            Rectangle rec24 = new Rectangle(270, 170, 25, 20);
            Rectangle rec26 = new Rectangle(45, 210, 25, 20);
            Rectangle rec27 = new Rectangle(135, 210, 25, 20);
            Rectangle rec28 = new Rectangle(225, 210, 25, 20);
            Rectangle rec29 = new Rectangle(315, 210, 25, 20);
            Rectangle rec31 = new Rectangle(0, 250, 25, 20);
            Rectangle rec32 = new Rectangle(90, 250, 25, 20);
            Rectangle rec33 = new Rectangle(180, 250, 25, 20);
            Rectangle rec34 = new Rectangle(270, 250, 25, 20);
            Rectangle rec36 = new Rectangle(45, 290, 25, 20);
            Rectangle rec37 = new Rectangle(135, 290, 25, 20);
            Rectangle rec38 = new Rectangle(225, 290, 25, 20);
            Rectangle rec39 = new Rectangle(315, 290, 25, 20);

            Rectangle[] recs = new Rectangle[32]
            {
                rec1, rec2, rec3, rec4, rec6, rec7, rec8, rec9, 
                rec11, rec12, rec13, rec14, rec16, rec17, rec18, rec19, 
                rec21, rec22, rec23, rec24, rec26, rec27, rec28, rec29, 
                rec31, rec32, rec33, rec34, rec36, rec37, rec38, rec39
            };
            g.DrawRectangles(pn1, recs);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Refresh();
            //this.Paint -= DrawChess;
            //this.Paint += DrawChess;
            var _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = 30;
            bool move_right = true;
            _timer.Tick += (object sender02, EventArgs e02) =>
            {
                int xStep = 2;

                if ((x < 350) & (move_right))
                {
                    x += xStep;
                    this.Refresh();
                    this.Paint -= Hello_World;
                    this.Paint += Hello_World;
                }
                else
                {
                    Text = $"{x}";
                    move_right = false;
                }
                if ((x > 10) & (!move_right))
                {
                    x -= xStep;
                    this.Refresh();
                    this.Paint -= Hello_World;
                    this.Paint += Hello_World;
                }
                else
                {
                    Text = $"{x}";
                    move_right = true;
                }
            };
            _timer.Start();
        }

        private void buttonChangeFont_MouseClick(object sender, MouseEventArgs e)
        {
            InstalledFontCollection fontCollection = new InstalledFontCollection();
            var FontForm = new Form();
            var textBoxFont = new RichTextBox();
            refFontFormRTB = textBoxFont;
            var listBoxFont = new ListBox();
            var _locationTB = new Point(10, 10);
            var _locationLB = new Point(130, 10);
            var _size = new Size(120, 450);
            textBoxFont.Size = _size;
            textBoxFont.Location = _locationTB;
            listBoxFont.Location = _locationLB;
            listBoxFont.SelectedValueChanged += (object sender01, EventArgs e01) =>
            {
                Font _font = new Font(listBoxFont.SelectedItem.ToString(), 14, FontStyle.Italic);
                Hello_font = _font;
            };
            foreach (var item in fontCollection.Families)
            {
                textBoxFont.Text += $" {item.Name.ToString()}\n";
                listBoxFont.Items.Add(item.Name);
            }
            FontForm.Controls.Add(textBoxFont);
            FontForm.Controls.Add(listBoxFont);
            //Region region = new Region();
            FontForm.Show();
        }

        private void buttonClearRTB_MouseClick(object sender, MouseEventArgs e)
        {
            refFontFormRTB.Dispose();
        }
        private void ChessBoardPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rectHoriz = new Rectangle(30, 0, 60*8, 30);
            Rectangle rectVert = new Rectangle(0, 0, 30, 60*8);
            g.FillRectangle(Brushes.Pink, rectHoriz);
            g.FillRectangle(Brushes.Pink, rectVert);
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <= 7; i++)
                {
                    if (i % 2 != 0)
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30+60*j, 60, 60);
                        g.FillRectangle(Brushes.Khaki, rectCell);
                    }
                    else
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30+120*j, 60, 60);
                        g.FillRectangle(Brushes.Red, rectCell);
                    }
                    if (i % 2 != 0)
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30 + 60 * j, 60, 60);
                        g.FillRectangle(Brushes.Khaki, rectCell);
                    }
                    else
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30 + 120 * j, 60, 60);
                        g.FillRectangle(Brushes.Red, rectCell);
                    }
                }
            }
            //for(int i = (int)'A'; i <= (int)'H'; i++)
            //{
            //    string
            //    g.DrawString((char)i, _font)
            //}
        }
        private void buttonDrawChess_MouseClick(object sender, MouseEventArgs e)
        {
            var ChessBoardForm = new Form();
            refCBForm = ChessBoardForm;
            ChessBoardForm.Paint += ChessBoardPaint;
            ChessBoardForm.Text = "Chessboard";
            int boardCellMetric = 60;
            int boardServiceField = 30;
            int x = 2 * boardServiceField + 8 * boardCellMetric;
            int y = 2 * boardServiceField + 8 * boardCellMetric;
            var CBSize = new Size(x, y);
            ChessBoardForm.MinimumSize = ChessBoardForm.MaximumSize = ChessBoardForm.Size = CBSize;
            ChessBoardForm.Show();
        }
    }
}
