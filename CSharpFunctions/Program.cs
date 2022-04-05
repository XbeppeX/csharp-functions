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

int[] nuovoArrayNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(nuovoArrayNumeri);

int nuovoNumero = Quadrato(10);
Console.WriteLine(nuovoNumero);

