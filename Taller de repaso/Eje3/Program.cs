// See https://aka.ms/new-console-template for more information

using System;

abstract class AbstractSample
{
    private string message;

    public abstract void PrintMessage(string msg);

    public virtual void InvertMessage(string msg)
    {
        message = msg;
        char[] chars = message.ToCharArray();
        Array.Reverse(chars);
        message = new string(chars);

        Console.WriteLine("Invertido: " + message);
    }

    protected void SetMessage(string msg)
    {
        message = msg;
    }

    protected string GetMessage()
    {
        return message;
    }
}

class NormalMessage : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        SetMessage(msg);
        Console.WriteLine("Normal: " + GetMessage());
    }
}

class InvertedCaseMessage : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        SetMessage(msg);
        char[] chars = GetMessage().ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = char.IsUpper(chars[i])
                ? char.ToLower(chars[i])
                : char.ToUpper(chars[i]);
        }

        Console.WriteLine("Mayúsculas/Minúsculas invertidas: " + new string(chars));
    }

    public override void InvertMessage(string msg)
    {
        char[] chars = msg.ToCharArray();
        Array.Reverse(chars);

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
                chars[i] = char.ToLower(chars[i]);
            else
                chars[i] = char.ToUpper(chars[i]);
        }

        Console.WriteLine("Invertido + May/Min invertidas: " + new string(chars));
    }
}

class MessageManager
{
    public void Run()
    {
        AbstractSample msg1 = new NormalMessage();
        AbstractSample msg2 = new InvertedCaseMessage();

        msg1.PrintMessage("Hola Mundo");
        msg1.InvertMessage("Hola Mundo");

        Console.WriteLine();

        msg2.PrintMessage("Hola Mundo");
        msg2.InvertMessage("Hola Mundo");
    }
}


class Program
{
    static void Main()
    {
        MessageManager manager = new MessageManager();
        manager.Run();
    }
}
