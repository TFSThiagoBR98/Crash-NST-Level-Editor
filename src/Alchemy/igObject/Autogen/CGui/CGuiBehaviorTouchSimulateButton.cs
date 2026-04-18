namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CGuiBehaviorTouchSimulateButton : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 12)] public igGuiInput.ESignal _button;
        [FieldAttr(nst: 20, ctr: 16)] public bool _hideWhenOnSubScreen;
        [FieldAttr(nst: 24, ctr: 20)] public igGuiInput.EController _touchControl;
    }
}
