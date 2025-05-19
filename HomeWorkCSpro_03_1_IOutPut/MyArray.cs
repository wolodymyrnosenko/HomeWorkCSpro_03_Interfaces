using System;
using HomeWorkCSpro_03_1_IOutPut_2_IMath;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWorkCSpro_03_1_IOutPut_2_IMath_3_ISort
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] Array { get; set; }

        public MyArray(int[] array)
        {
            Array = array;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int item in Array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"{Environment.NewLine.PadLeft(50, '-')}{info}");
            Show();
        }

        public int Max()
        {
            return Array.Max();
        }

        public int Min()
        {
            return Array.Min();
        }

        public float Avg()
        {
            return (float)Array.Average();
        }

        public bool Search(int valueToSearch)
        {
            return Array.Contains(valueToSearch);
        }

        public void SortAsc()
        {
            System.Array.Sort(Array);
        }

        public void SortDesc()
        {
            //System.Array.Sort(Array);
            SortAsc();
            System.Array.Reverse(Array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }
    }
}
