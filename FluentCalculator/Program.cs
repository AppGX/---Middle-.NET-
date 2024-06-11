using System;

public class Value
{
    public int Number { get; }

    public Value(int number)
    {
        Number = number;
    }

    public Operation Plus => new Operation(this, "plus");
    public Operation Minus => new Operation(this, "minus");
    public Operation Times => new Operation(this, "times");
    public Operation DividedBy => new Operation(this, "dividedBy");

    public static implicit operator int(Value v) => v.Number;
}

public class Operation
{
    private readonly Value _value;
    private readonly string _operation;

    public Operation(Value value, string operation)
    {
        _value = value;
        _operation = operation;
    }

    private int Evaluate(Value nextValue)
    {
        return _operation switch
        {
            "plus" => _value.Number + nextValue.Number,
            "minus" => _value.Number - nextValue.Number,
            "times" => _value.Number * nextValue.Number,
            "dividedBy" => _value.Number / nextValue.Number,
            _ => throw new InvalidOperationException("Invalid operation")
        };
    }

    public Value Zero => Calculate(0);
    public Value One => Calculate(1);
    public Value Two => Calculate(2);
    public Value Three => Calculate(3);
    public Value Four => Calculate(4);
    public Value Five => Calculate(5);
    public Value Six => Calculate(6);
    public Value Seven => Calculate(7);
    public Value Eight => Calculate(8);
    public Value Nine => Calculate(9);
    public Value Ten => Calculate(10);

    private Value Calculate(int number)
    {
        int result = Evaluate(new Value(number));
        return new Value(result);
    }
}

public class FluentCalculator
{
    public Value Zero => new Value(0);
    public Value One => new Value(1);
    public Value Two => new Value(2);
    public Value Three => new Value(3);
    public Value Four => new Value(4);
    public Value Five => new Value(5);
    public Value Six => new Value(6);
    public Value Seven => new Value(7);
    public Value Eight => new Value(8);
    public Value Nine => new Value(9);
    public Value Ten => new Value(10);
}

class Program
{
    static void Main()
    {
        var calculator = new FluentCalculator();

        // Примеры использования:
        Console.WriteLine((int)calculator.One.Plus.Two); // Должно вывести 3
        Console.WriteLine((int)calculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four); // Должно вывести -1
        Console.WriteLine((int)calculator.One.Plus.Ten - 10); // Должно вывести 1
    }
}
