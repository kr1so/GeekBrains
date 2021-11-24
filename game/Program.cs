//game init
int GameInit(int lefta, int righta)
    {
    int a = new Random().Next(lefta, righta);
    return a;
    }
int MakeMove(int MoveNumber, int SecretNumber, int PlayersNumber)
    {
        PlayersNumber = Console.ReadLine();
        
    for (int i = 0; i < MoveNumber; i++)
        {   
        if (PlayersNumber != SecretNumber)
            {
            MoveNumber = MoveNumber - 1;
            }
        if (PlayersNumber == SecretNumber)
            {
            System.Console.WriteLine("Вы угадали число!");
            }
        }
    return MoveNumber;
    }
//запрос числа у игрока, обработка нештатных ситуаций.
/* int min = 10;
int max = 20; */
/* int RequestNumber(int lefta, int righta)
    {
    System.Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > lefta && num < righta)
    {
        System.Console.WriteLine($"Вы ввели число {num}");
    }
    else
    {
        System.Console.WriteLine($"Вы ввели число {num}, оно не подходит под условие задачи. Ведите новое число");
    }
    return num;
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
GameInit(10,100);MakeMove(7,  17,PlayersNumber)

