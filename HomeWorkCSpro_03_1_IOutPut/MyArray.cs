using System;

namespace HomeWorkCSpro_03_1_IOutPut
{
    public class MyArray : IOutput, IMath
    {
        public int[] Array { get; set; }

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
    }
}
