namespace Alchemy
{
    [ObjectAttr(ctr: 464, align: 8)]
    public class CGuiBehaviorOctaneGlobalOptionSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448, refCount: false)] public igStringRefList? _optionsList;
        [FieldAttr(ctr: 456)] public EGlobalOption _variable;
        [FieldAttr(ctr: 460)] public bool _playerSpecific;
    }
}
