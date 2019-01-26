using StatePattern.@interface;

namespace StatePattern.States
{
    public class StartState :IState
    {
        public void DoAction(Context context)
        {
            System.Console.WriteLine("Player is in Start State");
            context.SetState(this);

        }

        public override string ToString()
        {
            return "StartState";
        }
    }
}
