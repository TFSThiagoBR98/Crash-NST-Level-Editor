namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CAttachmentSplineAttachment : igObject
    {
        [FieldAttr(ctr: 16)] public igEntity? _entityToSpawn;
        [FieldAttr(ctr: 24)] public igHandleMetaField _spawnSound = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _vfx = new();
        [FieldAttr(ctr: 40)] public CBoltPoint? _vfxBoltPoint;
        [FieldAttr(ctr: 48)] public float _distanceAheadOfPoint;
        [FieldAttr(ctr: 52)] public float _verticalOffset;
        [FieldAttr(ctr: 56)] public float _horizontalOffset;
        [FieldAttr(ctr: 60)] public float _rotationAroundSpline;
        [FieldAttr(ctr: 64)] public bool _initialized;
        [FieldAttr(ctr: 65)] public bool _spawned;
        [FieldAttr(ctr: 68)] public float _distanceAlongSpline;
        [FieldAttr(ctr: 72)] public igHandleMetaField _spawnedObject = new();
        [FieldAttr(ctr: 80)] public igVfxSpawnedEffectHandleList? _spawnedVfxList;
    }
}
