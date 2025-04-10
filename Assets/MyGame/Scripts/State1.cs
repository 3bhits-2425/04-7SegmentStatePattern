public class State1 : ISevenSegmentDisplayState
{
        //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
        private static ISevenSegmentDisplayState _state;

        //konstruktor für obekte vom Typ State0
        private State1()
        {
        }

        public static ISevenSegmentDisplayState GetState()
        {
            if (_state == null)
            {
                //erstellen einer neuen Instanz von State0 wenn keine existiert
                _state = new State1();
            }
            return _state;
        }

        public int GetDigit()
        {
            return 1;
        }

        public ISevenSegmentDisplayState CountDown()
        {
            return State0.GetState();
        }

        public ISevenSegmentDisplayState CountUp()
    {
        return State2.GetState();
    }
}
