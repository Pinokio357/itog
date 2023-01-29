using System;



string[] array = { "hello", "12", "prog", "456", "hi" };

int index = 0;
int count = 0;
while (index < array.Length)
{
    if (array[index].Length <= 3)
        {
        count++;
    }
    index++;
}
Console.WriteLine(count);
string[] array2 = new string[count];
index = 0;
count = 0;
while (index < array.Length)
{
    if (array[index].Length <= 3)
    {
        array2[count] = array[index];
        count++;
    }
    index++;
}
index = 0;
Console.Write("[");
while (index < array2.Length)
{
    Console.Write($" {array2[index]}, ");
    index++;
}
Console.Write(']'); 
