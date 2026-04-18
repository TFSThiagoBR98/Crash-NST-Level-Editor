namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CDeathMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CEntity? _killer;
        [FieldAttr(nst: 64, refCount: false)] public CDamageInstance? _damage;
    }
}
