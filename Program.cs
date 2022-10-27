// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pasta", "Patate", "Broccoli", "Polpette", "Pasta al pesto", "Spinaci" };

//lunghezza array
Console.WriteLine(cibiPreferiti.Length);

//stampare l’intero array in ordine indicando la posizione in classifica
for (int i = 0; i < cibiPreferiti.Length; i++) {
    Console.WriteLine("Posizione" + i + ": " + cibiPreferiti[i]);
}

//prima posizione della classifica
Console.WriteLine("Primo cibo: " + cibiPreferiti.First());

//ultima posizione della classifica
Console.WriteLine("Ultimo cibo: " + cibiPreferiti.Last());

//Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
//divido per due, esce un numero con la virgola, scelgo un intero a scendere
//float y = cibiPreferiti.Length / 2;
//Console.WriteLine("Cibi mediani: " + Math.Floor(y));

int y = cibiPreferiti.Length / 2;
Console.WriteLine("Cibi mediani: " + cibiPreferiti[y - 1] + " e " + cibiPreferiti[y]);