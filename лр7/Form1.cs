using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр7
{
    public partial class Form1 : Form
    {
        public BaseObject who;
        public ChildObject child_who;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            who = new BaseObject();
            child_who = new ChildObject();
            MessageBox.Show("Создано 2 объекта");
            textBox2.Text = "Слева представлены свойства: дальность (*), вместимость (-), наименование (!), скорость (=), цена (^). В скобках представлены знаки, которые нужно ввести для задания значения свойств. Сначала в текстовом поле нужно ввести знак, присваиваемое значение без пробела и нажать на кнопку. Ещё раз увидеть это сообщение можно нажав на форму";
        }


        // Свойство: дальность
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.StartsWith("*"))
            {
                string line = textBox2.Text.Remove(0, 1);
                who.Range = double.Parse(line);
            }
            else
            {
                textBox2.Text = "Неверное заполнение";
            }

        }

        // Свойство: вместимость

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.StartsWith("-"))
            {
                string line = textBox2.Text.Remove(0, 1);
                who.Capacity = double.Parse(line);
            }
            else
            {
                textBox2.Text = "Неверное заполнение";
            }
        }

        // Свойство: наименование

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.StartsWith("!"))
            {
                string line = textBox2.Text.Remove(0, 1);
                child_who.Nickname = line;
            }
            else
            {
                textBox2.Text = "Неверное заполнение";
            }
        }

        // Свойство: скорость

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.StartsWith("="))
            {
                string line = textBox2.Text.Remove(0, 1);
                who.Speed = double.Parse(line);
                
            }
            else
            {
                textBox2.Text = "Неверное заполнение";
            }
        }

        // Свойство: цена

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.StartsWith("^"))
            {
                string line = textBox2.Text.Remove(0, 1);
                child_who.Price = double.Parse(line);
            }
            else
            {
                textBox2.Text = "Неверное заполнение";
            }
        }

        // Сообщение - навигация по свойствам

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Слева представлены свойства: дальность (*), вместимость (-), наименование (!), скорость (=), цена (^). В скобках представлены знаки, которые нужно ввести для задания значения свойств. Сначала в текстовом поле нужно ввести знак, присваиваемое значение без пробела и нажать на кнопку. Ещё раз увидеть это сообщение можно нажав на форму";
        }

        // Расчёт грузопотока - информация

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Введите в текстовое поле 2 числа через тире: массу и расстояние. Пример, 1000-1. Для получения расчёта нажмите на кнопку 'Вычисление'";
        }

        // Расчёт стоимости перевозки - информация

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Введите в текстовое поле 1 число - сколько килограмм весит груз. Свойству 'Цена' должно быть присвоено значение. Пример, 1000. Для получения расчёта нажмите на кнопку 'Вычисление'";
    }

        // Расчёт грузопотока и стоимости перевозки груза

        private void button1_Click(object sender, EventArgs e)
        {
            // Если тектовое поле содержит тире - рассчитывать грузопоток.
            // Иначе рассчитывается стоимость перевозки

            if (textBox2.Text.Contains("-"))
            {
                double[] values = new double[2];
                int j = 0;
                foreach (var i in textBox2.Text.Split('-'))
                {
                    values[j] = double.Parse(i);
                    j++;
                }
               textBox2.Text = who.CargoTurnover(values[0], values[1]).ToString();
            }
            else
            {
                double kilograms = double.Parse(textBox2.Text);
               textBox2.Text = child_who.CargoTurnover(child_who.Price, kilograms).ToString();
            }
            
        }

        // Получение информации о 2 объектах

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Информация о 2 объектах: основном и дочернем." + $"Дальность: {Convert.ToString(who.Range)}. Вместимость: {who.Capacity.ToString()}. Скорость: {who.Speed.ToString()}. Наименование: {child_who.Nickname}. Цена: {child_who.Price.ToString()}.";
        }
    }
}
