namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 8)]
    public class CVfxSpawnLayers : igObject
    {
        [ObjectAttr(size: 2)]
        public class SpawnLayers : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _spawnLayer1 = true;
            [FieldAttr(offset: 1, size: 1)] public bool _spawnLayer2 = false;
            [FieldAttr(offset: 2, size: 1)] public bool _spawnLayer3 = false;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnLayer4 = false;
            [FieldAttr(offset: 4, size: 1)] public bool _spawnLayer5 = false;
            [FieldAttr(offset: 5, size: 1)] public bool _spawnLayer6 = false;
            [FieldAttr(offset: 6, size: 1)] public bool _spawnLayer7 = false;
            [FieldAttr(offset: 7, size: 1)] public bool _spawnLayer8 = false;
            [FieldAttr(offset: 8, size: 1)] public bool _spawnLayer9 = false;
            [FieldAttr(offset: 9, size: 1)] public bool _spawnLayer10 = false;
            [FieldAttr(offset: 10, size: 1)] public bool _spawnLayer11 = false;
            [FieldAttr(offset: 11, size: 1)] public bool _spawnLayer12 = false;
            [FieldAttr(offset: 12, size: 1)] public bool _spawnLayer13 = false;
            [FieldAttr(offset: 13, size: 1)] public bool _spawnLayer14 = false;
            [FieldAttr(offset: 14, size: 1)] public bool _spawnLayer15 = false;
            [FieldAttr(offset: 15, size: 1)] public bool _spawnLayer16 = false;
        }

        [FieldAttr(nst: 16, ctr: 12)] public SpawnLayers _spawnLayers = new();
    }
}
