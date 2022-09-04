// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count=0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
{
    count++;
}
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");


void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{ 
 Console.WriteLine("[" +String.Join("; ", numbers)+"]");
}






// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 6;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for(int a = 0; a < numbers.Length; a += 2)
{
    sum = sum + numbers[a];
}

Console.WriteLine($"Всего элеметов {numbers.Length} , сумма чисел нечетных элементов {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{ 
Console.WriteLine("[" +String.Join("; ", numbers)+"]");
}



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 6;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int min = numbers[0];
int max = min;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
        if(numbers[a]<min) 
        {
            min = numbers[a];
        }
}
Console.WriteLine($"Maksimal'noe: {max}");
Console.WriteLine($"Minimal'noe: {min}");
Console.WriteLine($"Raznica mejdu maksimal'nim {max} i minimal'nim {min} = {max - min}");

void FillArrayRandomNumbers( int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100,1000);
        }
}
void PrintArray(int[] numbers)
{ 
Console.WriteLine("[" +String.Join("; ", numbers)+"]");
}
