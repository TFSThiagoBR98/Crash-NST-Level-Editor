namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CNavMoverComponentData : CEntityComponentData
    {
        public enum ENavMoverMoveMethod
        {
            eNMMM_ActorInput = 0,
            eNMMM_SetPosition = 1,
            eNMMM_SetVelocity = 2,
            eNMMM_None = 3,
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public CNavMoverComponentData.ENavMoverMoveMethod _moveMethod;
            [FieldAttr(offset: 3, size: 1)] public bool _allowSpaceChanges;
            [FieldAttr(offset: 4, size: 1)] public bool _allowSeparationFromNavMesh;
            [FieldAttr(offset: 5, size: 5)] public uint _linkCapabilities;
            [FieldAttr(offset: 10, size: 10)] public uint _repulsorBlockageFlags;
            [FieldAttr(offset: 20, size: 10)] public uint _repulsorIdentityFlags;
            [FieldAttr(offset: 30, size: 2)] public uint _areaUsageFlags;
        }

        [FieldAttr(nst: 24, ctr: 16)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 28, ctr: 20)] public float _moverRadius;
        [FieldAttr(nst: 32, ctr: 24)] public float _radiusCushion = 20.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _stopDistance = 39.0f;
        [FieldAttr(nst: 40, ctr: 32)] public float _earlyJumpDistance = 10.0f;
        [FieldAttr(nst: 44, ctr: 36)] public float _pathSharingPenalty = 2.0f;
        [FieldAttr(nst: 48, ctr: 40)] public float _maxPathSharingPenalty = 20.0f;
    }
}
