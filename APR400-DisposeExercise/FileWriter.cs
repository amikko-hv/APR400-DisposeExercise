namespace APR400_DisposeExercise;

// TODO:
// 1. Implement IDisposable properly so that the file handle is released.
// 2. Add a finalizer and log to console when it runs
// 3. Dispose from the finalizer if the resources aren't disposed

public class FileWriter
{
    private FileStream _stream;
    private StreamWriter _writer;

    public FileWriter(string path)
    {
        _stream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write);
        _writer = new StreamWriter(_stream);
        Console.WriteLine("FileWriter created.");
    }

    public void WriteMessage(string message)
    {
        _writer.WriteLine(message);
        _writer.Flush();
        Console.WriteLine($"Wrote: {message}");
    }
}