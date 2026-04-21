using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 224, ctr: 224)]
    public class hkbDockingGenerator : hkbGenerator
    {
        public override uint Hash => 0x7f8f8240;

        [FieldAttr(nst: 136, ctr: 132)] public i16 _dockingBone;
        [FieldAttr(nst: 144, ctr: 144)] public Vector4 _translationOffset;
        [FieldAttr(nst: 160, ctr: 160)] public Vector4 _rotationOffset;
        [FieldAttr(nst: 176, ctr: 176)] public EBlendType _blendType;
        [FieldAttr(nst: 178, ctr: 178)] public EDockingFlagBits _flags;
        [FieldAttr(nst: 184, ctr: 184)] public hkbGenerator? _child;
        [FieldAttr(nst: 192, ctr: 192)] public int _intervalStart;
        [FieldAttr(nst: 196, ctr: 196)] public int _intervalEnd;
        [FieldAttr(nst: 200, ctr: 200)] public float _localTime;
        [FieldAttr(nst: 204, ctr: 204)] public float _previousLocalTime;
        [FieldAttr(nst: 208, ctr: 208)] public float _intervalStartLocalTime;
        [FieldAttr(nst: 212, ctr: 212)] public float _intervalEndLocalTime;
    }
}