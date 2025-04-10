public class State6 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State6()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State6();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 6;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State5.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State7.GetState();
    }
}

