int a1=34;
int b1=13;
int c1=37;

int a2=76;
int b2=11;
int c2=47;

int a3=32;
int b3=2;
int c3=6;

int max = a1;
if (b1>max) max = b1;
if (c1>max) max = c1;

if (a2>max) max = a2;
if (b2>max) max = b2;
if (c2>max) max = c2;

if (a3>max) max = a2;
if (b3>max) max = b2;
if (c3>max) max = c2;

Console.WriteLine (max);