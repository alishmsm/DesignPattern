

using Bridge.Abstraction;
using Decoratorr;
using Facade;
#region Decoratorr
//
// ConcreteComponent concreteComponent = new ConcreteComponent();
// ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);
// concreteDecorator.Operation();
//
#endregion

#region Facade
// Facade.Facade facade = new Facade.Facade();
// facade.DoSomething();        
#endregion

#region Bridge

Abstraction abstraction = new RefinedAbstraction();
abstraction.Function();
#endregion



