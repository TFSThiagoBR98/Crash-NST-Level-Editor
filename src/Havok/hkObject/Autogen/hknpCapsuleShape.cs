using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 96)]
    public class hknpCapsuleShape : hknpConvexPolytopeShape
    {
        public override uint Hash => 0x60a75f4c;

        [FieldAttr(nst: 80, ctr: 64)] public Vector4 _a;
        [FieldAttr(nst: 96, ctr: 80)] public Vector4 _b;
    }
}