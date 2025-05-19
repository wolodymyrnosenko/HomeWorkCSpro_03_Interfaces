using System.Text;

namespace HomeWorkCSpro_03_1_IOutPut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = { 10, 20, 30, 40, 50 };

            MyArray myArray = new MyArray(numbers);
            myArray.Show();
            myArray.Show("Метод overload із строковим параметром");
        }
    }
}