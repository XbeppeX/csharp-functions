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
    int i = 0;

    for (i = 0; i < copiaArray.Length; i++)
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

//Esercizio

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };
Console.Write("Valori array: ");
StampaArrayInteri(arrayNumeri);

int nuovoNumero = Quadrato(10);
Console.WriteLine("Numero elevato al quadrato: " + nuovoNumero);

int[] nuovoArrayNumeriQuadrato = ElevaArrayAlQuadrato(arrayNumeri);
Console.Write("Valori array al quadrato: ");
StampaArrayInteri(nuovoArrayNumeriQuadrato);

Console.Write("Valori array iniziale, dopo modifica al quadrato: ");
StampaArrayInteri(arrayNumeri);

int nuovoArrayNumeriSommati = SommaElementiArray(arrayNumeri);
Console.WriteLine("Numeri array sommati: " + nuovoArrayNumeriSommati);

int nuovoArrayNumeriSommatiQuadrato = SommaElementiArray(nuovoArrayNumeriQuadrato);
Console.WriteLine("Numeri array al quadrato sommati: " + nuovoArrayNumeriSommatiQuadrato);





