// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива 
// и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество 
// элементов массива”, “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)


int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

int EnterLength()
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write(" Введите длину массива >> ");
        response = Convert.ToInt32(Console.ReadLine());

        if (response > 0)
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Нужен хотя бы один элемент! Попробуйте еще раз."); }
    }
    return (response);
}

int[] RandArray(int Lnt, int RndMin, int RndMax)
{
    int[] RandArray = new int[Lnt];

    for (int i = 0; i < Lnt; i++)
    {
        Random rnd = new Random();
        RandArray[i] = rnd.Next(RndMin, RndMax);
    }
    return (RandArray);
}

void ArrOutput(int[] Arr)
{
    string Result = ("Случайный массив: ");
    for (int i = 0; i < Arr.Length; i++)
    {
        Result = Result + Arr[i] + ",";
    }

    Result = Result.TrimEnd(',') + ".";
    System.Console.Write(Result);

}




System.Console.WriteLine("Итак, собираемся генерировать случайный массив, потребуются кое-какие данные. Поехали!"); 
int Lngth = EnterLength();

int min = 0;
int max = 0;

bool rightInput = false;
while (rightInput == false)
{
    System.Console.WriteLine(" Введите границы диапазона: ");
    min = EnterSmth("нижняя ");
    max = EnterSmth("верхняя ");

    if (max >= min)
    {
        rightInput = true;
    }
    else { System.Console.WriteLine("Все с ног на голову! Попробуйте еще раз."); }
}


int[] Array = RandArray(Lngth, min, max);

ArrOutput(Array);

