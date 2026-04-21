using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 160, ctr: 160)]
    public class hknpCompressedMeshShape : hknpCompositeShape
    {
        public override uint Hash => 0x5f60d536;

        [FieldAttr(nst: 96, ctr: 88)] public hknpCompressedMeshShapeData? _data;
        [FieldAttr(nst: 104, ctr: 96)] public hkBitField? _quadIsFlat;
        [FieldAttr(nst: 128, ctr: 120)] public hkBitField? _triangleIsInterior;
        [FieldAttr(nst: 152, ctr: 144)] public int _numTriangles;
        [FieldAttr(nst: 156, ctr: 148)] public int _numConvexShapes;
    }
}