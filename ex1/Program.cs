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


//на вход число и посчитать кол-во цифр в числе
/*Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(number>0)
{
    number=number/10;
    count++;
}
Console.WriteLine(count);*/

/*Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumber(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}
Console.WriteLine($"количество цифр: {GetCountNumber(num)}");*/

//прог зад массив из 8 эл. рандомно заполняет массив 0 и 1//метод заполн массив и возвр заполн массив целых чисел
int[] GetBinaryArray(int size)
{
    int[] array = new int[size];//получается массив из 0 на 8 эл
    for(int i=0;i<size;i++)
    {
        array[i]=new Random().Next(2);
    }
    return array;
} 
int[] resultArray =  GetBinaryArray(8);
Console.WriteLine(resultArray);

//for (int i=0;i<resultArray.Length;i++)
//{
  //  Console.WriteLine(resultArray[i]+"   ");
//}

Console.WriteLine($"Массив:  [{String.Join(";",resultArray)}]");