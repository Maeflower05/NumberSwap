Console.WriteLine("Velkommen til Number Swap!");
Console.Write("Indtast venligst dit første tal: ");
string x = Console.ReadLine();
Console.Write("Indtast venligst dit næste tal: ");
string y = Console.ReadLine();

//Der er TO måder at gøre det på. Den hurtige er dem her (linje 8-10.)
//string v = x;
//x = y;
//y = v;

//Men her har jeg bydt them om, og lavet dem til int istedet for string.
Console.WriteLine($"\nDu har valgt dit første tal som {x} og næste som {y}.");
int a = Convert.ToInt32(x);
int b = Convert.ToInt32(y);
(a, b) = (b, a);
Console.WriteLine($"\nOg nu swapper vi! \nDit første tal er nu {a} og dit næste tal er {b}");
Console.ReadLine();