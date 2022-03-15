// See https://aka.ms/new-console-template for more information

var numbers = new[] {12.7, 2.3, 1.1, 4.2};

var sum = 0.0;
foreach(var number in numbers) {
   sum += number;
   
}

Console.WriteLine(sum);

if (args.Length > 0) {
    Console.WriteLine($"Hello, {args[0]}!");
} else {
    Console.WriteLine("Hello, Rodriques!");
}


