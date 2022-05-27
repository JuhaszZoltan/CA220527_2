using CA220527_2;

List<Film> filmek = new();

using StreamReader sr = new(@"../../../res/marvel.txt");

while (!sr.EndOfStream)
    filmek.Add(new Film(sr.ReadLine()));

//"A" feladatsor 3AB.1es feladat:
Console.WriteLine($"3A.1: {filmek.Count} film van a marvel moziverzumában");

//"A" feladatsor 3A.2es feladat:
int koltsegSum = 0;
foreach (var film in filmek)
{
    koltsegSum += film.Kiadas;
}
float kotsegAvg = koltsegSum / (float)filmek.Count;
Console.WriteLine($"3A.2: a filmek átlagos gyártási költsége: ${kotsegAvg : 0.00}M");

//"A" feladatsor 3A.3as feladat:
int maxIndex = 0;
for (int i = 1; i < filmek.Count; i++)
{
    if (filmek[i].BKArany > filmek[maxIndex].BKArany)
    {
        maxIndex = i;
    }
}
Console.WriteLine($"3A.3: a legkötslghatékonyabb film címe: {filmek[maxIndex].Cim}");

//"A" feladatsor 3A.4es feladat:
Console.Write("3A.4: írjon be egy évszámot: ");
string keresettEv = Console.ReadLine();
Console.WriteLine($"a {keresettEv}-ban/ben megjelent marvel filmek:");
//fore + TAB + TAB
foreach (var film in filmek)
{
    if (film.Premier.Contains(keresettEv))
    {
        Console.WriteLine($"\t{film.Cim}");
    }
}

//------------------------------------------------

//"B" feladatsor 3B.2es feladat:
int fazisCount = 0;
foreach (var film in filmek)
{
    if (film.Fazis < 3) fazisCount++;
}
Console.WriteLine($"3B.2: A 3. fázis előtti filmek száma: {fazisCount}db");

//"B" feladatsor 3B.3as feladat:
int minIndex = 0;
for (int i = 1; i < filmek.Count; i++)
{
    if (filmek[i].Haszon < filmek[minIndex].Haszon)
    {
        minIndex = i;
    }       
}
Console.WriteLine($"3B.3: A legalacsonyabb hasznot a(z) {filmek[minIndex].Cim} hozta!");

//"B" feladat 3B.4es feladat:
Console.Write("3B.4: írjon be egy címrészletet: ");
string cimReszlet = Console.ReadLine();
foreach (var film in filmek)
{
    if (film.Cim.Contains(cimReszlet))
    {
        Console.WriteLine($"\t{film.Cim}");
    }
}

Console.ReadKey(true);