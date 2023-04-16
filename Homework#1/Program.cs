//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


/*
Console.Write("Input a first number: ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2=Convert.ToInt32(Console.ReadLine());

if(num1>num2)
   
    Console.Write(num1+  "Большее число");

else
    
    Console.Write(num2+  "Большее число");
 */





 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.   

/*
Console.Write("Input a first number: ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");
int num3=Convert.ToInt32(Console.ReadLine());

int Max = 0;

if (num1>Max) Max=num1;
if (num2>Max) Max=num2;
if (num3>Max) Max=num3;

Console.Write(Max+ "Максимальное число");
*/





// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Число: " + num +  " Четное");

else 
    Console.WriteLine("Число " + num + " Нечетное");

*/






//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int cur=1; cur<=num; cur++)

{
if (cur % 2 == 0)
System.Console.Write(cur + ", ");
}

