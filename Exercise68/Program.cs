// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.WriteLine("Введены отрицательные числа, операция невозможна");
    return;
}

int FunctionAckerman(int parametr1, int parametr2)
{
    if (parametr1 == 0) return parametr2 + 1;
    if (parametr1 != 0 && parametr2 == 0) return FunctionAckerman(parametr1 - 1, 1);
    return FunctionAckerman(parametr1 - 1, FunctionAckerman(parametr1, parametr2 - 1));
}

Console.WriteLine($"Значение функции Аккермана при ({n},{m}) равно {FunctionAckerman(n, m)}");