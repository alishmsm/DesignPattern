﻿namespace Decoratorr;

public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("This is New Feature!!");
    }
}