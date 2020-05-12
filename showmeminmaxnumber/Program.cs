using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("숫자를 입력해주세요 >> ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }

            int min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }

            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
