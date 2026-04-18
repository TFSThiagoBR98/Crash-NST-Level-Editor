namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CGuiBehaviorCustomizationGridList : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public CGuiCustomizationGridData? _initialItemData;
        [FieldAttr(ctr: 24)] public CGuiCustomizationGridData? _storedItemData;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiEvent? _colorEvent;
        [FieldAttr(ctr: 40)] public bool _triedUnlockingCharactersAchievement;
        [FieldAttr(ctr: 44)] public ESignal _readySignal;
    }
}
