using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hknpConvexPolytopeShapeFace : hkObject
    {
        public override uint Hash => 0xf3c05540;

        [FieldAttr(nst: 0, ctr: 0)] public u16 _firstIndex;
        [FieldAttr(nst: 2, ctr: 2)] public u8 _numIndices;
        [FieldAttr(nst: 3, ctr: 3)] public u8 _minHalfAngle;
    }
}