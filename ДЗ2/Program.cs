// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.WriteLine("Введите число!");
//int a  = int.Parse(Console.ReadLine());
//while (a >= 1000){
  //  a=a/10;
//}
//int b = a%10;
//Console.WriteLine($"Третья цифра числа:{b}");

Console.WriteLine("Введите число!");
int f  = int.Parse(Console.ReadLine());
string c = Math.Abs(f).ToString();
if (c.Length < 3){
    Console.WriteLine("В вашем числе нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа: {c[2]}");
}