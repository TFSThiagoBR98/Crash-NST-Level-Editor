namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CEnterMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CEntity? _activator;
    }
}
