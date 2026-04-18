namespace Alchemy
{
    [ObjectAttr(nst: 240, align: 8)]
    public class CGuiBehaviorCrashNewGameButton : CGuiBehaviorNewGameButton
    {
        [FieldAttr(nst: 232)] public ECrashGame _crashGame;
    }
}
