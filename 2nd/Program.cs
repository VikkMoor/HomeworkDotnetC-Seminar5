// Input - random array, output - sum of numbers on odd positions;

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1)
    {
        arr1[pos1] = new Random().Next(-99, 100);
        pos1++;
    }
}
void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr2[pos2]} ");
        pos2++;
    }
}
Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int oddsum = 0;
for (int i = 1; i < size; i += 2) oddsum = oddsum + array[i];
Console.WriteLine(oddsum);
