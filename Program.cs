// See https://aka.ms/new-console-template for more information

//string[] cibiPreferiti = { "Pasta", "Patate", "Broccoli", "Polpette", "Pasta al pesto", "Spinaci" };

//lunghezza array
//Console.WriteLine(cibiPreferiti.Length);

//stampare l’intero array in ordine indicando la posizione in classifica
//for (int i = 0; i < cibiPreferiti.Length; i++) {
//Console.WriteLine("Posizione" + i + ": " + cibiPreferiti[i]);
//}

//prima posizione della classifica
//Console.WriteLine("Primo cibo: " + cibiPreferiti.First());

//ultima posizione della classifica
//Console.WriteLine("Ultimo cibo: " + cibiPreferiti.Last());

//Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
// Se il numero di elementi è pari stampare i due elementi centrali
//var y = cibiPreferiti.Length / 2;
//Console.WriteLine("Cibi mediani: " + cibiPreferiti[y - 1] + " e " + cibiPreferiti[y]);

// Se il numero di elementi è dispari scelgo l'elemento centrale: divido per due, esce un numero con la virgola, Floor arrotonda al numero più piccolo
//Console.WriteLine("Cibi mediani: " + Math.Floor(y));

//if (cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int ySup = cibiPreferiti.Length / 2;
//    int yInf = ySup - 1;
//    Console.WriteLine("Cibo middle: " + cibiPreferiti[yInf] + ", " + cibiPreferiti[ySup]);
//}
//else
//{
//    //dispari
//    int y = cibiPreferiti.Length / 2;
//    Console.WriteLine("Cibo middle: " + cibiPreferiti[y]);
//}



//Istruzioni condizionali

//Snack1.
//L’utente inserisce due numeri in successione. Il software stampa il maggiore.

//Console.WriteLine("Inserisci il primo numero");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("il tuo primo numero è: " + firstNum);

//Console.WriteLine("Inserisci il secondo numero");
//int secondNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("il tuo secondo numero è: " + secondNum);

//if (firstNum > secondNum)
//{

//    Console.WriteLine("il numero più grande è: " + firstNum);
//}
//else
//{
//    Console.WriteLine("il numero più grande è: " + secondNum);
//}

//Snack2.

//L’utente inserisce due parole in successione.
//Console.WriteLine("Inserisci la prima parola");
//string firstWord = Console.ReadLine();
//Console.WriteLine("la tua prima parola è: " + firstWord);

//Console.WriteLine("Inserisci la seconda parola");
//string secondWord = Console.ReadLine();
//Console.WriteLine("la tua seconda parola è: " + secondWord);

//Il software stampa prima la parola più corta, poi la parola più lunga.
//if (firstWord.Length < secondWord.Length)
//{

//    Console.WriteLine("la parola più corta è: " + firstWord + ", la parola più lunga è: " + secondWord);
//}
//else
//{
//    Console.WriteLine("la parola più corta è: " + secondWord + ", la parola più lunga è: " + firstWord);
//}

// snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//int y = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("inserisci un numero");
//    int x = Convert.ToInt32(Console.ReadLine());    
//    y += x;

//}

//Console.WriteLine("La somma dei tuoi numeri è " + y);

// snack 4: Calcola la somma e la media dei numeri da 2 a 10.

//int x = 0;
//for (int i = 2; i < 11; i++)
//{
//    x += i;
//    Console.WriteLine("questa è x: " + x);
//}
//Console.WriteLine("La somma dei valori è: " + x);
//Console.WriteLine("La media dei valori è: " + x/9);

//snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

//Console.WriteLine("inserisci un numero");
//int x = Convert.ToInt32(Console.ReadLine());
//if (x % 2 == 0)
//{
//    Console.WriteLine("Il numero inserito è pari: " + x);
//}
//else
//{
//    Console.WriteLine("Il numero inserito è dispari:" + x + ", il successivo numero pari è: " + (x+1));
//}

// snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] guests = { "Sandro", "Ika", "Simo", "Ale", "Gloria"};
Console.WriteLine("inserisci il tuo nome");
string nome = Console.ReadLine();
bool invitato = false;

for (int i = 0; i < guests.Length; i++)
{
    if (nome == guests[i])
    {
        invitato = true;
    }
}

if (invitato == true)
{
    Console.WriteLine("Sei ammesso alla festa!");
}
else
{
    Console.WriteLine("Non sei ammesso alla festa!");
}