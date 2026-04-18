namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class igVfxVolumetricSpawnLocationData : igVfxSpawnLocationData
    {
        [ObjectAttr(size: 1)]
        public class FlagStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _applyNormal;
        }

        [FieldAttr(nst: 72, ctr: 64)] public igRangedFloatMetaField _volumeScalar = new();
        [FieldAttr(nst: 80, ctr: 72)] public FlagStorage _flagStorage = new();
    }
}
