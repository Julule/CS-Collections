
Console.WriteLine("combien d'étudiants");
int nbretu = Convert.ToInt32(Console.ReadLine());

int[] notes = new int[nbretu];

for (int i = 0; i < notes.Length; i++)
{
    notes[i] = 12;
    Console.WriteLine($"Donnez une note à l'étudiant {i + 1}");
    notes[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine(string.Join(", ", notes));