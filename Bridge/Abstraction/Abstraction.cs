using Bridge.Implementors;

namespace Bridge.Abstraction;

public abstract class Abstraction
{
    private Implementor implementor;

    public Abstraction()
    {
        implementor = new ConcreateImplementor();
    }
    public virtual void Function()
    {
        implementor.Implementaion();
    }
}