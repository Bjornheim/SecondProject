Console.WriteLine("Привет тебе, дитя. Назови своё имя?");
string userName = Console.ReadLine();

Console.WriteLine("Каков свой возраст?");
int userAge = int.Parse(Console.ReadLine());
int requiredAge = 18;

if (userAge >= requiredAge)
{
    Console.WriteLine($"Добро пожаловать, {userName}! Присаживайся возле костра.");
} 
else 
{
    Console.WriteLine($"{userName}, приходи когда вырастешь! В данный момент тебе здесь не рады.");
}