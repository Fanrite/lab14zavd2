using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Inputdata;

namespace lab14zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            const int n = 5; 
            const int m = 5;
            while (flag)
            {
                string output = "";
                int[,] arr = new int[n, m];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        Input.Inint(ref arr[i, j], $"Введіть arr[{i},{j}]");

                output += "Вхідний массив:\n";
                Input.Printer(arr, n, m, ref output);
                output += "\n\n";

                double buf = arr[0,0];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (arr[i, j] < buf)
                            buf = arr[i, j];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (arr[i, j] == buf)
                            arr[i, j] = 0;

                output += "Вихідний массив:\n";
                Input.Printer(arr, n, m, ref output);


                //exit or begin 
                if (MessageBox.Show(output + "\n\nПовторити?", "Результат", MessageBoxButtons.YesNo) == DialogResult.No)
                    flag = false;
            }
        }
    }
}
