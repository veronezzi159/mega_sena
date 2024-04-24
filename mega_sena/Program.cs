using System.Threading.Channels;

int size = 60, comparacao = 0, referencia = 0, aux = 0, count =0;
int[] mega_sena = new int[size];
int[] sena_aux = new int[size], ordenado = new int[size], norepet = new int[size];
Console.WriteLine("Números sorteados:");
for (int i = 0; i < size; i++)
{
    mega_sena[i] = new Random().Next(1,61);
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

int index = 0;
bool grava = true;
count = 0;
for(referencia = 0;referencia < size; referencia++)
{
    if (grava == true)
    {
        norepet[index] = ordenado[referencia];
        index++;
    }
    for (comparacao = referencia + 1; comparacao < size ; comparacao++)
    {
        if (ordenado[referencia] == ordenado[comparacao])
        {
            grava = false;
            count++;
            break;
        }
        else
        {
            grava = true;
        }
    }
}

Console.WriteLine("\nNúmeros ordenados não repitidos: ");

for(referencia = 0; referencia < (size - count); referencia++)
{
    Console.Write(norepet[referencia] + " ");
}