// See https://aka.ms/new-console-template for more information

using APR400_DisposeExercise;

Console.WriteLine("Starting program...");

for (int i = 0; i < 5; i++)
{
    var writer = new FileWriter("log.txt");
    writer.WriteMessage($"Message {i}");

    // Uncomment this to test disposal:
    // writer.Dispose();
}

Console.WriteLine("Writers created. Try opening log.txt in another editor.");
Console.WriteLine("Then press a key to force GC...");
Console.ReadKey();

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("GC forced. Press any key to exit.");
Console.ReadKey();