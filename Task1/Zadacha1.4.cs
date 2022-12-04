// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Реализовать через функции.

int NatStepen(int A, int B)
{
    int result = A;
    for (int i = 2; i <= B; i++)
    { result = A * result; }

    return (result);

}

int EnterB()
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write(" Введите натуральную степень >> ");
        response = Convert.ToInt32(Console.ReadLine());

        if (response > 0) //считать 0 натуральным числом в России вроде как не принято
        {
            rightInput = true;
        }
        else { System.Console.Write("Это не натуральное число, попробуйте еще раз!"); }
    }
    return (response);
}

int EnterA()
{
    System.Console.Write(" Введите число >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

int A = EnterA();
int B = EnterB();
int result = NatStepen(A, B);
System.Console.Write(result);