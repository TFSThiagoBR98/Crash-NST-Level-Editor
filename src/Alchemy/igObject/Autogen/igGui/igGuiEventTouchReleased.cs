namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGuiEventTouchReleased : igGuiEventTouch
    {
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiPlaceable? _releasedPlaceable;
    }
}
