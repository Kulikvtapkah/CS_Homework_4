// Задача *: Напишите программу, которая из массива случайных чисел
// ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
//  Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5



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

void ArrOutputAnd2ndMax (int[] Arr, int min)
{
    int CurrentMax = Arr[0];
    int Cur2ndMax = min - 1; /* сделала так, чтобы если 
     выпадут все одинаковые числа, но больше нижней границы, 
     можно было бы определить, что второго максимума нет.
     Практически такое едва ли вероятно, но в теории возможно все*/

    string Result = ("Случайный массив: ");
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > Cur2ndMax)

        {
            if (Arr[i] > CurrentMax)
            {
                Cur2ndMax = CurrentMax;
                CurrentMax = Arr[i];
            }
            else
            {
                if (Arr[i] != CurrentMax) Cur2ndMax = Arr[i];
            }
        }

        Result = Result + Arr[i] + ",";
    }

    Result = Result.TrimEnd(',') + ".";
    System.Console.WriteLine(Result);

    if ((Cur2ndMax != CurrentMax) && (Cur2ndMax >= min))
        System.Console.Write($"Второй максимум массива: {Cur2ndMax}.");
    else System.Console.Write("Похоже, что нет второго максимума(");
}



System.Console.WriteLine("Итак, генерируем случайный массив и ищем в нем второй максимум."); 
System.Console.WriteLine("Потребуются кое-какие данные. Поехали!");


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

ArrOutputAnd2ndMax(Array, min);

