using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 160, ctr: 144)]
    public class hknpCharacterRigidBodyCinfo : hkReferencedObject
    {
        public override uint Hash => 0x4979c225;

        [FieldAttr(nst: 16, ctr: 12)] public uint _collisionFilterInfo;
        [FieldAttr(nst: 24, ctr: 16)] public hknpShape? _shape;
        [FieldAttr(nst: 32, ctr: 24)] public uint _world;
        [FieldAttr(nst: 48, ctr: 32)] public Vector4 _position;
        [FieldAttr(nst: 64, ctr: 48)] public Vector4 _orientation;
        [FieldAttr(nst: 80, ctr: 64)] public float _mass;
        [FieldAttr(nst: 84, ctr: 68)] public float _dynamicFriction;
        [FieldAttr(nst: 88, ctr: 72)] public float _staticFriction;
        [FieldAttr(nst: 92, ctr: 76)] public float _weldingTolerance;
        [FieldAttr(nst: 96, ctr: 80)] public uint _reservedBodyId;
        [FieldAttr(nst: 100, ctr: 84)] public EAdditionMode _additionMode;
        [FieldAttr(nst: 101, ctr: 85)] public u8 _additionFlags;
        [FieldAttr(nst: 112, ctr: 96)] public Vector4 _up;
        [FieldAttr(nst: 128, ctr: 112)] public float _maxSlope;
        [FieldAttr(nst: 132, ctr: 116)] public float _maxForce;
        [FieldAttr(nst: 136, ctr: 120)] public float _maxSpeedForSimplexSolver;
        [FieldAttr(nst: 140, ctr: 124)] public float _supportDistance;
        [FieldAttr(nst: 144, ctr: 128)] public float _hardSupportDistance;
    }
}