public class State2 : ISevenSegmentDisplayState
{
        //erstellen einer static Variable vom Typ ISevenSegmentDisplayState
        private static ISevenSegmentDisplayState _state;

        //konstruktor für obekte vom Typ State0
        private State2()
        {
        }

        public static ISevenSegmentDisplayState GetState()
        {
            if (_state == null)
            {
                //erstellen einer neuen Instanz von State0 wenn keine existiert
                _state = new State2();
            }
            return _state;
        }

        public int GetDigit()
        {
            return 2;
        }

        public ISevenSegmentDisplayState CountDown()
        {
            return State1.GetState();
        }

        public ISevenSegmentDisplayState CountUp()
        {
            return State3.GetState();
        }
    }
