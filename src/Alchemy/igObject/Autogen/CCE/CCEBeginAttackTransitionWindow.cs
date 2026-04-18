namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 72, align: 8)]
    public class CCEBeginAttackTransitionWindow : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public uint _attacks = 7;
    }
}
