namespace Alchemy
{
    [ObjectAttr(ctr: 232, align: 8)]
    public class CGuiBehaviorGlobalToggleOption : CGuiBehaviorBaseToggleOption
    {
        [FieldAttr(ctr: 220)] public EGlobalOption _variable;
        [FieldAttr(ctr: 224)] public bool _playerSpecific;
    }
}
