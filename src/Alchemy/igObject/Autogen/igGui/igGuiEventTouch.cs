namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igGuiEventTouch : igGuiEvent
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 32, ctr: 32)] public igGuiInput.EController _control;
        [FieldAttr(nst: 36, ctr: 36)] public igGuiInput.ESignal _signal;
    }
}
