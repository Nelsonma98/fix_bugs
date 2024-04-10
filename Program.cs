namespace fix_bugs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution([-1, 1, -2, 2]));
    }

    static int Solution(int[] numbers)
    {
        int small = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < small)
            {
                small = numbers[i];
            }
        }
        return small;
    }
}
