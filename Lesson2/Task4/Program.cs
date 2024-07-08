// Дано 5 гирь с разным весом в случайном
// порядке. Определить вес самой тяжёлой
// гири.

int n = 5;
int[] arr = { 2, 4, 7, 3, 9};
int i = 0;
int max = arr[0];

while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
System.Console.WriteLine(max);
