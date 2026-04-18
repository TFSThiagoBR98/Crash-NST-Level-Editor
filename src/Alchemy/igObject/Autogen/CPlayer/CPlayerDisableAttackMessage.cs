namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CPlayerDisableAttackMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public uint _attacks = 7;
        [FieldAttr(nst: 60)] public bool _disable = true;
    }
}
