namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiEventRacingMinimapGhostSetup : CGuiEventRacingMinimapIconSetup
    {
        [FieldAttr(ctr: 56)] public igHandleMetaField _ghost = new();
    }
}
