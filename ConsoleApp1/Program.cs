// ad
Console.WriteLine("Enter your name");
string name = Console.ReadLine();

//soyad
Console.WriteLine("Enter your Last name");
string surname = Console.ReadLine();

// ad gun tarix

Console.WriteLine("Enter your date of birth");
DateOnly time = DateOnly.Parse(Console.ReadLine());
int age = DateOnly.FromDateTime(DateTime.Now).Year - time.Year;

// gender

Console.WriteLine("Enter your gender");
string gender = Console.ReadLine();

// printing shi
Console.WriteLine($"name: {name} \nsurname: {surname} \nage: {age} \ngender: {gender}");
