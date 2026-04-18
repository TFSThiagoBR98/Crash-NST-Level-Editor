namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CContactMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CNovaCollisionInfo? _contact;
        [FieldAttr(nst: 64)] public igRawRefMetaField _collision = new();
    }
}
