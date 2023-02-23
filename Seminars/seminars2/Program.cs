// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// void MaxDecimal (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа{num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа{num} -> {dec}");
//     }
// }

// int rundomnumber = new Random().Next(10, 100);

// MaxDecimal(rundomnumber);

// int DeletDecimal (int num)
// {
//     int ed = num / 100;
//     int dec = num % 10;
//     return sot*10 + ed;
// }


// int rundomnumber = new Random().Next(100, 1000);
// Console.WriteLine(rundomnumber);
// Console.WriteLine(DeletDecimal(rundomnumber));



// int DeleteDecimal (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }


// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(randomnumber));


// void rest(int num1, int num2) 
// {
//     int rez = num2 % num1;
//     if (rez == 0) {
//         Console.WriteLine($"1: {num1}, {num2} Второе число кратно первому");
//     }
//         else
//         {
//             Console.WriteLine($"1: {num1}, {num2} Второе число не кратно первому, остаток {rez}");
//         }
//     }


// rest(4, 9);

// 4.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool DoubleCheck(int num)
// {
//   int check1 = num % 7;
//   int check2 = num % 23;

//   if (check1 == 0 && check2 == 0)
//   {
//     return true;
//   }
//   else { return false; }
// }

// Console.WriteLine(DoubleCheck(161));

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int Prompt (string message);
{
    System.Console.Write(message);
    String value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("ВВедите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"введите трехзначное число '(number)'");
int secondRunk = number / 10 & 10;
Console.WriteLine($"Вторая цифра '(secondRank)'");