namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCESetFlags : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public ECombatTargetSelect mTarget = ECombatTargetSelect.eCTS_Self;
        [FieldAttr(nst: 84)] public bool mReset;
        [FieldAttr(nst: 88)] public EFlagsWrapperList? mFlagList;
    }
}
