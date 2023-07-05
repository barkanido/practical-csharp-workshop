class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            throw new ArgumentException("missing argument");
        }
        if (int.TryParse(args[0], out var n) is false)
        {
            throw new ArgumentException($"cannot parse {args[0]}");
        }
        var fizzBuzz = new FizzBuzz()
        {
            Message3 = "Fizz",
            Message7 = "Buzz"
        };
        fizzBuzz.Run(n);
    }
}

class FizzBuzz
{
    public required string Message3 { get; init; }
    public required string Message7 { get; init; }


    public void Run(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"i ");
            var by7 = i % 7 == 0;
            var by3 = i % 3 == 0;
            if (by3 && by7)
            {
                Console.WriteLine(Message3 + Message7);
            }
            else if (by7)
            {
                Console.WriteLine(Message7);
            }
            else if (by3)
            {
                Console.WriteLine(Message3);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}