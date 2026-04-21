using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 128, ctr: 128)]
    public class hkbRotateCharacterModifier : hkbModifier
    {
        public override uint Hash => 0x8127360f;

        [FieldAttr(nst: 88, ctr: 84)] public float _degreesPerSecond;
        [FieldAttr(nst: 92, ctr: 88)] public float _speedMultiplier;
        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _axisOfRotation;
        [FieldAttr(nst: 112, ctr: 112)] public float _angle;
    }
}