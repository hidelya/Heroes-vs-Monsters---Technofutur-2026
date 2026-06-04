using LaboHeroesVsMonster.Class;

Console.WriteLine("Bonjour cher héro, quel-est ton nom ?");
string name = Console.ReadLine()!;
Console.WriteLine($"Très bien {name}, es-tu un nain ou un humain ?");

Perso joueur = null!;
bool input = false;
int stockCuirJoueur = 0;
int stockOrJoueur = 0;

for ( int i = 0; i < 1; i++) 
{ 
    string type = Console.ReadLine()!;

    if (type  == "nain")
    {
        Console.WriteLine("Tu as choisi le nain ! Tu as +2 en endurance.");
        joueur = new Nain();
    }
    else if (type == "humain")
    {
        Console.WriteLine("Tu as choisi l'humain ! Tu as +1 en force et +1 en endurance.");
        joueur = new Human();
    }
    else
    {
        Console.WriteLine("Ce type de héro n'existe pas");
        i--;

    }
}

ZoneJeu zone = new ZoneJeu();
zone.AfficherTableau();


Utilitaires.Clear(input);

Console.WriteLine("Voyons ta stat de force...");
Utilitaires.InputDe();
Console.WriteLine($"Tu as {joueur.forc} de force !");
Utilitaires.Clear(input);
Console.WriteLine("Voyons ta stat d'endurance...");
input = Utilitaires.InputDe();
Console.WriteLine($"Tu as {joueur.end} d'endurance !");
Utilitaires.Clear(input);
Console.WriteLine("Voyons ta stat de points de vie...");
Utilitaires.InputDe();
Console.WriteLine($"Tu as {joueur.PvMax} de points de vie !");
Console.WriteLine("Appuie sur une touche pour commencer ton aventure !");
Utilitaires.Clear(input);

do
{
    joueur.RestorePv();
    Console.WriteLine("Tu te balade quand soudain....");
    Utilitaires.InputContinue();
    Console.Clear();
    Monster monstreActuel = Monster.InitialisationMonstre();
    Console.WriteLine("Un monstre vient de spawn !");
    Console.WriteLine($"C'est un {monstreActuel.GetType().Name} il possède " +
    $" {monstreActuel.forc} de force et {monstreActuel.PvMax} de pv ");
    Console.WriteLine("C'est l'heure de l'affronter !");
    Utilitaires.Clear(input);
    Perso.BoucleAttaque(joueur, input, monstreActuel);
    Perso.Loot(monstreActuel, joueur, stockCuirJoueur, stockOrJoueur);
    
} while (joueur.Pv > 0);

Console.WriteLine("Tu as perdu !");


