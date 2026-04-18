namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 80, align: 8)]
    public class CTakeHitImmunityHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public float _immunityDuration;
        [FieldAttr(nst: 84, ctr: 68)] public bool _fullyInvulnerable = true;
        [FieldAttr(nst: 85, ctr: 69)] public bool _pushBackImmunity;
        [FieldAttr(nst: 88, ctr: 72)] public CChangeRequestList? _changeRequests;
    }
}
