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
                count++
            }
        }