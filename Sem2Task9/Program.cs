// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую цифру числа. 
System.Random numSintezator = new System.Random();

//Вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;
if(firstNum>secondNum)
{
  Console.WriteLine("Первое число больше"+firstNum + "второго"+secondNum);
}
else
{
  Console.WriteLine("Второе число больше" +secondNum + "первого" +firstNum);
}

//Второй вариант
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
int secondNumber = ((int)digits[1])-48;
int firstNumber = ((int)digits[0])-48;
int resultNumber = (firstNumber>secondNumber)? resultNumber = firstNumber: resultNumber = secondNumber;
Console.WriteLine(resultNumber);

//Третий вариант
// int rndNumberArr = numSintezator.Next(10, 100);
// Console.WriteLine(rndNumberArr);
// int[]indxAnsw * new int[90];
// //ОГРОМНЫЙ МАССИВ
// Console.WriteLine(indxAnsw[rndNumberArr-10]);