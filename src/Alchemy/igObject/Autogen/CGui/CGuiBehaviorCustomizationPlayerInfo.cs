namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorCustomizationPlayerInfo : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _playerNumberText;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _playerGamertagText;
        [FieldAttr(ctr: 32)] public string? _playerNumberString;
    }
}
