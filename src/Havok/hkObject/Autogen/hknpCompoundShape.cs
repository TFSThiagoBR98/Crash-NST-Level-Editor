using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 192, ctr: 192)]
    public class hknpCompoundShape : hknpCompositeShape
    {
        public override uint Hash => 0x247d5e99;

        [FieldAttr(nst: 96, ctr: 96)] public hkMemory<hknpShapeInstance> _elements;
        [FieldAttr(nst: 112, ctr: 112)] public int _firstFree;
        [FieldAttr(nst: 128, ctr: 128)] public Vector4 _min;
        [FieldAttr(nst: 144, ctr: 144)] public Vector4 _max;
        [FieldAttr(nst: 160, ctr: 160)] public bool _isMutable;
        [FieldAttr(nst: 168, ctr: 168)] public uint _shapeMutated;
        [FieldAttr(nst: 176, ctr: 176)] public uint _shapeDestroyed;
    }
}