namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 72, align: 8)]
    public class CCEFootStep : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public EFoot _foot;
        [FieldAttr(nst: 84, ctr: 68)] public bool _walking;
        [FieldAttr(nst: 85, ctr: 69)] public bool _ignoreCommonSound;
        [FieldAttr(nst: 86, ctr: 70)] public bool _ignoreMaterialSound;
    }
}
