public class State8 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State8()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State8();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 8;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State7.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State9.GetState();
    }
}

