using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 320, ctr: 304)]
    public class hkbBlendingTransitionEffect : hkbTransitionEffect
    {
        public override uint Hash => 0x14e54c5c;

        [FieldAttr(nst: 168, ctr: 160)] public float _duration;
        [FieldAttr(nst: 172, ctr: 164)] public float _toGeneratorStartTimeFraction;
        [FieldAttr(nst: 176, ctr: 168)] public EFlagBits _flags;
        [FieldAttr(nst: 178, ctr: 170)] public EEndMode _endMode;
        [FieldAttr(nst: 179, ctr: 171)] public EBlendCurve _blendCurve;
        [FieldAttr(nst: 180, ctr: 172)] public i16 _alignmentBone;
        [FieldAttr(nst: 192, ctr: 176)] public Vector4 _fromPos;
        [FieldAttr(nst: 208, ctr: 192)] public Vector4 _fromRot;
        [FieldAttr(nst: 224, ctr: 208)] public Vector4 _toPos;
        [FieldAttr(nst: 240, ctr: 224)] public Vector4 _toRot;
        [FieldAttr(nst: 256, ctr: 240)] public Vector4 _lastPos;
        [FieldAttr(nst: 272, ctr: 256)] public Vector4 _lastRot;
        [FieldAttr(nst: 288, ctr: 272)] public hkMemory<Matrix3x4> _characterPoseAtBeginningOfTransition;
        [FieldAttr(nst: 304, ctr: 288)] public float _timeRemaining;
        [FieldAttr(nst: 308, ctr: 292)] public float _timeInTransition;
        [FieldAttr(nst: 312, ctr: 296)] public ESelfTransitionMode _toGeneratorSelfTranstitionMode;
        [FieldAttr(nst: 313, ctr: 297)] public bool _initializeCharacterPose;
        [FieldAttr(nst: 314, ctr: 298)] public bool _alignThisFrame;
        [FieldAttr(nst: 315, ctr: 299)] public bool _alignmentFinished;
    }
}