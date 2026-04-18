namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CDamageMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CDamageInstance? _damage;
    }
}
