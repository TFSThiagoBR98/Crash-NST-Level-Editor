namespace Alchemy
{
    [ObjectAttr(nst: 256, align: 8)]
    public class CGuiBehaviorCrashContinueGameButton : CGuiBehaviorContinueGameButton
    {
        [FieldAttr(nst: 248)] public ECrashGame _crashGame;
    }
}
