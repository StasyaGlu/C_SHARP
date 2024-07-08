// Вычислить значение формулы (a*b) / (c+d) (это дробь)
// где a, b, c, d - некоторые целые числа. Решение оформить 
// в виде функции.

double ColculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenetor = c + d;
    double resalt = numenator / denumenetor;
    return resalt;
}
double resalt = ColculateFormula(1, 2, 3, 4);
System.Console.WriteLine(resalt);
 