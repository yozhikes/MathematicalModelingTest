using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathematicalModelingTestByMidili.Forms
{
    public partial class TestForm : Form
    {
        string[,] answers = { {"изучения свойств реальных объектов в рамках поставленной\n задачи ",
            "упрощения поставленной задачи ","поиска физической модели ",
                "принятия решения в рамках поставленной задачи"},
            {"оригинал","копия","шаблон","макет" },
            {"симплекс-метод","метод множителей Лагранжа","метод хорд","метод половинного деления" },
            {"рекуррентные функциональные уравнения Беллмана","функции Лагранжа","штрафные функции",
                "сечения Гомори" },
            {"из конечного числа каналов","из диспетчера и генератора заявок",
                "из очереди и диспетчера","нет правильного ответа" },
            {"динамического программирования","нелинейного программирования","линейного программирования",
                "целочисленного программирования" },
            { "многошаговых задач",
                "задач, которые нельзя представить в виде последовательности\n отдельных шагов",
                "только задач линейного программирования", "задач макроэкономики" },
            { "материальная точка ", "идеальный газ ", "квантовый осциллятор ", "ни одна из предложенных " },
            { "2", "3", "4", "нет правильного ответа" },
            { "построение натурной модели ", "поиск закономерностей поведения объекта (системы) ",
                "корректировка построенной модели ",
                "построение алгоритма, моделирующего поведение\n объекта (системы) " },
            { "если ее целевая функция и ограничения линейны", "если ее целевая функция линейна",
                "если ее ограничения линейны", "нет правильного ответа" },
            { "нахождение первого опорного плана", "нахождение первого псевдоплана",
                "нахождение первого условно-оптимального плана", "нахождение первого базисного решения" },
            { "принцип оптимальности Беллмана", "принцип максимума Понтрягина", "принцип симметрии",
                "принцип максимума правдоподобия" },
            { "последний шаг", "первый шаг", "как сказано в условии задачи", "предпоследний шаг" },
            { "с учетом последствий в будущем", "с учетом предшествующих шагов",
                "наилучшим для данного шага", "лучше, чем предыдущее" }};
        string[] questions = { "1.Математическое моделирование это средство для",
            "2.Как называется замещаемый моделью объект?",
            "3.Какой метод относится к методам решения задач\n линейного программирования",
            "4.При решении задачи динамического программирования\n строятся:",
            "5.Из чего состоит узел обслуживания в СМО",
            "6.Задача о замене оборудования является задачей ",
            "7.Метод динамического программирования применяется\n для решения",
            "8.Какая математическая модель не относится к\n стохастическим?",
            "9.Сколько классов моделей существует?",
            "10.Что не входит в предмет математического\n моделирования?",
            "11.В каком случае задача математического\n программирования является линейной?",
            "12.Первым шагом алгоритма метода потенциалов\n является:",
            "13.Для решения задачи динамического программирования\n используется:",
            "14.В процессе динамического программирования раньше\n всех планируется",
            "15.В задачах динамического программирования шаговое\n управление должно выбираться"};
        public int[] rndnums = { 0, 1, 2, 3 };
        int i = 0;
        public int right = 0;
        public int wrong = 0;
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Shuffle(rndnums);
            titleLbl.Text = questions[i];
            ans1.Text = answers[i, rndnums[0]];
            ans2.Text = answers[i, rndnums[1]];
            ans3.Text = answers[i, rndnums[2]];
            ans4.Text = answers[i, rndnums[3]];
        }
        void Shuffle<T>(T[] array)
        {
            var r = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = r.Next(i);
                T t = array[i];
                array[i] = array[j];
                array[j] = t;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(ans1.Checked|| ans2.Checked || ans3.Checked || ans4.Checked)
            {
                if (nextBtn.Text == "ПРОВЕРИТЬ")
                {
                    if (ans1.Text == answers[i, 0] && ans1.Checked)
                    {
                        right++;
                        ans1.BackColor = Color.Green;
                    }
                    else if (ans2.Text == answers[i, 0] && ans2.Checked)
                    {
                        right++;
                        ans2.BackColor = Color.Green;
                    }
                    else if (ans3.Text == answers[i, 0] && ans3.Checked)
                    {
                        right++;
                        ans3.BackColor = Color.Green;
                    }
                    else if (ans4.Text == answers[i, 0] && ans4.Checked)
                    {
                        right++;
                        ans4.BackColor = Color.Green;
                    }
                    else if (ans1.Text != answers[i, 0] && ans1.Checked)
                    {
                        wrong++;
                        ans1.BackColor = Color.Red;
                    }
                    else if (ans2.Text != answers[i, 0] && ans2.Checked)
                    {
                        wrong++;
                        ans2.BackColor = Color.Red;
                    }
                    else if (ans3.Text != answers[i, 0] && ans3.Checked)
                    {
                        wrong++;
                        ans3.BackColor = Color.Red;
                    }
                    else if (ans4.Text != answers[i, 0] && ans4.Checked)
                    {
                        wrong++;
                        ans4.BackColor = Color.Red;
                    }
                    nextBtn.Text = "ДАЛЕЕ";
                    if (i == questions.Length - 1)
                    {
                        nextBtn.Text = "ЗАВЕРШИТЬ";
                    }
                }
                else
                {
                    if (ans1.Checked)
                    {
                        ans1.Checked = false;
                        ans1.BackColor = Color.White;
                    }
                    else if (ans2.Checked)
                    {
                        ans2.Checked = false;
                        ans2.BackColor = Color.White;
                    }
                    else if (ans3.Checked)
                    {
                        ans3.Checked = false;
                        ans3.BackColor = Color.White;
                    }
                    else if (ans4.Checked)
                    {
                        ans4.Checked = false;
                        ans4.BackColor = Color.White;
                    }
                    i++;
                    if (i == questions.Length)
                    {
                        ResultForm res = new ResultForm(wrong, right);
                        Hide();
                        res.Show();
                    }
                    else
                    {
                        Shuffle(rndnums);
                        titleLbl.Text = questions[i];
                        ans1.Text = answers[i, rndnums[0]];
                        ans2.Text = answers[i, rndnums[1]];
                        ans3.Text = answers[i, rndnums[2]];
                        ans4.Text = answers[i, rndnums[3]];
                        nextBtn.Text = "ПРОВЕРИТЬ";
                    }
                }
            }
        }
    }
}
