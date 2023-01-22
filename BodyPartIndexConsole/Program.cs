using BodyPartIndexLib;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("BodyPartIndex version: " + BodyPartIndex.version());
    }

    void ResetConsole() {
        Console.WriteLine("Resetting console...");
        Console.ResetColor();
        Console.Clear();
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
