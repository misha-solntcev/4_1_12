using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 12
Даны три целочисленных массива A(N), В(М) и C(L). Найдите хотя бы одно число,
встречающееся во всех трех массивах. Если таких чисел нет, выведите соответствующее
сообщение.*/

namespace _4_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            int[] A = new int[N] { 1, 2, 3, 5, 8 };
            const int M = 7;
            int[] B = new int[M] { 9, 10, 11, 12, 13, 14, 15 };
            const int L = 3;
            int[] C = new int[L] { 6, 7, 8, };

            bool flag = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    if (A[i] == B[j])
                        for (int k = 0; k < L; k++)
                            if (B[j] == C[k])
                            {
                                Console.WriteLine($"Найдено число {C[k]}");
                                flag = true;
                            }
            }
            if (!flag)
                Console.WriteLine("Встречающихся 3 раза чисел нет.");
            Console.ReadKey();
        }
    }
}
