int number = new Random().Next(100, 999);
Console.WriteLine($"Наше случайное число = {number}");

int numberSecond = number / 100;
int numberThree = number % 10;
int result = numberSecond * 10 + numberThree;
Console.WriteLine($"Наше случайное число ={number},исключая среднюю цифру ={result}");