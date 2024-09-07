using Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        AdminPrototype admin = new AdminPrototype();

        Valores uno = (Valores)admin.ObtenPrototipo("Valores");
        Console.Write("Valor:");
        Console.WriteLine(uno);
        Console.ReadLine();

    }
}
