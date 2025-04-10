public class State7 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State7()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State7();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 7;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State6.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State8.GetState();
    }
}

