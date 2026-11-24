
Random random = new Random();

int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
    array[i] = random.Next(0, 99);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int min = array[0];
for(int i = 1; i < array.Length; i++)
    if(array[i] < min)
        min = array[i];
Console.WriteLine(min);







void ArrayExample()
{
    int[] numbers = new int[10];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите оценку {i + 1} студента: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    int amount = 0;
    for (int i = 0; i < numbers.Length; i++)
        amount += numbers[i];

    double result = (double)amount / numbers.Length;
    Console.WriteLine($"Средняя оценка в группе = {result}");
}