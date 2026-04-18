namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneCheatUnlockable : COctaneUnlockable
    {
        [FieldAttr(ctr: 28)] public EOctaneCheats _cheatId;
    }
}
