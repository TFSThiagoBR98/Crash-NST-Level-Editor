namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CCustomEvent : CEntityMessage
    {
        [FieldAttr(nst: 56, ctr: 56)] public string? _name = null;
    }
}
