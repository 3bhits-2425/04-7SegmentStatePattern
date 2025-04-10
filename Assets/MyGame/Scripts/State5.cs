public class State5 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State5()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State5();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 5;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State4.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State6.GetState();
    }
}
