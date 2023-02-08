DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", null);
TimeSpan age = new TimeSpan(DateTime.Now.Ticks - birthday.Ticks);

Console.WriteLine(Math.Floor(age.TotalDays/365.25) + " let");

Console.WriteLine(Math.Floor(age.TotalDays / 365.25) + " let " + (birthday.Month - DateTime.Now.Month) + " měsíců " + (birthday.Day - DateTime.Now.Day) + " dní " + (DateTime.Now.Hour - birthday.Hour) + " hodin "+ (DateTime.Now.Minute - birthday.Minute) + " minut.");

Console.WriteLine(Math.Floor(age.TotalDays) + " dní");
Console.WriteLine(Math.Floor(age.TotalSeconds) + " vteřin");
Console.WriteLine(age.Ticks + " ticků");
Console.WriteLine("Další narozeniny za " + ( 365 - Math.Ceiling(age.TotalDays % 365.25)) + " dní");
Console.WriteLine("Další 1000deniny za " + (1000 - Math.Ceiling(age.TotalDays % 1000)) + " dní");