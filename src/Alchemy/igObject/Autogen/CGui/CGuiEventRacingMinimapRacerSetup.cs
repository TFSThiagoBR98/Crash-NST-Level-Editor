namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiEventRacingMinimapRacerSetup : CGuiEventRacingMinimapIconSetup
    {
        [FieldAttr(ctr: 56)] public igHandleMetaField _racer = new();
    }
}
