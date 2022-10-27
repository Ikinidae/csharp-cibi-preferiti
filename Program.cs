// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pasta", "Patate", "Broccoli", "Polpette", "Pasta al pesto" };

//lunghezza array
Console.WriteLine(cibiPreferiti.Length);

//stampare l’intero array in ordine indicando la posizione in classifica
for (int i = 0; i < cibiPreferiti.Length; i++) {
    Console.WriteLine("Posizione" + i + ":" + cibiPreferiti[i]);
}

//prima posizione della classifica
Console.WriteLine("Primo cibo:" + cibiPreferiti.First());

//ultima posizione della classifica
Console.WriteLine("Ultimo cibo:" + cibiPreferiti.Last());