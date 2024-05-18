//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[] {"Hello", "2", "world", ":-)"};
string[] result=new string[array.Length];
int index=0;

for (index=0;index < array.Length;index++)
{
    // Console.Write(array[index]+" "+ array[index].Length +", ");
    if(array[index].Length <= 3){
        Console.WriteLine(array[index]);
    }
}
