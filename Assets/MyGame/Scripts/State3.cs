public class State3 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State3()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State3();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 3;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State2.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State4.GetState();
    }
}
