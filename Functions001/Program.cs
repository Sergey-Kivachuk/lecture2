// вид 1
void Metod1()
{
Console.WriteLine("Автор ...");
}
// Metod1();


// вид 2

void Metod2(string msg)
{
    Console.WriteLine(msg);
}
// Metod2("Текст сообщения");


void Metod21(string msg, int count)
{
     int i = 0;
     while (i < count)
     { 
         Console.WriteLine(msg); 
         i++;
    }
}
// Metod21("Текст", 4);

// вид 3


int Metod3()
{
    return  DateTime.Now.Year;
}
// int year = Metod3(); //- вызываем метод, в левой части используем идентификатор
// переменной (year) и через оператор присваивания (=) кладём нужное значение
// Console.WriteLine(year);


// вид 4

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//        result = result + text;
//        i++;
//     }
//     return result;
// }
// string res = Metod4(10, "z, ");
// Console.WriteLine(res);


string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++) // - вначале ключевое слово, затем инициализация
    // счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
       Console.WriteLine($" {i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
