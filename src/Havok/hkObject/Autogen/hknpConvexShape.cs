using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 48)]
    public class hknpConvexShape : hknpShape
    {
        public override uint Hash => 0xc8f7c10d;

        [FieldAttr(nst: 48, ctr: 40)] public hkList<Vector4> _vertices;
    }
}