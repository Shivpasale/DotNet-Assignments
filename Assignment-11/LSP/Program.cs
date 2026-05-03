﻿using System;

class Bird { }

class FlyingBird : Bird
{
    public void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

class Sparrow : FlyingBird { }

class Penguin : Bird { }

class Program
{
    static void Main()
    {
        Sparrow sparrow = new Sparrow();
        sparrow.Fly();

        Penguin Penguin = new Penguin();
        Console.WriteLine("Penguin cannot fly");
    }
}