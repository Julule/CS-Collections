using System.Collections;
using System.ComponentModel.Design;
Console.OutputEncoding = System.Text.Encoding.UTF8; // Pour les emojis :D
bool Gameover = false;
Console.WriteLine($"Attrape les mouches et faufile-toi sous les aliens ! \n ⬆️ pour attraper et ⬇️ pour se faufiler");

// VIE 
int cpt = 3;
Console.WriteLine($" ❤ Life = {cpt}");

do
{
    int nb2 = 2;
    List<string> mlist = new List<string>();
    for (int i = 0; i <= (nb2 - 1); i += 1) // de 0 à nb2 exclu, pas de 1
    {
        int m = new Random().Next(1, 3); // 3 exclu
        //ajouter à la liste
        // Console.WriteLine(m == 1 ? "🦋" : "👾"); // Opé ternaire (ifelse raccourci) : (condition ? résultat si vrai : résultat si faux)
        mlist.Add(m == 1 ? "🦋" : "👾");
    }
    Console.WriteLine(string.Join("", mlist));

    // touches qu'il faut entrer > liste


    // Entrée touches > liste
    Queue klist = new Queue();
    for (int i = 0; i <= mlist.Count; i++)
    {
        var key = Console.ReadKey(true).Key; // permet une entrée clavier qui réagit sans validation "entrée" + stocke le résultat
        klist.Enqueue($"{key}");
    }

    // SUITE DU JEU
    foreach (string key in klist) // pour chaque key
    {
        if ((m == "🦋" && key == ConsoleKey.UpArrow) || (m == "👾" && key == ConsoleKey.DownArrow)) // si coeur + up OU alien + bas 
        {
            Console.WriteLine("C'est bon !");
            cpt += 1;
            Console.WriteLine($" ❤ Life = {cpt}");
        }
        else
        {
            Console.WriteLine("Dommage ! ");
            cpt -= 1;
            Console.WriteLine($" ❤ Life = {cpt}");
        }

        if (cpt == 0)
        {
            Gameover = true;
            Console.WriteLine("Game Over !");
        }

        if (cpt == 10)
        {
            Gameover = true;
            Console.WriteLine("YOU WIN !");
        }
    }

} while (!Gameover); // tant que gameover ne s'inverse pas (=n'est pas true)

