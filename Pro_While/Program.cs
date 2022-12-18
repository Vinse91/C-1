// Хотим найти сумму чисел от 1 до 10

int a = 1;
int sum = -1;

while (a <= 10) // работаем до тех пор, пока не вышли за 10
{
    a++;

    Console.WriteLine (" a = " + a);
    sum = sum + a;
    Console.WriteLine ("Текущая сумма = " + sum);

}

Console.WriteLine ("Итоговая сумма = " + sum);