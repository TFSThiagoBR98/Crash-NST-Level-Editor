using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 128, ctr: 128)]
    public class hknpShapeInstance : hkObject
    {
        public override uint Hash => 0x5e3dae05;

        [FieldAttr(nst: 0, ctr: 0)] public Matrix4x4 _transform;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _scale;
        [FieldAttr(nst: 80, ctr: 80)] public hknpShape? _shape;
        [FieldAttr(nst: 88, ctr: 88)] public u16 _shapeTag;
        [FieldAttr(nst: 90, ctr: 90)] public u16 _destructionTag;
    }
}