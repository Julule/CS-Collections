using System.Runtime.ExceptionServices;

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(i);

}
// 0, 1, 2, 3, 4

for (int i = 7; i < 14; i += 2) // de 7 à 14, pas de 2
{
    Console.WriteLine(i);
}
// 7, 9, 11, 13

for (int i = 10; i > 0; i -= 3)
{
    Console.WriteLine(i);
}
// 10, 7, 4, 1


//#region while
//while (/*condition*/)
//{
//    // tant que cette condition est vraie
//}
//#endregion

#region while touche
while (!Console.KeyAvailable)
{
    Thread.Sleep(1000);
    Console.WriteLine("Coucou");
}
#endregion
