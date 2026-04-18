namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class igGuiActionSetFocus : igGuiAction
    {
        [FieldAttr(nst: 48, ctr: 40, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 56, ctr: 48)] public igGuiInput.EController _control;
    }
}
