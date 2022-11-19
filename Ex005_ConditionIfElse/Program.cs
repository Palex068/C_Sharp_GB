Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "Маша")        // Добавили метод sting.ToLower() - возвращиет 
                                        // копию этой строки, переведенную в нижний регистр.
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}