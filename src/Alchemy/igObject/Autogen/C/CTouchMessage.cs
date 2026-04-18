namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CTouchMessage : CEntityMessage
    {
        [FieldAttr(nst: 56, refCount: false)] public CEntity? _activator;
    }
}
