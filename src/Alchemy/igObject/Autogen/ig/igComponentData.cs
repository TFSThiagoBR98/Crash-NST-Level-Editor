namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 8)]
    public class igComponentData : igObject
    {
        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isEnabled;
            [FieldAttr(offset: 1, size: 1)] public bool _isThreadSafe;
        }

        [FieldAttr(nst: 16, ctr: 12)] public Bitfield _bitfield = new();
    }
}
