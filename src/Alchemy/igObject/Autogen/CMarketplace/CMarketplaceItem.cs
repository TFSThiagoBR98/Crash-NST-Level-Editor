namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 80, align: 8)]
    public class CMarketplaceItem : igObject
    {
        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 14)] public uint _id;
            [FieldAttr(offset: 14, size: 1)] public bool _isGameConsumable;
            [FieldAttr(offset: 15, size: 1)] public bool _isMarketplaceConsumable = false;
            [FieldAttr(offset: 16, size: 8)] public int _rarity;
        }

        [FieldAttr(nst: 16, ctr: 12)] public Bitfield _bitfield = new();
        [FieldAttr(ctr: 16)] public string? _marketingName;
        [FieldAttr(nst: 24, ctr: 24)] public string? _storeDisplayName = null;
        [FieldAttr(nst: 32, ctr: 32)] public string? _storeDisplayDescription = null;
        [FieldAttr(ctr: 40)] public EMITier _tier;
        [FieldAttr(ctr: 48)] public COctaneUnlockable? _unlockableData;
        [FieldAttr(ctr: 56)] public uint _availablePlatforms;
        [FieldAttr(ctr: 60)] public EOctaneGameVersion _gameVersion;
        [FieldAttr(ctr: 64)] public igHandleMetaField _streamingIcon = new();
        [FieldAttr(ctr: 72)] public bool _isPlayerExclusive;
    }
}
