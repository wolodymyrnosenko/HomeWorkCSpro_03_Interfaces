using System.Text;

namespace HomeWorkCSpro_03_1_IOutPut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = { 10, 20, 36, 40, 50 };

            MyArray myArray = new MyArray(numbers);
            myArray.Show();
            myArray.Show("Метод Show() overload із строковим параметром");

            myArray.Show($"Максимум у масиві: {myArray.Max()}");
            myArray.Show($"Мінімум у масиві: {myArray.Min()}");
            myArray.Show($"Середнє арифметичне елементів масиву: {myArray.Avg()}");
            int searchNumber = 20;
            myArray.Show($"Наявність {searchNumber} у масиві - {myArray.Search(searchNumber)}");
            searchNumber = 45;
            myArray.Show($"Наявність {searchNumber} у масиві - {myArray.Search(searchNumber)}");
        }
    }
}