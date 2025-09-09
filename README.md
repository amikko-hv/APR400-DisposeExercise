# APR400-DisposeExercise

In this exercise you will explore how memory management and garbage collection work in C#.

You will learn:

- Why unmanaged resources (like file handles) need explicit cleanup.
- How to implement the IDisposable pattern.
- How finalizers (~ClassName) interact with the garbage collector.
- Why using is safer than relying on the garbage collector.

## Getting Started

1. Open the solution in your IDE
2. Build and run the project.
3. Observe what happens when the program writes to log.txt.
4. Try opening log.txt in another editor (e.g. Notepad).
5. Notice the file may be locked while your program is running.

## Task

In *FileWriter.cs*

1. Implement the IDisposable interface
  - Dispose the StreamWriter and FileStream
  - Print *"File writer disposed"* to console when clean up happens

2. Add a finalizer
  - Log "FileWriter finalizer called" to the console when it runs.

3. From the finalizer, call `Dispose()` if the resources weren’t already disposed.

In *Program.cs*

1. Dispose the FileWriter
  - First try calling `Dispose()` manually.
  - Try replacing with `using` statement.
  - Try replacing with `using` declaration.

## Think About

- Why do we want a finalizer?
- Why is relying on the finalizer a bad idea?
- What advantages does using give you over calling Dispose() manually?
