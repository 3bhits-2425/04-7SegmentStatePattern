public class State4 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State4()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State4();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 4;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State3.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State5.GetState();
    }
}

