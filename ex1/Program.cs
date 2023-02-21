// методы
//void: нет оператора return

//(возвр) тип_возвр_значения имя (параметры)

/*int Calculate (int a, int b, char sign) //2 числа
{
    int result =0;
    //для char одинарные кавычки
    if (sign == '*')
    {
        result = a*b;
    }
    else if(sign =='+')
    {
        result=a+b;
    }
    else if(sign=='-')
    {
        result=a-b;
    }
    else
    {
        Console.WriteLine("такого знака нет");
    }
    return result;
}
Console.WriteLine(Calculate(3,2,'*'));*/
//ex1 еа входА.выдает сумму всех чисел от 1 до A//4->10
//без метода
/*Console.WriteLine("введите число A: ");
int limit = Convert.ToInt32(Console.ReadLine());
int sum =0;
for (int i=1;i<=limit;i++)
{
    sum=sum+i;
}
Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");*/


//метод
/*Console.WriteLine("введите число A: ");
int limit = Convert.ToInt32(Console.ReadLine());
//pascal caseстиль.где слова с большой буквы
int GetSum(int A)
{
    int sum=0;
    for(int i=1;i<=A;i++)
    {
    sum +=i;
}
return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");*/