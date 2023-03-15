int PlusElem(int n, int m)
{
    if (n == m)
        return m;
    return n+PlusElem(n-1,m);
}

Console.Clear();
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(PlusElem(n,m));