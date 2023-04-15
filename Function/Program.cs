int max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;    
    return result;
}

int a1=34;
int b1=132;
int c1=37;

int a2=76;
int b2=11;
int c2=47;

int a3=32;
int b3=22344;
int c3=6;

int max1 = max (a1,b1,c1);
int max2 = max (a2,b2,c2);
int max3 = max (a3,b3,c3);

//int Max = max(max1, max2, max3); //Обращение к верхней строке кода (функции)

int Max = max( max(a1,b1,c1), max(a2,b2,c2), max(a3,b3,c3)); // Оптимизированный вариант с обращением к математической функции

/*if (b1>max) max = b1;
if (c1>max) max = c1;

if (a2>max) max = a2;
if (b2>max) max = b2;
if (c2>max) max = c2;

if (a3>max) max = a2;
if (b3>max) max = b2;
if (c3>max) max = c2;
*/

Console.WriteLine (Max);