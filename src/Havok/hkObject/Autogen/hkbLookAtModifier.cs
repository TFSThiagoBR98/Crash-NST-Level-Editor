using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 256, ctr: 256)]
    public class hkbLookAtModifier : hkbModifier
    {
        public override uint Hash => 0x9ad8d4bb;

        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _targetWS;
        [FieldAttr(nst: 112, ctr: 112)] public Vector4 _headForwardLS;
        [FieldAttr(nst: 128, ctr: 128)] public Vector4 _neckForwardLS;
        [FieldAttr(nst: 144, ctr: 144)] public Vector4 _neckRightLS;
        [FieldAttr(nst: 160, ctr: 160)] public Vector4 _eyePositionHS;
        [FieldAttr(nst: 176, ctr: 176)] public float _newTargetGain;
        [FieldAttr(nst: 180, ctr: 180)] public float _onGain;
        [FieldAttr(nst: 184, ctr: 184)] public float _offGain;
        [FieldAttr(nst: 188, ctr: 188)] public float _limitAngleDegrees;
        [FieldAttr(nst: 192, ctr: 192)] public float _limitAngleLeft;
        [FieldAttr(nst: 196, ctr: 196)] public float _limitAngleRight;
        [FieldAttr(nst: 200, ctr: 200)] public float _limitAngleUp;
        [FieldAttr(nst: 204, ctr: 204)] public float _limitAngleDown;
        [FieldAttr(nst: 208, ctr: 208)] public i16 _headIndex;
        [FieldAttr(nst: 210, ctr: 210)] public i16 _neckIndex;
        [FieldAttr(nst: 212, ctr: 212)] public bool _isOn;
        [FieldAttr(nst: 213, ctr: 213)] public bool _individualLimitsOn;
        [FieldAttr(nst: 214, ctr: 214)] public bool _isTargetInsideLimitCone;
        [FieldAttr(nst: 224, ctr: 224)] public Vector4 _lookAtLastTargetWS;
        [FieldAttr(nst: 240, ctr: 240)] public float _lookAtWeight;
    }
}