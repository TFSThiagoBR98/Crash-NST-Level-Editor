namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CVfxMeshSpawnLocationData : igVfxSpawnLocationData
    {
        [FieldAttr(ctr: 64)] public string? _meshName;
        [FieldAttr(ctr: 72)] public ESpawnOrderMethod _spawnOrder;
        [FieldAttr(ctr: 76)] public igVec3fMetaField _meshScale = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _spawnMesh = new();
        [FieldAttr(ctr: 96)] public bool _applyNormals;
        [FieldAttr(ctr: 97)] public bool _shouldRefreshMesh;
    }
}
