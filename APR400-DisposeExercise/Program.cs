using APR400_DisposeExercise;

Console.WriteLine("Starting program...");

for (int i = 0; i < 5; i++)
{
    // TODO: Dispose the FileWriter
    var writer = new FileWriter("log.txt");
    writer.WriteMessage($"Message {i}");
}

Console.WriteLine("Writers created. Try opening log.txt in another editor.");
Console.WriteLine("Then press a key to force GC...");
Console.ReadKey();

// Force garbage collection
// Do not do this in a real application!
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("GC forced. Press any key to exit.");
Console.ReadKey();