// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
string input = Console.ReadLine();
string[] numbersArray = input.Split(',');

int numbers = 0;

for (int i = 0; i < numbersArray.Length; i++) {
    int number;
    if (int.TryParse(numbersArray[i], out number) && number > 0) {
        numbers++;
    }
}

Console.WriteLine($"Количество значений больше 0: {numbers}");