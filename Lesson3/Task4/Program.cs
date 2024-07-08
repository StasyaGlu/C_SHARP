// Имена функций

// Хорошие:
// Sum - сумма
// Max - максимум
// FindSubsrting - поиск по строке
// и т.д.

// Плохое название - функция имеет очень обобщённое
// (абстрактное) имя, по которому нельзя точно сказать,
// что она делает.
// Process
// Do
// Calculate
// Function

// Примеры функций
// Пример 1

void WriteTextToFile(string fileName, string text)
{
    StreamWrite writer = new StreamWrite(fileName);
    writer.WriteLine(text);
    writer.Close();
}

// Пример 2

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach(int e in arr)
    {
        sum = sum + e;
    }
    return sum;
}

// Вывод в функциях
// Print....., Show....,Output...

// Пример 1:
void PrintArray(int[] arr)
{
    foreach(int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

// Пример 2:
void ShowMessage(string msg)
{
    System.Console.WriteLine(msg);
}


// Глобальная переменная
// переменная, которая создана вне функции,
// но доступна для чтения и изменения в функцияхю

int a = 5;

void ShowGlobalVar()
{
    System.Console.WriteLine($"Global var:{a}");
}

// Если есть возможность отказаться от использования 
// глобальной переменной, лучше не использовать
