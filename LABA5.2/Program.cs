//Для заданной строки определить входит ли в нее хотя бы 1 латинская буква
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        bool containsLatinLetter = input.Any(c => char.IsLetter(c) &&
                                     (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z'));
        if (containsLatinLetter)
        {
            Console.WriteLine("Строка содержит хотя бы одну латинскую букву.");
        }
        else
        {
            Console.WriteLine("Строка не содержит латинских букв.");
        }
    }
}