
public interface ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    public int GetDigit();

    public static extern ISevenSegmentDisplayState GetState();
}
