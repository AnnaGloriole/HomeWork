
Console.WriteLine("введите 3х значное число");
string number = Console.ReadLine ();
Console.WriteLine(number[1]);


//Можно ли так?
//int number = new Random().Next(99,1000);      попробовала ч.з рендом, но ругается что:
//Console.WriteLine(number); - при попытке вывести [1] по индексу говорит о несоответствии int, string
//пыталась эксперементировать, но ругается о невозможности void
//string number1 = Console.ReadLine(Console.WriteLine(number));
//Console.WriteLine(Console.WriteLine(number)[1]);

