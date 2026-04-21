using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 112)]
    public class hknpMotionCinfo : hkObject
    {
        public override uint Hash => 0x693d1b16;

        [FieldAttr(nst: 0, ctr: 0)] public u16 _motionPropertiesId;
        [FieldAttr(nst: 2, ctr: 2)] public bool _enableDeactivation;
        [FieldAttr(nst: 4, ctr: 4)] public float _inverseMass;
        [FieldAttr(nst: 8, ctr: 8)] public float _massFactor;
        [FieldAttr(nst: 12, ctr: 12)] public float _maxLinearAccelerationDistancePerStep;
        [FieldAttr(nst: 16, ctr: 16)] public float _maxRotationToPreventTunneling;
        [FieldAttr(nst: 32, ctr: 32)] public Vector4 _inverseInertiaLocal;
        [FieldAttr(nst: 48, ctr: 48)] public Vector4 _centerOfMassWorld;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _orientation;
        [FieldAttr(nst: 80, ctr: 80)] public Vector4 _linearVelocity;
        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _angularVelocity;
    }
}