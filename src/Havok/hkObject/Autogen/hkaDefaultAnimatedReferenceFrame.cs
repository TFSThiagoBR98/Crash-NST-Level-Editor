using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 80)]
    public class hkaDefaultAnimatedReferenceFrame : hkaAnimatedReferenceFrame
    {
        public override uint Hash => 0x60f8e0b8;

        [FieldAttr(nst: 32, ctr: 16)] public Vector4 _up;
        [FieldAttr(nst: 48, ctr: 32)] public Vector4 _forward;
        [FieldAttr(nst: 64, ctr: 48)] public float _duration;
        [FieldAttr(nst: 72, ctr: 56)] public hkMemory<Vector4> _referenceFrameSamples;
    }
}