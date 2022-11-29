/* Первая часть лекции
// Console.Clear();

// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1();
// // Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // Увеличение счетчика на единицу называют инкремент
//     }
// }

// // Method21(count: 4, msg: "Текст");

// // Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();

// // Console.WriteLine(year);

// // Вид 4

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count) // Используем цикл while
// //     {
// //         result +=text;
// //         i++;
// //     }
// //     return result;
// // }

// // string res = Method4(10,"z");
// // Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result +=text;
//     }
//     return result;
// }

// string res = Method4(10,"z");
// // Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
// Console.WriteLine();
// }
*/

/*=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”. // сделаю наоборот)

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";               
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine();
Console.WriteLine(newText);

newText = Replace(newText, 'к', 'К');
Console.WriteLine();
Console.WriteLine(newText);

newText = Replace(newText, 'с', 'С');
Console.WriteLine();
Console.WriteLine(newText);
*/

/* Алгоритм сортировки методом минимакса - описание
Есть какая-то последовательность чисел.
Наша задача — выбрать самый первый элемент и в оставшейся 
части, с учётом нашей текущей позиции определить минимальный.
После того как он найден, нужно поменять выделенный (рабочий элемент),
на который сейчас указывает стрелочка, это 6, с единицей, являющейся
для нас минимальной, в общем, выделенном куске.

Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7

Поменяли.

Дальше у нас следующий шаг, который будет выбирать очередной рабочий элемент для нас.
Это теперь 8. Мы явно указываем то, что 1 уже отсортированы к ней больше касаться не нужно.
Дальше наша задача во всём неотсортированном кусочке выбрать снова минимальный.
Поменять его местами с рабочим.

Было: 1 8 3 2 6 4 5 7
Стало: 1 2 3 8 6 4 5 7

В таком случае получается подмассив или кусок массива из первых двух элементов отсортирован.
Дальше переходим к следующему элементу, снова находим минимальный, и
здесь получается так, что нам ничего ни с чем менять не нужно, то есть, он остаётся на своей
позиции.

На следующем этапе переходим к следующему рабочему элементу.
Снова находим минимальный, снова меняем их местами, таким образом, мы продолжаем до того момента,
пока весь массив не будет отсортирован.

Результат: 1 2 3 4 5 6 7 8

На самом деле мы сами указали достаточно много действий, но в то же время они могут быть
выражены тремя пунктами.

1. Найти позицию минимального элемента в неотсортированной части массива.
2. Произвести обмен этого значения со значением первой неотсортированной позиции.
3. Повторять пока есть неотсортированные элементы.
*/


Console.Clear();                                                        // Очистили консоль

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };                              // Задали массив

void PrintArray(int[] array)                                            // Объявили создание невозвратного метода PrintArray - печать массива
{
    int count = array.Length;                                           // Объявили конец счетчика равным длине массива
    
    for (int i = 0; i < count; i++)                                     // Цикл for: объявили начало счетчика, конец счетчика, инкремент (i++)
    {
        Console.Write($"{array[i]}\t");                                 // Вывели на экран элемент массива + символ табуляции
    }
    Console.WriteLine();                                                // Разделительная строка
}

void SelectionSortMin(int[] array)                                      // Объявили создание невозвратного метода сортировки массива Минимум
{
    for (int i = 0; i < array.Length - 1; i++)                          // Цикл for от i = 0 до i < длинны массива - 1, инкремент (i++)
    {
        int minPosition = i;                                            // Объявили переменную minPosition и поместили в неё текущий индекс
                                                                        //     
        for (int j = i + 1; j < array.Length; j++)                      // Цикл for от j = i + 1 до j < длинны массива, инкремент (j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;         // Цикл Если j-элемент массива меньше minPos-элемента тогда
        }                                                               // перезапишем номер j в переменную minPosition

        int temporary = array[i];                                       // Объявим переменную temporary и поместим в неё текущее значение элемента массива
        array[i] = array[minPosition];                                  // Запишем в текущую ячейку значение ячейки с индексом minPosition, из цикла Если
        array[minPosition] = temporary;                                 // Вернём текущее значение элемента массива на место элемента с индексом minPosition
    }
}

void SelectionSortMax(int[] array)                                      // Смотри описание Метода Минимум)))
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);        // Выводим первоначальный массив

SelectionSortMin(arr);  // Вызываем Метод сортировки минимакса - Минимум

PrintArray(arr);        // Выводим отсортированный от Минимума массив

SelectionSortMax(arr);  // Вызываем Метод сортировки минимакса - Максимум

PrintArray(arr);        // Выводим отсортированный от Максимума массив