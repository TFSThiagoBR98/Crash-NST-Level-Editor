namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 8)]
    public class RangedFloat : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igRangedFloatMetaField _storage = new();
    }
}
