int size = 6, comparacao = 0, referencia = 0, aux = 0;
int[] mega_sena = new int[size];
int[] sena_aux = new int[size], ordenado = new int[size];
Console.WriteLine("Números sorteados:");
for (int i = 0; i < size; i++)
{
    mega_sena[i] = new Random().Next(0,100);
    sena_aux[i] = mega_sena[i];
    Console.Write(mega_sena[i] + " ");
}

for (referencia = 0; referencia < size; referencia++)
{
    for (comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (sena_aux[referencia] > sena_aux[comparacao])
        {
            aux = sena_aux[referencia];
            sena_aux[referencia] = sena_aux[comparacao];
            sena_aux[comparacao] = aux;
        }
    }
    ordenado[referencia] = sena_aux[referencia];
}
Console.WriteLine("\nNúmeros sorteados ordenados");
for (int i = 0; i < size; i++)
{
    Console.Write(ordenado[i] + " ");
}