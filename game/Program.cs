//game init
int GameInit(int lefta, int righta)
    {
    int a = new Random().Next(lefta, righta);
    return a;
    }
int MakeMove(int MoveNumber, int SecretNumber)
    {
        SecretNumber = GameInit(a);
        int PlayersNumber = Convert.ToInt32 (Console.ReadLine());
        
    for (int i = 0; i < MoveNumber; i++)
        {   
        if (PlayersNumber != SecretNumber)
            {
            MoveNumber = MoveNumber - 1;
            System.Console.WriteLine("$Вы не угадали. Осталось {MoveNumber} попыток");
            }
        if (PlayersNumber == SecretNumber)
            {
            System.Console.WriteLine("Вы угадали число!");
            }
        }
    return MoveNumber;
    }
System.Console.WriteLine(GameInit(10,100));
System.Console.WriteLine(MakeMove(7, 17));
//запрос числа у игрока, обработка нештатных ситуаций.
/* int RequestNumber(int lefta, int righta)
    {
    System.Console.WriteLine("Введите число");
    int PlayersNumber = Convert.ToInt32(Console.ReadLine());

    if (PlayersNumber > lefta && PlayersNumber < righta)
    {
        System.Console.WriteLine($"Вы ввели число {PlayersNumber}");
    }
    else
    {
        System.Console.WriteLine($"Вы ввели число {PlayersNumber}, оно не подходит под условие задачи. Ведите новое число");
    }
    return PlayersNumber;
    } */
///////////////////////

/* bool CheckNumber(int PlayersNumber, int SecretNumber)
{
    if (PlayersNumber == SecretNumber){
        System.Console.WriteLine("Поздравляю! Вы выиграли!"); return true;
        }
    else
        {
        if (PlayersNumber > SecretNumber) System.Console.WriteLine("Введённое число больше загаданного. Попробуйте ещё раз!");
        if (PlayersNumber < SecretNumber) System.Console.WriteLine("Введённое число меньше загаданного. Попробуйте ещё раз!");
        }
    return false;
} */
//CheckNumber(122, 12);
//MakeMove(7, Number(10,100), RequestNumber, CheckNumber);
////////////////////


