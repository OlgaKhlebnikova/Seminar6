Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3/4)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if (Task == 1)
{
    Task1();
}
else if (Task == 2)
{
    Task2();
}
else if(Task == 3){
    Task3();
}

else if(Task == 4){
    Task4();
}  





void Task1()
{
    //Пользователь вводит с клавиатуры M чисел.
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3

    Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine();

    string userString = " ";
    Console.WriteLine("Введите числа через пробел");
    userString = Console.ReadLine();

    //Console.WriteLine("Пользователь ввел строку: " + userString);

    string?[] Num = userString.Split(' ');

    var numbers = Num.Select(int.Parse).ToArray();

    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            counter++;
        }
    }

    Console.WriteLine("Положительных чисел введено:" + counter);
}

void Task2()
{
    //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
    //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
    Console.WriteLine();

    Console.WriteLine("Введите значение b1 ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение k1 ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение b2 ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение k2 ");
    double k2 = Convert.ToDouble(Console.ReadLine());


    double x, y;

    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны.");
    }

    // double intrsectionLines (double k1, double b1, double k2, double b2);
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (b2 * k1 - b1 * k2) / (k1 - k2);
        Console.WriteLine($"Прямые пересекаются в точке х = {x} и y = {y}");
    }

}

void Task3()
{
/*  Напишите программу, которая задаёт массив из n элементов, которые необходимо 
заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо */
    Console.WriteLine(" Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
    }

    void PrintArray(int[] inputArray)
{

        Console.Write($" [ {String.Join(",",inputArray)} ]");   
        Console.WriteLine();

}

    int [] ChangeIndexLeft(int[] firstarray)
{
    int[] changeArray = new int [firstarray.Length];
    int temp = firstarray[0];
    for (int i = 0; i < firstarray.Length-1; i++)
    {             
        changeArray[i] = firstarray[i+1];
    }
    changeArray[changeArray.Length-1] = temp;
    return changeArray;
}

    int [] ChangeIndexRight(int[] firstarray)
{
    int[] changeArray = new int [firstarray.Length];
    int temp2 = firstarray[firstarray.Length-1];
    for (int i = 1; i < firstarray.Length; i++)
    {             
        changeArray[i] = firstarray[i-1];
    }
    changeArray[0] = temp2;
    return changeArray;
}

    int[]newarray = FillArray(4,-5,20);
    Console.Write("Входной массив");  
    PrintArray(newarray);
    Console.WriteLine();  
    Console.Write("Сдвиг влево ->");  
    PrintArray(ChangeIndexLeft(newarray));
    Console.WriteLine();  
    Console.Write("Сдвиг вправо ->");  
    PrintArray(ChangeIndexRight(newarray));

}

void Task4()
{
/* Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить
 случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, 
 при наличии такого элемента заменить его на уникакальное значение.
[1,2,3,3] -> [1,2,3,4] */
    Console.WriteLine(" Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
        int[] filledArray = new int[size];

        for (int i = 0; i < filledArray.Length; i++)
        {
            filledArray[i] = new Random().Next(min, max + 1);
        }
        return filledArray;
    }

    void PrintArray(int[] inputArray)
    {

        Console.Write($" [ {String.Join(",", inputArray)} ]");
        Console.WriteLine();

    }
        int [] ChangeElement(int[] firstarray)
    {
        int[] changeArray = new int [firstarray.Length];
        int RandomNum = new Random().Next(-5,21);
        for (int i = 0; i < firstarray.Length; i++)
        {
            changeArray[i] = firstarray[i];
        }
            for (int i = 1; i < firstarray.Length-1; i++)
            {             
            if (changeArray[i] == changeArray[i+1] || changeArray[i] == changeArray[i-1])
            {
                changeArray[i] = RandomNum;
            }
            }
      
        return changeArray;
        }
    int[]newarray = FillArray(10,-5,5);    
    PrintArray(newarray);
    Console.WriteLine();  
    PrintArray(ChangeElement(newarray));
}





