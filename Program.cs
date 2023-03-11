// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// // и на выходе показывает вторую цифру этого числа.

// // Example
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int num =new Random().Next(100,1000);
// Console.WriteLine(num);
// int numSot = num%100;
// int numDes = numSot/10;
// Console.Write("Заданное число: "+num+"  вторая цифра: "+numDes);



// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// Example
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int Number;
// Console.WriteLine("Число будет заданно в ручную(yes/no)");
// string answer = Console.ReadLine();
// if (answer.ToLower()=="yes") 
// {
//   Console.WriteLine("Введите число:");
//  Number = Convert.ToInt32(Console.ReadLine());
// }
// else
// {
//   Number =new Random().Next(0,100000);
//   }
// int Number1=Number;
// if (Number1>100)
// {  
//    while (Number1>999)
//    {
//    Number1=Number1/10;
//    }
//   Number1=Number1%10;
//   Console.WriteLine("Заданное число: "+Number+" третья цифра с лева: " +Number1);
// }else 
// {
//   Console.Write("Заданное число: "+Number+"  третья цифра с лева: ");
//   Console.ForegroundColor = ConsoleColor.Red;
//   Console.Write("Отсутствует");
//   Console.ResetColor();
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее день недели:");
int Number1 = Convert.ToInt32(Console.ReadLine());

if ((Number1==6)||(Number1==7))
{
  Console.WriteLine(Number1+"й день недели является выходным");
}
else
{
  Console.WriteLine(Number1+"й день недели является рабочим");
}