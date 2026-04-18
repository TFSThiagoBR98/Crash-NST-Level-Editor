namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class igAttr : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public i16 _cachedUnitID;
        [FieldAttr(nst: 18, ctr: 14)] public i16 _cachedAttrIndex = -1;
        [FieldAttr(nst: 20, ctr: 16)] public bool _readOnlyCopy;
    }
}
