Console.WriteLine("Введите строку и мы посчитаем сколько в знаков пунктуации");
string str = Console.ReadLine();
string pattern = ".,;:!?";
int i = 0;
foreach (char item in str)
{
    if(pattern.Contains(item))
    {
        i++;
    }
}
Console.WriteLine(i);
