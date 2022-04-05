//--- Funzioni ---
void StampaArrayInteri(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

int Quadrato(int numero)
{
    int risultato = numero * numero;
    return risultato;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }

    return copiaArray;
}

int SommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int sum = 0;

    foreach (int item in copiaArray)
    {
        sum += item;
    }

    return sum;
}

int [] InserimentoValori(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Inserisci valore elemnto numero {0}: ", i + 1);
        int valoreElemento = Convert.ToInt32(Console.ReadLine());
        array[i] = valoreElemento;
    }

    return array;
}

//Esercizio

Console.Write("Inserisci lunghezza array desiderata: ");
int dimensioneArray = Convert.ToInt32(Console.ReadLine());

//Nuovo array 
int[] arrayNumeri = new int[dimensioneArray];
int[] nuovoArrayNumeri = InserimentoValori(arrayNumeri);

//Stampare funzioni
Console.Write("Valori array: ");
StampaArrayInteri(nuovoArrayNumeri);

int nuovoNumero = Quadrato(10);
Console.WriteLine("Numero elevato al quadrato: " + nuovoNumero);

int[] nuovoArrayNumeriQuadrato = ElevaArrayAlQuadrato(nuovoArrayNumeri);
Console.Write("Valori array al quadrato: ");
StampaArrayInteri(nuovoArrayNumeriQuadrato);

Console.Write("Valori array iniziale, dopo modifica al quadrato: ");
StampaArrayInteri(nuovoArrayNumeri);

int nuovoArrayNumeriSommati = SommaElementiArray(nuovoArrayNumeri);
Console.WriteLine("Numeri array sommati: " + nuovoArrayNumeriSommati);

int nuovoArrayNumeriSommatiQuadrato = SommaElementiArray(nuovoArrayNumeriQuadrato);
Console.WriteLine("Numeri array al quadrato sommati: " + nuovoArrayNumeriSommatiQuadrato);



