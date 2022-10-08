Console.Write("Введите N=");
int N = int.Parse(Console.ReadLine());
int[] A = new int[Math.Abs(N)];
if (N == 0)
{
    Console.WriteLine("Ошибка");
}
else if (N > 0)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = (int)Math.Pow(i + 1, 3);
        Console.Write(A[i] + " ");
    }
}
else
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = (int)Math.Pow(N, 3);
        N = N + 1;
        Console.Write(A[i] + " ");
    }

}