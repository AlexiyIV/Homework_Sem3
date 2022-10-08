Console.Write("Введите число A=");
int A = Math.Abs(int.Parse(Console.ReadLine()));

bool IsPalindrom(int A)
{
    string n = A.ToString();
    for (int i = 0; i < n.Length / 2; i++)
    {
        if (n[i] != n[n.Length - 1 - i]) return false;
    }
    return true;
}
Console.WriteLine(IsPalindrom(A));