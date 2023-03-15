int[]array = {45, 34, 42, 4, 22, 13, 5, 3};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
        {
        Console.WriteLine(index);
        break;
        }
    index++;
}
        
