// See https://aka.ms/new-console-template for more information

foreach (var output in Algorithms.FizzBuzz.Generate(
             [
                 (3, "Ben"),
                 (5, "Jeffrey"),
                 (7, "Bob")
             ], 150)
         )
{
    Console.WriteLine(output);
}