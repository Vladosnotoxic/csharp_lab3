using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат #1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50, Height = 50
            },
            new Rectangle()
            {
                Name = "Квадрат #2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60, 100),
                Width = 100, Height = 100
            },
            new Rectangle()
            {
                Name = "Прямоугольник #1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200, 200),
                Width = 100, Height = 50
            },
            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Violet,
                Position = new System.Drawing.Point(200, 400),
                Raduis = 100
            },
            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(330, 170),
                Height = 100, Bottom = 200
            },
            new Trapeze()
            {
                Name = "Трапеция",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(575,130),
                Bottom = 150, Height = 65, Top = 100
            },
            new Square()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Purple,
                Position = new System.Drawing.Point(200,50),
                Side = 100
            },
            new Rhomb()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(100,500),
                Diagonalone = 100, Diagonaltwo = 150
            },
            new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = System.Drawing.Color.CadetBlue,
                Position = new System.Drawing.Point(520,320),
                Side = 130, Height= 70
            },
            new Penta()
            {
                Name = "Пятиугольник",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(400,450),
                Side = 70
            },
            new Deca()
            {
                Name = "Десятиугольник",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(600,450),
                Side = 70
            }

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лаборатораня работа №3 - Полиморфизм");
            Console.WriteLine("Выполнил студент группы ВИС-31 Солтанов Владислав");
            Figure f = new Rectangle()
            {
                Name = "Квадрат #1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            };
            Figure b = new Rectangle()
            {
                Name = "Квадрат #2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60, 100),
                Width = 100,
                Height = 100
            };
            Figure a = new Rectangle()
            {
                Name = "Прямоугольник #1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200, 200),
                Width = 100,
                Height = 50
            };
            Figure d = new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Violet,
                Position = new System.Drawing.Point(200, 400),
                Raduis = 100
            };
            Figure i = new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(330, 170),
                Height = 100,
                Bottom = 200
            };
            Figure c = new Trapeze()
            {
                Name = "Трапеция",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(575, 130),
                Bottom = 150,
                Height = 65,
                Top = 100
            };
            Figure k = new Square()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Purple,
                Position = new System.Drawing.Point(200, 50),
                Side = 100
            };
            Figure p = new Rhomb()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(100, 500),
                Diagonalone = 100,
                Diagonaltwo = 150
            };
            Figure z = new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = System.Drawing.Color.CadetBlue,
                Position = new System.Drawing.Point(520, 320),
                Side = 130,
                Height = 70
            };
            Figure x = new Penta()
            {
                Name = "Пятиугольник",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(400, 450),
                Side = 70
            };
            Figure j = new Deca()
            {
                Name = "Десятиугольник",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(600, 450),
                Side = 70
            };
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + f.Name);
            Console.WriteLine("Площадь: " + f.GetArea());
            Console.WriteLine("Цвет: " + f.Color);
            Console.WriteLine("Положение фигуры: " + f.Position);
            Console.WriteLine("Координаты центра: " + f.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + b.Name);
            Console.WriteLine("Площадь: " + b.GetArea());
            Console.WriteLine("Цвет: " + b.Color);
            Console.WriteLine("Положение фигуры: " + b.Position);
            Console.WriteLine("Координаты центра: " + b.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + a.Name);
            Console.WriteLine("Площадь: " + a.GetArea());
            Console.WriteLine("Цвет: " + a.Color);
            Console.WriteLine("Положение фигуры: " + a.Position);
            Console.WriteLine("Координаты центра: " + a.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + d.Name);
            Console.WriteLine("Площадь: " + d.GetArea());
            Console.WriteLine("Цвет: " + d.Color);
            Console.WriteLine("Положение фигуры: " + d.Position);
            Console.WriteLine("Координаты центра: " + d.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + i.Name);
            Console.WriteLine("Площадь: " + i.GetArea());
            Console.WriteLine("Цвет: " + i.Color);
            Console.WriteLine("Положение фигуры: " + i.Position);
            Console.WriteLine("Координаты центра: " + i.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + c.Name);
            Console.WriteLine("Площадь: " + c.GetArea());
            Console.WriteLine("Цвет: " + c.Color);
            Console.WriteLine("Положение фигуры: " + c.Position);
            Console.WriteLine("Координаты центра: " + c.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + k.Name);
            Console.WriteLine("Площадь: " + k.GetArea());
            Console.WriteLine("Цвет: " + k.Color);
            Console.WriteLine("Положение фигуры: " + k.Position);
            Console.WriteLine("Координаты центра: " + k.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + p.Name);
            Console.WriteLine("Площадь: " + p.GetArea());
            Console.WriteLine("Цвет: " + p.Color);
            Console.WriteLine("Положение фигуры: " + p.Position);
            Console.WriteLine("Координаты центра: " + p.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + z.Name);
            Console.WriteLine("Площадь: " + z.GetArea());
            Console.WriteLine("Цвет: " + z.Color);
            Console.WriteLine("Положение фигуры: " + z.Position);
            Console.WriteLine("Координаты центра: " + z.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + x.Name);
            Console.WriteLine("Площадь: " + x.GetArea());
            Console.WriteLine("Цвет: " + x.Color);
            Console.WriteLine("Положение фигуры: " + x.Position);
            Console.WriteLine("Координаты центра: " + x.GetCenter());
            Console.WriteLine(" ");
            Console.WriteLine("Фигура: " + j.Name);
            Console.WriteLine("Площадь: " + j.GetArea());
            Console.WriteLine("Цвет: " + j.Color);
            Console.WriteLine("Положение фигуры: " + j.Position);
            Console.WriteLine("Координаты центра: " + j.GetCenter());

            Form frm = new Form()
            {
                Text = "Шикарная лаборатораня работа №3",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Paint += Frm_Paint;
            Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
