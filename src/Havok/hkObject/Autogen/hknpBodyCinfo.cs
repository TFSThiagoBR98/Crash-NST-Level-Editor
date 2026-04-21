using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hknpBodyCinfo : hkObject
    {
        public override uint Hash => 0x6896f7c9;

        [FieldAttr(nst: 0, ctr: 0)] public hknpShape? _shape;
        [FieldAttr(nst: 8, ctr: 8)] public uint _reservedBodyId;
        [FieldAttr(nst: 12, ctr: 12)] public uint _motionId;
        [FieldAttr(nst: 16, ctr: 16)] public u8 _qualityId;
        [FieldAttr(nst: 18, ctr: 18)] public u16 _materialId;
        [FieldAttr(nst: 20, ctr: 20)] public uint _collisionFilterInfo;
        [FieldAttr(nst: 24, ctr: 24)] public int _flags;
        [FieldAttr(nst: 28, ctr: 28)] public float _collisionLookAheadDistance;
        [FieldAttr(nst: 32, ctr: 32)] public string? _name;
        [FieldAttr(nst: 40, ctr: 40)] public u64 _userData;
        [FieldAttr(nst: 48, ctr: 48)] public Vector4 _position;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _orientation;
        [FieldAttr(nst: 80, ctr: 80)] public u8 _spuFlags;
        [FieldAttr(nst: 88, ctr: 88)] public hkLocalFrame? _localFrame;
    }
}