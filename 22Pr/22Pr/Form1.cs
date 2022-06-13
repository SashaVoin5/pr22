using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Pr
{
    public partial class Form_Moving : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100); //нарисуем фигуры - X и Y, вторые – ширина и высота  
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool RectangleClicked = false; //переменные для проверки «клика»
        bool CircleClicked = false;
        bool SquareClicked = false;

        int RectangleX = 0; //переменные для фиксирования координат
        int RectangleY = 0;

        int CircleX = 0;
        int CircleY = 0;

        int SquareX = 0;
        int SquareY = 0;

        int X, Y, dX, dY;

        private void pictureBox_Moving_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle); //закрашивем цвета
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);


            switch (LastClicked) //план фигур,просто заливаем ее и она встает на переднйи план
            {
                case 1:
                    {
                        e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                        break;
                    }
                case 2:
                    {
                        e.Graphics.FillEllipse(Brushes.Red, Circle);
                        break;
                    }
                case 3:
                    {
                        e.Graphics.FillRectangle(Brushes.Blue, Square);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void pictureBox_Moving_MouseMove(object sender, MouseEventArgs e)
        {
            if (CircleClicked) //проверка какой сейчас перетаскивается и присковить координаты (в mousedown)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }

            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }

            if (SquareClicked)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }

            pictureBox_Moving.Invalidate();

            if ((label_Define.Location.X < Square.X + Square.Width) && (label_Define.Location.X > Square.X))
            {
                if ((label_Define.Location.Y < Square.Y + Square.Height) && (label_Define.Location.Y > Square.Y))
                {
                    label_Showing.Text = "Синий квадрат";
                }
            }

            if ((label_Define.Location.X < Circle.X + Circle.Width) && (label_Define.Location.X > Circle.X))
            {
                if ((label_Define.Location.Y < Circle.Y + Circle.Height) && (label_Define.Location.Y > Circle.Y))
                {
                    label_Showing.Text = "Красный круг";
                }
            }

            if ((label_Define.Location.X < Rectangle.X + Rectangle.Width) && (label_Define.Location.X > Rectangle.X))
            {
                if ((label_Define.Location.Y < Rectangle.Y + Rectangle.Height) && (label_Define.Location.Y > Rectangle.Y))
                {
                    label_Showing.Text = "Желтый прямоугольник";
                }
            }
        }

        private void pictureBox_Moving_MouseUp(object sender, MouseEventArgs e)
        {
            CircleClicked = false;  //все фигуры не "кликнуты"
            RectangleClicked = false;
            SquareClicked = false;
            switch (LastClicked) //для смены фигур местами
            {
                case 1: //если первая (квадрат) фигура то меняем ее местами с кругом
                {
                    if ((label_Changing.Location.X < Rectangle.X + Rectangle.Width) && (label_Changing.Location.X > Rectangle.X))
                    {
                        if ((label_Changing.Location.Y < Rectangle.Y + Rectangle.Height) && (label_Changing.Location.Y > Rectangle.Y))
                        {
                            X = Rectangle.X;
                            Y = Rectangle.Y;
                            dX = RectangleX;
                            dY = RectangleY;
                            Rectangle.X = Circle.X;
                            Rectangle.Y = Circle.Y;
                            RectangleX = CircleX;
                            RectangleY = CircleY;

                            Circle.X = X;
                            Circle.Y = Y;
                            CircleX = dX;
                            CircleY = dY;

                        }
                    }
                    break;
                    }
                case 2:
                {
                    if ((label_Changing.Location.X < Circle.X + Circle.Width) && (label_Changing.Location.X > Circle.X))
                    {
                        if ((label_Changing.Location.Y < Circle.Y + Circle.Height) && (label_Changing.Location.Y > Circle.Y))
                        {
                            X = Circle.X;
                            Y = Circle.Y;
                            dX = CircleX;
                            dY = CircleY;
                            Circle.X = Square.X;
                            Circle.Y = Square.Y;
                            CircleX = SquareX;
                            CircleY = SquareY;

                            Square.X = X;
                            Square.Y = Y;
                            SquareX = dX;
                            SquareY = dY;
                        }
                    }
                    break;
                }
                case 3:
                {
                    if ((label_Changing.Location.X < Square.X + Square.Width) && (label_Changing.Location.X > Square.X))
                    {
                        if ((label_Changing.Location.Y < Square.Y + Square.Height) && (label_Changing.Location.Y > Square.Y))
                        {
                            X = Square.X;
                            Y = Square.Y;
                            dX = SquareX;
                            dY = SquareY;
                            Square.X = Circle.X;
                            Square.Y = Circle.Y;
                            SquareX = CircleX;
                            SquareY = CircleY;

                            Circle.X = X;
                            Circle.Y = Y;
                            CircleX = dX;
                            CircleY = dY;
                        }
                    }
                    break;
                }

            }
        }

        int LastClicked = 0;
        public Form_Moving()
        {
            InitializeComponent();
        }

        private void pictureBox_Moving_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))  //фиксирование изменение координат
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))  //кординаты машины > или <  координат фигуры
                {
                    RectangleClicked = true;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                    LastClicked = 1; 
                }
            }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                    LastClicked = 2; //фигура круг
                }
            }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                    LastClicked = 3;
                }
            }

        }
    }
}
