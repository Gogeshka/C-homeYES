/* Task 1

int SecondNumber (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int chislo = SecondNumber("Введите 3хзначное число: ");
if(chislo < 100 || chislo >= 1000)
{
    Console.WriteLine("Это не 3хзначное число, введите 3х значное число");
    return;
}
Console.WriteLine("Введенное число " + chislo);
int second = chislo / 10 % 10;
Console.WriteLine("Вторая цифра " + second);
*/

/* Task 2

int SeNumber (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int DaiTretiuCifru(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool NeTriCifri(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Вы ввели не 3хзначное число");
        return false;
    }
    return true;
}
int number = SeNumber("Введите число: ");
if (NeTriCifri(number))
{
    Console.WriteLine(DaiTretiuCifru(number));
}
*/

/* Task 3
int SeNumber (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
bool weekend(int day)
{
    if(day > 5) return true;
    return false;
}
bool LieWeekDay(int notday)
{
    if(notday > 0 && notday <=7) return true; 
    // как я понял, что || это или, а && это и 
    Console.WriteLine("В неделе 7 дней");
    return false;
}
int day = SeNumber("Введите день: ");
if (LieWeekDay(day))
{
    if (weekend(day))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Не выходной");
    }
}
*/