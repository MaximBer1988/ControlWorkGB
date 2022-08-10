string[] array = { "Geek", "Brains", "is", "ok", "for", "sure" };
string[] resultarray = new string[6];
for (int i = 0; i < 6; i++)
{
    if (array[i].Length <= 3)
    {
        resultarray[i] = array[i];

    }
    else
    resultarray[i] = string.Empty;

}
Console.Write($"Массив с элементами длиной до 3: [{String.Join(", ", resultarray)}]");
Console.WriteLine();

var selectresultarray = resultarray.Where(p => p.Length >0); 
 

    Console.WriteLine($"Массив без пустых элементов: [{String.Join(", ", selectresultarray)}]");