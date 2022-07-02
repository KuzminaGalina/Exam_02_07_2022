// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которым меньше либо равна 3 символам.

string[] NewArray(string[] EnterArray, int simbolLength)
{
    int j = 0;
    for (int i = 0; i < EnterArray.Length; i++)
    {
        if (EnterArray[i].Length <= simbolLength)
        {
            j++;
        }
    }
    string[] result = new string[j];
    int k = 0;
    for (int i = 0; i < EnterArray.Length; i++)
    {
        if (EnterArray[i].Length <= simbolLength)
        {
            result[k] = EnterArray[i];
            k++;
        }
    }
    return result;
}

void printArray(string[] Array)
{
   Console.Write("["); 
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < Array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string [] Data = {"2", "нетy", "привет"};
int M = 3;
string [] Array = NewArray(Data, M);
printArray(Array);
