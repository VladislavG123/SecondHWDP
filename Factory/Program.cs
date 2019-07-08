using System;


class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with Canon.");
        ClientCode(new Canon());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with HP.");
        ClientCode(new Hp());
    }
    
    public void ClientCode(Printer printer)
    {
        Console.WriteLine($"{printer.GetName()} " + printer.Print());
    }
}

public abstract class Printer
{
    public abstract IPaper GetPaper();

    public abstract string GetName();

    public string Print()
    {
        // Вызываем фабричный метод, чтобы получить объект-продукт.
        IPaper bullet = GetPaper();
        // Далее, работаем с этим продуктом.
        string result = "works with "
            + bullet.GetName();

        return result;
    }
}


public interface IPaper
{
    string GetName();
}

class Hp : Printer
{
    public override IPaper GetPaper()
    {
        return new OffsetPaper();
    }

    public override string GetName()
    {
        return "HP";
    }
}

internal class OffsetPaper : IPaper
{
    public string GetName()
    {
        return "Offset";
    }
}

class Canon : Printer
{
    public override IPaper GetPaper()
    {
        return new Perl();
    }

    public override string GetName()
    {
        return "Canon";
    }
}

internal class Perl : IPaper
{
    public string GetName()
    {
        return "Perl";
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
        Console.ReadLine();
    }
}
