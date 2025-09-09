namespace APR400_DisposeExercise;

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

    // TODO:
    // 1. Implement IDisposable properly so that the file handle is released.
    // 2. Add a finalizer (~FileWriter) to see when the GC runs it.
    // 3. (Optional) Follow the "dispose pattern" for future-proofing.
}