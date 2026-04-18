namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CGuiBehaviorControlScheme : CGuiBehavior
    {
        [FieldAttr(ctr: 144)] public igGuiPlaceableList? _labelsToReplace;
        [FieldAttr(ctr: 152)] public igStringRefList? _standardStrings;
        [FieldAttr(ctr: 160)] public igStringRefList? _alternateStrings;
        [FieldAttr(ctr: 168)] public bool _isSwitchSinglejoycon;
        [FieldAttr(ctr: 169)] public bool _isActive;
    }
}
