//int numberA = 4; 
int numberA = new Random().Next(1,10);  //Добавим генератор случайных чисел
                                        //c выводом от 1 до 9 (включительно)
//int numberB = 5;
int numberB = new Random().Next(1,10);  //Добавим генератор случайных чисел
                                        //c выводом от 1 до 9 (включительно)
int result = numberA + numberB;

Console.WriteLine(" ");
Console.WriteLine(numberA);
Console.WriteLine("+");
Console.WriteLine(numberB);
Console.WriteLine("=");
Console.WriteLine(result);
Console.WriteLine(" ");
