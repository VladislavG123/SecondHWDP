using System;
using System.Collections.Generic;

public interface IBuilder
{
    void BuildBody();

    void BuildMainboard();

    void BuildProcessor();

    void BuildVideoCard();

    void BuildSoundCard();

    void BuildTuner();
}

public class Dell : IBuilder
{
    private Complectation _complectation = new Complectation();

    public Dell()
    {
        Reset();
    }

    public void Reset()
    {
        _complectation = new Complectation();
    }

    public void BuildBody()
    {
        _complectation.Add("Body");
    }

    public void BuildMainboard()
    {
        _complectation.Add("Dell Mainboard");
    }

    public void BuildProcessor()
    {
        _complectation.Add("Dell processor");
    }

    public Complectation GetComplectation()
    {
        Complectation result = _complectation;

        Reset();

        return result;
    }

    public void BuildVideoCard()
    {
        _complectation.Add("Dell video card");
    }

    public void BuildSoundCard()
    {
        _complectation.Add("Dell sound card");
    }

    public void BuildTuner()
    {
        _complectation.Add("Dell tuner");
    }
}


public class Sony : IBuilder
{
    private Complectation _complectation = new Complectation();

    public Sony()
    {
        Reset();
    }

    public void Reset()
    {
        _complectation = new Complectation();
    }

    public void BuildBody()
    {
        _complectation.Add("Body");
    }

    public void BuildMainboard()
    {
        _complectation.Add("Sony Mainboard");
    }

    public void BuildProcessor()
    {
        _complectation.Add("Sony processor");
    }

    public Complectation GetComplectation()
    {
        Complectation result = _complectation;

        Reset();

        return result;
    }

    public void BuildVideoCard()
    {
        _complectation.Add("Sony video card");
    }

    public void BuildSoundCard()
    {
        _complectation.Add("Sony sound card");
    }

    public void BuildTuner()
    {
        _complectation.Add("Sony tuner");
    }
}


public class Complectation
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}

public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void Basic()
    {
        _builder.BuildMainboard();
        _builder.BuildProcessor();
    }

    internal void Standart()
    {
        _builder.BuildBody();
        _builder.BuildMainboard();
        _builder.BuildProcessor();
    }

    internal void StandartPlus()
    {
        _builder.BuildBody();
        _builder.BuildMainboard();
        _builder.BuildProcessor();
        _builder.BuildVideoCard();
    }

    internal void Lux()
    {
        _builder.BuildBody();
        _builder.BuildMainboard();
        _builder.BuildProcessor();
        _builder.BuildVideoCard();
        _builder.BuildSoundCard();
        _builder.BuildTuner();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        Dell dell = new Dell();
        director.Builder = dell;

        Console.WriteLine("Basic dell complectation:\n");
        director.Basic();
        Console.WriteLine(dell.GetComplectation().ListParts());

        Console.WriteLine("Standard dell complectation:\n");
        director.Standart();
        Console.WriteLine(dell.GetComplectation().ListParts());

        Console.WriteLine("Standard plus dell complectation:\n");
        director.Standart();
        Console.WriteLine(dell.GetComplectation().ListParts());

        Console.WriteLine("Lux dell complectation:\n");
        director.Lux();
        Console.WriteLine(dell.GetComplectation().ListParts());

        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

        Sony sony = new Sony();
        director.Builder = sony;

        Console.WriteLine("Basic sony complectation:\n");
        director.Basic();
        Console.WriteLine(sony.GetComplectation().ListParts());

        Console.WriteLine("Standard sony complectation:\n");
        director.Standart();
        Console.WriteLine(sony.GetComplectation().ListParts());

        Console.WriteLine("Standard plus sony complectation:\n");
        director.Standart();
        Console.WriteLine(sony.GetComplectation().ListParts());

        Console.WriteLine("Lux sony complectation:\n");
        director.Lux();
        Console.WriteLine(sony.GetComplectation().ListParts());
        
        Console.ReadLine();
    }
}