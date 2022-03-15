// See https://aka.ms/new-console-template for more information

double[] numbers = new double[3];
numbers[0] = 12.7;
numbers[1] = 2.3;
numbers[2] = 1.1;

double sum = numbers[0] + numbers[1] + numbers[2];

Console.WriteLine(sum);

if (args.Length > 0) {
    Console.WriteLine($"Hello, {args[0]}!");
} else {
    Console.WriteLine("Hello, Rodriques!");
}


