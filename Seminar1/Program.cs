/* int num1 = 5;
double num2 = 2.34;

string word = "slovo"
bool check = true; // или False (Неверное значение, ложь)


Seminar 1
Task 1: напишите программу, которая на вход принимает два числа и проверяет, является ли первое чило квадратом второго числа
*/

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write(ThreadInterruptedException a second number: );
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}