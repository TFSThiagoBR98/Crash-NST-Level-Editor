namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CKartCustomizationPart : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _adventureUnlockIcon = new();
        [FieldAttr(ctr: 96)] public igStreamingChunkList? _chunks;
    }
}
