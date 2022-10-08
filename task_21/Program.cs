double GetData(string message)
{
    Console.Write(message);
    double input = double.Parse(Console.ReadLine());
    return input;
}

int i = 0;
double Sum = 0;
double[] A = { GetData("введите координату x точки A x="), GetData("введите координату y точки A y="), GetData("введите координату z точки A z=") };
double[] B = { GetData("введите координату x точки B x="), GetData("введите координату y точки B y="), GetData("введите координату z точки B z=") };
while (i < A.Length)
{
    Sum = Sum + (Math.Pow(A[i] - B[i], 2));
    i++;
}
Console.WriteLine("длинна отрезка AB=" + Math.Sqrt(Sum));
