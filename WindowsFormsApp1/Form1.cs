using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double x, y, sum; //переменные для действий
        double z_memory; //переменная второй памяти
        int operation; //номер действия
        int memory = 0; //проверить действие для второй памяти
        bool op = false; //проверка нажаной клавиши действия
        bool ex = false; //проверить экспоненту для х
        bool act; //проверить экспоненту для у
        string str; //строка для вывода в форму_2

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e) //кнопка очистки
        {
            textBox1.Clear();
            label1.Text = "";
            label2.Text = "";
            memory = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e) //конопка 0
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 0;
        }

        private void button9_Click(object sender, EventArgs e) //конопка 1
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e) //конопка 2
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e) //конопка 3
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e) //конопка 4
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e) //конопка 5
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e) //конопка 6
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e) //конопка 7
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e) //конопка 8
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e) //конопка 9
        {
            memory = 0;
            label2.Text = "";
            textBox1.Text = textBox1.Text + 9;
        }

        private void button32_Click(object sender, EventArgs e) //действие сложения
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 1;
                label1.Text = "e + ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 1;
                label1.Text = x.ToString() + " + ";
            }
            op = true;
        }

        private void button10_Click(object sender, EventArgs e) //вызов кнопки равно
        {
            if (act == false)
            {
                op = false;
                y = double.Parse(textBox1.Text);
                textBox1.Clear();
                Calk();
                act = false;
            }
            else if (act == true)
            {
                op = false;
                textBox1.Clear();
                Calk();
                act = false;
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e) //кнопка дробной части
        {
            label2.Text = "";
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e) //очистить всё
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text="";
            label2.Text = "";
            str = "";
        }

        private void button31_Click(object sender, EventArgs e) //действие вычитания
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 2;
                label1.Text = "e - ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 2;
                label1.Text = x.ToString() + " - ";
            }
            op = true;
        }

        private void button30_Click(object sender, EventArgs e) //действие умножения
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 3;
                label1.Text = "e * ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 3;
                label1.Text = x.ToString() + " * ";
            }
            op = true;
        }

        private void button29_Click(object sender, EventArgs e) //действие деления
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 4;
                label1.Text = "e / ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 4;
                label1.Text = x.ToString() + " / ";
            }
            op = true;
        }

        private void button20_Click(object sender, EventArgs e) //действие возведения в степень
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 5;
                label1.Text = "e ^ ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 5;
                label1.Text = x.ToString() + " ^ ";
            }
            op = true;
        }

        private void button19_Click(object sender, EventArgs e) //действие 1/х
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 6;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 6;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button28_Click(object sender, EventArgs e) //действие синус
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 7;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 7;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button27_Click(object sender, EventArgs e) //действие косинус
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 8;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 8;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button26_Click(object sender, EventArgs e) //действие тангенс
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 9;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 9;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button25_Click(object sender, EventArgs e) //действие катангенс
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 10;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 10;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e) //действие факториал
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 11;
            Calk();
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button22_Click(object sender, EventArgs e) //вызов экспоненты
        {
            if (op == false)
            {
                x = Math.Exp(1);
                textBox1.Text = "e";
                ex = true;
            }
            else if (op == true)
            {
                y = Math.Exp(1);
                textBox1.Text = "e";
                act = true;
            }

        }

        private void button24_Click(object sender, EventArgs e) //действие с логарифмом
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 12;
                label1.Text = "ln ";
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text); 
                textBox1.Clear();
                operation = 12;
                label1.Text = "log " + x.ToString();
            }
            op = true;
        }

        private void button23_Click(object sender, EventArgs e) //действие с натуральным логарифмом
        {
            if (ex == true)
            {
                textBox1.Clear();
                operation = 13;
                Calk();
                ex = false;
            }
            else
            {
                x = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = 13;
                Calk();
            }
            memory = 1;
            if (memory == 1)
            {
                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void button33_Click(object sender, EventArgs e) //запомнить число
        {
            if (memory == 0)
            {
                if (op == false)
                {
                    z_memory = double.Parse(textBox1.Text);
                }
                else if (op == true)
                {
                    z_memory = double.Parse(textBox1.Text);
                }
            }
            else if (memory == 1)
            {
                z_memory = sum;
            }
        }

        private void button17_Click(object sender, EventArgs e) //вывод числа из памяти на экран
        {
            textBox1.Clear();
            label2.Text = "";
            textBox1.Text = z_memory.ToString();
        }

        private void button18_Click(object sender, EventArgs e) //удаление числа из памяти
        {
            z_memory = default(double); 
        }

        private void button15_Click(object sender, EventArgs e) //прибавление числа на экране к числу в памяти
        {
            if (memory == 0)
            {
               z_memory += double.Parse(textBox1.Text);
            }
            else if (memory == 1)
            {
                z_memory += sum;
            }
        }

        private void button16_Click(object sender, EventArgs e) //вычитание числа на экране из числа в памяти
        {
            if (memory == 0)
            {
                z_memory -= double.Parse(textBox1.Text);
            }
            else if (memory == 1)
            {
                z_memory -= sum;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //тесткбокс_1
        {
            if(textBox1.TextLength == 0 & memory == 0)
            {
                button10.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
                button31.Enabled = false;
                button32.Enabled = false;

                button15.Enabled = false;
                button16.Enabled = false;
                button33.Enabled = false;
            }
            else if(textBox1.TextLength == 0 & memory == 1)
            {
                button10.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
                button31.Enabled = false;
                button32.Enabled = false;

                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
            else
            {
                button10.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
                button26.Enabled = true;
                button27.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
                button31.Enabled = true;
                button32.Enabled = true;

                button15.Enabled = true;
                button16.Enabled = true;
                button33.Enabled = true;
            }
        }

        public void Calk() //реализация действий
        {
            switch (operation) 
            {
                case 1:
                    sum = x + y;
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + " + " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double); //обнуление переменных
                    y = default(double); //обнуление переменных
                    break;
                case 2:
                    sum = x - y;
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + " - " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 3:
                    sum = x * y;
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + " * " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 4:
                    sum = x / y;
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + " / " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 5:
                    sum = Math.Pow(x,y);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + " ^ " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 6:
                    sum = 1/x;
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "1" + " / " + x.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 7:
                    sum = Math.Sin(x);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "sin(" + x.ToString() + ")" + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 8:
                    sum = Math.Cos(x);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "cos(" + x.ToString() + ")" + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 9:
                    sum = Math.Tan(x);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "tg(" + x.ToString() + ")" + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 10:
                    sum = 1.0 / Math.Tan(x);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "ctg(" + x.ToString() + ")" + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 11:
                    int a = 1;
                    for(int i = 1; i <= x; i++)
                    {
                        a *= i;
                        sum = a;
                    }
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + x.ToString() + "!" + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 12:
                    sum = Math.Log(y,x);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "log " + x.ToString() + " от " + y.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;
                case 13:
                    sum = Math.Log(x, Math.E);
                    label1.Text = "";
                    label2.Text = sum.ToString();
                    str = str + "ln " + x.ToString() + " = " + sum + Environment.NewLine;
                    textBox2.Text = str;
                    x = default(double);
                    y = default(double);
                    break;

                default:
                    break;
            }

        }
    }
}
