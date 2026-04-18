namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionRewardDecal : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _decal = new();
        [FieldAttr(ctr: 24)] public string? _kartName;
    }
}
