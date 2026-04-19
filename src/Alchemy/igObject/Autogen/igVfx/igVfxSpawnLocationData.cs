namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class igVfxSpawnLocationData : igObject
    {
        [ObjectAttr(size: 4)]
        public class SpawnLocationFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _hasPosition = true;
            [FieldAttr(offset: 1, size: 1)] public bool _hasRotation = false;
            [FieldAttr(offset: 2, size: 1)] public bool _dataFieldsCached;
        }

        [FieldAttr(nst: 16, ctr: 12)] public igRangedVectorMetaField _offsetPos = new();
        [FieldAttr(nst: 40, ctr: 36)] public igRangedVectorMetaField _offsetRot = new();
        [FieldAttr(nst: 64, ctr: 60)] public SpawnLocationFlags _spawnLocationFlags = new();
    }
}
