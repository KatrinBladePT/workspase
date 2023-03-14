int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 234;
int b1 = 73;
int c1 = 3;

int a2 = 24;
int b2 = 783246363;
int c2 = 23;

int a3 = 2343564;
int b3 = 7343;
int c3 = 36363;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(Max(a1, b1, c1),
          Max(a2, b2, c2),
          Max(a3, b3, c3));

Console.WriteLine(max);
