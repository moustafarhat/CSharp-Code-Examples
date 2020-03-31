using StatePattern.@interface;

namespace StatePattern.States
{
    public class StopState : IState

    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("Player is in Stop State");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "StopState";
        }
    }
}