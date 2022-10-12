//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
string? number = Console.ReadLine();
void CheckNumber(string number) {
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine($"Число {number} является палиндромом!");
        
    }
    else Console.WriteLine($"Число {number} не является палиндромом!");
    
}
if (number!.Length == 5){
 CheckNumber(number);}
   else
    {
        Console.WriteLine("Введено не пятизначное число! Введите правильное число!");
    }

