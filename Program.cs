Console.WriteLine("Привет тебе, дитя. Назови своё имя?");
string userName = Console.ReadLine();

Console.WriteLine("Каков твой возраст?");
int userAge = int.Parse(Console.ReadLine());

if (userAge >= 18)
{
    Console.WriteLine($"Добро пожаловать, {userName}! Присаживайся возле костра.");
} 
else 
{
    Console.WriteLine($"{userName}, приходи когда вырастешь! В данный момент тебе здесь не рады.");
}
