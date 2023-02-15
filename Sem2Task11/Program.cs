// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
// int lastDigit = num%10;
// int fistDigit = num/100;
// num = fistDigit*10 + lastDigit;
// Console.WriteLine(num);
//или
Console.WriteLine((num/100)*10+(num%10));

System.Random numSintezator = new System.Random();
int rndNumber = numSintezator.Next(100, 1000);
Console.WriteLine(rndNumber);
char[] digits1 = rndNumber.ToString().ToCharArray();
Console.WriteLine(int.Parse((digits1[0]).ToString())*10+int.Parse((digits1[2]).ToString()));