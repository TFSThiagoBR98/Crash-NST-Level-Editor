using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 160, ctr: 160)]
    public class hkbTwistModifier : hkbModifier
    {
        public override uint Hash => 0x98d623bc;

        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _axisOfRotation;
        [FieldAttr(nst: 112, ctr: 112)] public float _twistAngle;
        [FieldAttr(nst: 116, ctr: 116)] public i16 _startBoneIndex;
        [FieldAttr(nst: 118, ctr: 118)] public i16 _endBoneIndex;
        [FieldAttr(nst: 120, ctr: 120)] public ESetAngleMethod _setAngleMethod;
        [FieldAttr(nst: 121, ctr: 121)] public ERotationAxisCoordinates _rotationAxisCoordinates;
        [FieldAttr(nst: 122, ctr: 122)] public bool _isAdditive;
        [FieldAttr(nst: 128, ctr: 128)] public hkMemory<i16> _boneChainIndices;
        [FieldAttr(nst: 144, ctr: 144)] public hkMemory<i16> _parentBoneIndices;
    }
}