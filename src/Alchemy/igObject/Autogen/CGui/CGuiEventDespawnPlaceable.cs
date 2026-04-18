namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiEventDespawnPlaceable : igGuiEvent
    {
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? toDespawn;
    }
}
