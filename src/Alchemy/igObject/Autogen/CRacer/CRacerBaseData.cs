namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CRacerBaseData : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public string? _name;
        [FieldAttr(ctr: 88)] public string? _displayName;
        [FieldAttr(ctr: 96)] public bool _availableAtStart;
        [FieldAttr(ctr: 97)] public bool _showInCustomizationMenu;
        [FieldAttr(ctr: 100)] public EDriverDifficultyClass _difficultyClass;
        [FieldAttr(ctr: 104)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _adventureUnlockIcon = new();
        [FieldAttr(ctr: 120)] public string? _characterSelectName;
        [FieldAttr(ctr: 128)] public string? _selectedVoName;
    }
}
