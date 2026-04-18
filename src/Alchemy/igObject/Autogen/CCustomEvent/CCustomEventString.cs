namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CCustomEventString : CCustomEvent
    {
        [FieldAttr(nst: 64)] public string? _string = null;
    }
}
