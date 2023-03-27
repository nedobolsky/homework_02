// Задача №10
Console.WriteLine("Введите трехзначное число ");
int numberUser = Convert.ToInt32(Console.ReadLine());
if (numberUser > 100 && numberUser < 1000){
    Console.WriteLine((numberUser / 10) % 10);
}
else{
    Console.WriteLine("Вы ввели число не соответствующее");
}

// Задача №13
Console.Clear();
Console.WriteLine("Введите число больше 100");
int numUser = Convert.ToInt32(Console.ReadLine());
if (numUser < 100){
    Console.WriteLine("Вы ввели число менее 100");
}
else{
    while (numUser > 999){
        numUser = numUser / 10;
    }
    Console.WriteLine(numUser % 10);
}

// Задача №15
Console.Clear();
Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

switch (num){
    case 1:  
    Console.WriteLine("Нет");
    break;
    case 2:  
    Console.WriteLine("Нет");
    break;
    case 3:  
    Console.WriteLine("Нет");
    break;
    case 4:  
    Console.WriteLine("Нет");
    break;
    case 5:  
    Console.WriteLine("Нет");
    break;
    case 6:  
    Console.WriteLine("Да");
    break;
    case 7:  
    Console.WriteLine("Да");
    break;
    default: 
    Console.WriteLine("Вы ввели неверное число");
    break;
}
