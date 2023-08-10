string hello = "Dobar dan";
string poruka = "Ovo je poruka";
Console.WriteLine(hello);
Console.WriteLine(poruka);

// tip nazivVarijable = vrijednost;
// int number = 120;
// double decimalNum = 3.145;
// string valuta = $;
// Boolean trueafalse = false;

string number = "120";
string valuta = "180";


string result = ((int.Parse(number) + int.Parse(valuta)) / 100).ToString();

Console.WriteLine("Cijena proizvoda je: " + result);
