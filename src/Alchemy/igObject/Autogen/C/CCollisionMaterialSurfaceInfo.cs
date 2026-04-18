namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 88, align: 8)]
    public class CCollisionMaterialSurfaceInfo : igObject
    {
        [ObjectAttr(size: 2)]
        public class SpawnLayers : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _spawnLayer1;
            [FieldAttr(offset: 1, size: 1)] public bool _spawnLayer2;
            [FieldAttr(offset: 2, size: 1)] public bool _spawnLayer3;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnLayer4;
            [FieldAttr(offset: 4, size: 1)] public bool _spawnLayer5;
            [FieldAttr(offset: 5, size: 1)] public bool _spawnLayer6;
            [FieldAttr(offset: 6, size: 1)] public bool _spawnLayer7;
            [FieldAttr(offset: 7, size: 1)] public bool _spawnLayer8;
            [FieldAttr(offset: 8, size: 1)] public bool _spawnLayer9;
            [FieldAttr(offset: 9, size: 1)] public bool _spawnLayer10;
            [FieldAttr(offset: 10, size: 1)] public bool _spawnLayer11;
            [FieldAttr(offset: 11, size: 1)] public bool _spawnLayer12;
            [FieldAttr(offset: 12, size: 1)] public bool _spawnLayer13;
            [FieldAttr(offset: 13, size: 1)] public bool _spawnLayer14;
            [FieldAttr(offset: 14, size: 1)] public bool _spawnLayer15;
            [FieldAttr(offset: 15, size: 1)] public bool _spawnLayer16;
        }

        [ObjectAttr(size: 2)]
        public class SurfaceFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _preventRunning;
            [FieldAttr(offset: 1, size: 1)] public bool _ripplingSurface;
            [FieldAttr(offset: 2, size: 1)] public bool _queryOnly;
            [FieldAttr(offset: 3, size: 1)] public bool _deepWater;
            [FieldAttr(offset: 4, size: 1)] public bool _chasm;
            [FieldAttr(offset: 5, size: 1)] public bool _preventJumping;
            [FieldAttr(offset: 6, size: 1)] public bool _ignoreVehicleBlockingContacts;
            [FieldAttr(offset: 7, size: 1)] public bool _forceVehicleBlockingContacts;
            [FieldAttr(offset: 8, size: 1)] public bool _actionPackGroundIgnoreBlocking;
            [FieldAttr(offset: 9, size: 1)] public bool _unknown;
            [FieldAttr(offset: 10, size: 1)] public bool _unknown1;
            [FieldAttr(offset: 11, size: 1)] public bool _unknown2;
            [FieldAttr(offset: 12, size: 1)] public bool _unknown3;
        }

        [FieldAttr(nst: 16, ctr: 16)] public string? _soundName = null;
        [FieldAttr(nst: 24, ctr: 24)] public string? _vehicleLandingSoundName = null;
        [FieldAttr(nst: 32, ctr: 32)] public SpawnLayers _spawnLayers = new();
        [FieldAttr(nst: 34, ctr: 34)] public SurfaceFlags _surfaceFlags = new();
        [FieldAttr(nst: 40, ctr: 40)] public CSurfaceMotion? _surfaceMotion;
        [FieldAttr(nst: 48, ctr: 48)] public float _speedMultiplier = 1.0f;
        [FieldAttr(nst: 52, ctr: 52)] public float _slipperyMultiplier = 1.0f;
        [FieldAttr(nst: 56, ctr: 56)] public float _traction = 1.0f;
        [FieldAttr(nst: 60, ctr: 60)] public float _slipperyFactor;
        [FieldAttr(nst: 64, ctr: 64)] public float _slipperyFactorAcceleration;
        [FieldAttr(ctr: 72)] public CSurfaceMaterialAccumulationData? _surfaceAccumulation;
        [FieldAttr(ctr: 80)] public igHandleMetaField _landingEffect = new();
    }
}
