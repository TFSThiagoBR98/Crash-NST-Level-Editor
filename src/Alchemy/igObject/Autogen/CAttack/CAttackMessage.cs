namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CAttackMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CDamageInstance? _damage;
    }
}
