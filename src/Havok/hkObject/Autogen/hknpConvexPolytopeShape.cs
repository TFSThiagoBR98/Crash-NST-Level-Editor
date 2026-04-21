using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 64)]
    public class hknpConvexPolytopeShape : hknpConvexShape
    {
        public override uint Hash => 0x3ce9b3e3;

        [FieldAttr(nst: 64, ctr: 44)] public hkList<Vector4> _planes;
        [FieldAttr(nst: 68, ctr: 48)] public hkList<hknpConvexPolytopeShapeFace> _faces;
        [FieldAttr(nst: 72, ctr: 52)] public hkList<u8> _indices;
    }
}