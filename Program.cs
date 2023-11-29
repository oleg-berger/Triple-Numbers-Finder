
static void TripleNumberFinder()
{
int[] arrayA = new int[5];
int[] arrayOp = new int[arrayA.Length];
for(int i = 0; i < arrayA.Length; i++)
{
    Console.Write("Ведите число ");
    arrayA[i] = Convert.ToInt32(Console.ReadLine());
}

for (int j = 0; j < arrayA.Length; j++)
{
    if(arrayA[j] % 3 == 0)
    {
        arrayOp[j] = arrayA[j];
        Console.Write(arrayOp[j] + " ");
    }
    else
    {
        continue;
    }
}
}

TripleNumberFinder();
