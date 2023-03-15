int akkerman(int m, int n)
{
    if (m == 0)
        return (n+1);
    if (n == 0)
        return akkerman(m-1,1);
    return akkerman(m-1, akkerman(m,n-1));
}

Console.Clear();
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(akkerman(m,n));