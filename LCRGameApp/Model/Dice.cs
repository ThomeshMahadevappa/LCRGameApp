namespace LCRGameApp.Model
{
    public interface IDice
    {
        DiceResult RollDice();
    }

    public enum DiceResult
    {
        Left = 1,
        Right = 2,
        Center = 3,
        Dot1 = 4,
        Dot2 = 5,
        Dot3 = 6
    }
}
