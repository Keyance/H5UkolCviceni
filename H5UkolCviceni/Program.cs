// 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
using System.Reflection.Metadata;

DateTime ted = DateTime.Now;

// 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
DateTime narozeni = new DateTime (1999, 06, 11, 2, 15, 0);
TimeSpan ubehlo = ted - narozeni;

// 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
var seznam = new List<string>() { "pes", "kočka", "potkan", "slepice", "pštros" };

// 4. Smaž z tohoto listu libovolnou hodnotu.
seznam.Remove(seznam[2]);

// 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains ... zkus na internetu zjistit, jak ji použít.
string hledany = "albatros";
bool hledani = seznam.Contains(hledany);
if (hledani) { Console.WriteLine($"List obsahuje slovo \"{hledany}\""); } else { Console.WriteLine($"List neobsahuje slovo \"{hledany}\""); }

// 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
foreach (string s in seznam)
{
    int cislo = seznam.IndexOf(s);
    Console.WriteLine($"{cislo}: {s}");
}

// 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
var cenik = new Dictionary<string, int>();
cenik.Add("chleba", 35);
cenik.Add("rohlik", 3);
cenik.Add("kobliha", 12);

// 8. Zjisti, jestli slovník obsazhuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

string klic = "sádlo";
if (cenik.ContainsKey(klic)) { Console.WriteLine($"{klic} stojí {cenik[klic]},- Kč"); } else { Console.WriteLine("V ceníku není tako položka."); }

// 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

string pridavano = "chleba";
if (cenik.ContainsKey(pridavano))
{
    int prechodne = cenik[pridavano];
    cenik[pridavano] += prechodne;
} else
{
    Console.WriteLine("Tato položka ještě není v ceníku.");
}
