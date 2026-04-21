using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hkbHandIkDriverInfoHand : hkObject
    {
        public override uint Hash => 0x14dfe1dd;

        [FieldAttr(nst: 0, ctr: 0)] public Vector4 _elbowAxisLS;
        [FieldAttr(nst: 16, ctr: 16)] public Vector4 _backHandNormalLS;
        [FieldAttr(nst: 32, ctr: 32)] public Vector4 _handOffsetLS;
        [FieldAttr(nst: 48, ctr: 48)] public Quaternion _handOrienationOffsetLS;
        [FieldAttr(nst: 64, ctr: 64)] public float _maxElbowAngleDegrees;
        [FieldAttr(nst: 68, ctr: 68)] public float _minElbowAngleDegrees;
        [FieldAttr(nst: 72, ctr: 72)] public i16 _shoulderIndex;
        [FieldAttr(nst: 74, ctr: 74)] public i16 _shoulderSiblingIndex;
        [FieldAttr(nst: 76, ctr: 76)] public i16 _elbowIndex;
        [FieldAttr(nst: 78, ctr: 78)] public i16 _elbowSiblingIndex;
        [FieldAttr(nst: 80, ctr: 80)] public i16 _wristIndex;
        [FieldAttr(nst: 82, ctr: 82)] public bool _enforceEndPosition;
        [FieldAttr(nst: 83, ctr: 83)] public bool _enforceEndRotation;
        [FieldAttr(nst: 88, ctr: 88)] public string _localFrameName;
    }
}