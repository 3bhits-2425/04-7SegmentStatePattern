public class State0 : ISevenSegmentDisplayState
{
    //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
    private static ISevenSegmentDisplayState _state;

    //konstruktor für obekte vom Typ State0
    private State0() { 
    }

    public static ISevenSegmentDisplayState GetState()
    {
        if(_state == null)
        {
            //erstellen einer neuen Instanz von State0 wenn keine existiert
            _state = new State0();
        }
        return _state;
    }

    public int GetDigit()
    {
        return 0;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State9.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State1.GetState();
    }
}
