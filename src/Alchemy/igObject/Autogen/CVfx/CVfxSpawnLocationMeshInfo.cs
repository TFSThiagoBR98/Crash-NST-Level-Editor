namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CVfxSpawnLocationMeshInfo : igInfo
    {
        [FieldAttr(ctr: 40)] public igVectorMetaField<igVec3fMetaField> _spawnPositions = new();
        [FieldAttr(ctr: 64)] public igVectorMetaField<igQuaternionfMetaField> _spawnOrientations = new();
        [FieldAttr(ctr: 88)] public igVectorMetaField<u16> _randomIndices = new();
    }
}
