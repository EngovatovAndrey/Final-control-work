/* Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, 
длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции, 
лучше обойтись исключительно массивами. 

Примеры:
['hello', '2', 'world', ':-)'] -> ['2', ':-)']
['1234', '1567', '-2', 'computer science'] -> [ '-2' ]
['Russia', 'Denmark', 'Kazan'] -> [] 
*/

using static System.Console;
Clear();

WriteLine("Введите произвольное количество строк через пробел");
string[] userArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine("[{0}]", string.Join(", ", SmallArray(userArray)));

string[] SmallArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        { 
            count +=1;
        }
    } 
    string[] new_array = new string[count];
    int index = 0;
    for(int j = 0; j < array.Length; j++)
    {
        
        if (array[j].Length <= 3)
        { 
            new_array[index] = array[j];
            index +=1;
        }
    }
    return new_array;
}
