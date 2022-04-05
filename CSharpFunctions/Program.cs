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

int[] nuovoArrayNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(nuovoArrayNumeri);

int nuovoNumero = Quadrato(10);
Console.WriteLine(nuovoNumero);

int[] nuovoNumero2 = ElevaArrayAlQuadrato(nuovoArrayNumeri);
StampaArrayInteri(nuovoNumero2);

