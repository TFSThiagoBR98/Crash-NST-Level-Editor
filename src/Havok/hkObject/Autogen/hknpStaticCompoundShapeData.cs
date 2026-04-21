using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hknpStaticCompoundShapeData : hkReferencedObject
    {
        public override uint Hash => 0x4fd87fd9;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkcdStaticTreeCodec3Axis6> _nodes;
        [FieldAttr(nst: 32, ctr: 32)] public Vector4 _min;
        [FieldAttr(nst: 48, ctr: 48)] public Vector4 _max;
    }
}