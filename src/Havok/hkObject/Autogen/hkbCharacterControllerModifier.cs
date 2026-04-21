using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 176, ctr: 176)]
    public class hkbCharacterControllerModifier : hkbModifier
    {
        public override uint Hash => 0x74239623;

        [FieldAttr(nst: 88, ctr: 84)] public hkbCharacterControllerModifierControlData? _controlData;
        [FieldAttr(nst: 112, ctr: 112)] public Vector4 _initialVelocity;
        [FieldAttr(nst: 128, ctr: 128)] public EInitialVelocityCoordinates _initialVelocityCoordinates;
        [FieldAttr(nst: 129, ctr: 129)] public EMotionMode _motionMode;
        [FieldAttr(nst: 130, ctr: 130)] public bool _forceDownwardMomentum;
        [FieldAttr(nst: 131, ctr: 131)] public bool _applyGravity;
        [FieldAttr(nst: 132, ctr: 132)] public bool _setInitialVelocity;
        [FieldAttr(nst: 133, ctr: 133)] public bool _isTouchingGround;
        [FieldAttr(nst: 144, ctr: 144)] public Vector4 _gravity;
        [FieldAttr(nst: 160, ctr: 160)] public bool _isInitialVelocityAdded;
    }
}