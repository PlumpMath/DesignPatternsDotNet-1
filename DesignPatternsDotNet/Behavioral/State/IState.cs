namespace DesignPatternsDotNet.Behavioral.State
{
    public interface IState<TContext>
        where TContext : IContext
    {
        void Handle(TContext context);
    }
}
