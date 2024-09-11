// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Paraméter

static void ErtekKiiras(int a, int b)
{
    Console.WriteLine("Első szám értéke: {0}, második szám értéke: {1}", a, b);
}

int a = 2, b = 2;
ErtekKiiras(a, b);

// Alapértelmezett érték
/*
static void Udvozlet()
{
    Console.WriteLine("Köszöntelek a programban!");
}

static void Udvozlet2(string nev)
{
    Console.WriteLine($"Köszöntelek {nev} a programban!");
}
*/


static void Udvozlet(string nev = "")
{
    Console.WriteLine($"Köszöntelek {nev} a programban!");
}

Udvozlet();
Udvozlet("Józsika");

static int Osszeadas(int elso, int masodik)
{
    return elso + masodik;
}

a = 2; b = 2;
Console.WriteLine("Összeadott értékük: " + Osszeadas(a, b));

// Referencia szerinti paraméterátadás
static double Hatvany(ref int elso, ref int masodik)
{
    elso = 3;
    masodik = 3;

    Console.WriteLine();
    Console.WriteLine($"Új értékeket adtam meg: {elso}, {masodik}!!");

    return Math.Pow(elso + masodik, 2);
}

Console.WriteLine("Két tag összegének négyzete: " + Hatvany(ref a, ref b));
Console.WriteLine($"a={a} b={b}");

// Paraméterek hivatkozásként (referencia) való megadása
// A metódus paraméterként hivatkozásként kap meg egy változót, nem pedig érték szerint. 
static void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

a = 10;
b = 20;
Console.WriteLine($"Cserélés előtt: a = {a}, b = {b}");

// A ref segítségével megváltoztatjuk a változók értékeit
Swap(ref a, ref b);

Console.WriteLine($"Cserélés után: a = {a}, b = {b}");

// Az out kulcsszó a C#-ban lehetővé teszi, hogy egy metóduson belül a paraméterek értékét "kiadjuk" a metódusból. Az out kulcsszó C#-ban rendkívül hasznos, amikor egy metódusból több értéket akarunk visszaadni

static void Calculate(int x, int y, out int sum, out int difference)
{
    sum = x + y;
    difference = x - y;
}

int sum, difference;

// Az out paraméterek segítségével visszakapjuk az eredményeket
Calculate(a, b, out sum, out difference);

Console.WriteLine($"Összeg: {sum}");
Console.WriteLine($"Különbség: {difference}");