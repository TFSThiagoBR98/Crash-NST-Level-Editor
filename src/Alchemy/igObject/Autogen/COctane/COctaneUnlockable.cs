namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneUnlockable : igObject
    {
        [FieldAttr(ctr: 16)] public string? _unlockString;
        [FieldAttr(ctr: 24)] public bool _hiddenWhenLocked;
        [FieldAttr(ctr: 25)] public bool _unlocked;
    }
}
