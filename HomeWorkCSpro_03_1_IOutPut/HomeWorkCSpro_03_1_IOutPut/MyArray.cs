using System;

namespace HomeWorkCSpro_03_1_IOutPut
{
    internal class MyArray : IOutput
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
            Console.WriteLine($"--------------------------------------{Environment.NewLine}{info}");
            Show();
        }
    }
}
