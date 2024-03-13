string [] str = new string [new Random().Next(1,11)];
for (int i= 0; i < str.Length; i++)
{
    Console.Write($"Введите {i}элемент массива:");
    str[i] = Console.ReadLine()!;
}