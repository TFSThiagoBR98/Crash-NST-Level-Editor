using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hknpShape : hkReferencedObject
    {
        public override uint Hash => 0xdb52aabb;

        [FieldAttr(nst: 16, ctr: 16)] public uint _flags;
        [FieldAttr(nst: 18, ctr: 18)] public u8 _numShapeKeyBits;
        [FieldAttr(nst: 19, ctr: 19)] public EEnum _dispatchType;
        [FieldAttr(nst: 20, ctr: 20)] public float _convexRadius;
        [FieldAttr(nst: 24, ctr: 24)] public u64 _userData;
        [FieldAttr(nst: 32, ctr: 32)] public hkRefCountedProperties? _properties;
    }
}