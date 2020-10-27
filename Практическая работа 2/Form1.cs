using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using гщоавырщшгв;

namespace Практическая_работа_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Очистить
        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            
            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.RowCount; j++)
                    table[i, j].Value = " ";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.ColumnCount = 5;
            table.RowCount = 5;
        }
        //Кол-во значений
        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(M.Value);//Кол-во столбцов
            
        }
        //Выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Заполнить
        private void button4_Click(object sender, EventArgs e)
        {
            int RandMax = Convert.ToInt32(diapozon.Value);
            Random Rand = new Random();
            for (int i = 0; i < table.ColumnCount; i++) 
                for (int j = 0; j < table.RowCount; j++) 
                    table[i, j].Value = Rand.Next(RandMax); 
        }
        //рассчёт
        private void button1_Click(object sender, EventArgs e)
        {
            int stroka,stolb;
            double sum=гщоавырщшгв.Class1.Summ(table,out stroka,out stolb);
            rez.Text = sum.ToString();
            textBox1.Text = Convert.ToString(stroka);
            textBox2.Text = Convert.ToString(stolb);
          
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 3, 15 вариант\n" +
                "Дана матрица размера M × N. Найти номера строки и столбца для элемента матрицы, наиболее близкого к среднему значению всех ее элементов. \n" +
                "Бароян Гиоргий ИСП-31");
        }

        private void N_ValueChanged(object sender, EventArgs e)
        {
            table.RowCount = Convert.ToInt32(N.Value);//Кол-во строк
        }

        private void diapozon_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
