public class State9 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State9()
    {
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State9();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 9;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State8.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State0.GetState();
    }
}
