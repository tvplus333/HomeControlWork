
internal class Program
{
    private static void Main(string[] args)
    {
        // Просим пользователя ввести исходный массив с помощью клавиатуры
        Console.WriteLine("Пожалуйста, введите все элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        // Далее подсчитываем кол-во строк, в которых длина <= трем символам
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Готовим новый массив необходимого размера
        string[] resultArray = new string[count];

        // Далее заполняем подготовленный массив
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        // Выводим массив в строку (через запятую)
        Console.WriteLine("Результат: ");
        Console.WriteLine(string.Join(", ", resultArray));

    }
}