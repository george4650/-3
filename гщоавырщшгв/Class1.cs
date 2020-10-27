using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace гщоавырщшгв
{
    public class Class1
    {
        public static double Summ(DataGridView table, out int  stroka, out int  stolb)
        {
            int sum = 0;
            int koll=0,srednee,ostatok,ostatok1,rez;
            stroka = 0; stolb = 0;
            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.RowCount; j++)
                {
                    koll++;
                    sum += Convert.ToInt32(table[i, j].Value);
                }
                     srednee = sum/koll;

            ostatok1 = Math.Abs(Convert.ToInt32(table[0, 0].Value) - srednee);
            rez = Convert.ToInt32(table[0, 0].Value);

            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.RowCount; j++)
                {
                    ostatok = Math.Abs(Convert.ToInt32(table[i, j].Value) - srednee);
                    if (ostatok1 > ostatok)
                    {
                        ostatok1 = ostatok; 
                        rez = Convert.ToInt32(table[i, j].Value);
                        stroka = j;
                        stolb = i;
                    }
                }       
            return rez;
        }
    }
}
