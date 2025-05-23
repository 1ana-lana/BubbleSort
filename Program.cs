// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = new int[6] {4,2,3,1,8,0};

bool arrayWasChanged = false;

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            int buffer = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = buffer;
            arrayWasChanged = true;
        }

        foreach (var item in numbers)
        {
            Console.Write(item + "_");
        }
        Console.WriteLine();

    }

    if (!arrayWasChanged)
    {
        break;
    }
    else
    {
        arrayWasChanged = false;
    }

}




