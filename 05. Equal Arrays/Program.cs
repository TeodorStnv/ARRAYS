int[] digits = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] digits2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool isEqual = true;

if (digits.Length != digits2.Length)
{
    isEqual = false;
}
else
{
    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] != digits2[i])
        {
            isEqual = false;
            break;
        }
    }
}

if (isEqual)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}

