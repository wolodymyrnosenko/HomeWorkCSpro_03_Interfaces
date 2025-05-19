using System.Text;
using HomeWorkCSpro_03_1_IOutPut_2_IMath_3_ISort;
using HomeWorkCSpro_03_1_IOutPut_2_IMath;

namespace HomeWorkCSpro_03_1_IOutPut_2_IMath_3_ISort
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

            int[] arraySort = { 40, 50, 10, 36, 20 };
            MyArray myArraySort = new MyArray(arraySort);
            myArraySort.Show("Початковий масив");
            myArraySort.SortAsc();
            myArraySort.Show("Сортування за зростанням");
            myArraySort.SortDesc();
            myArraySort.Show("Сортування за спаданням");
            myArraySort.SortByParam(true);
            myArraySort.Show("Сортування з параметром true (зростання)");
            myArraySort.SortByParam(false);
            myArraySort.Show("Сортування з параметром false (спадання)");
        }
    }
}
