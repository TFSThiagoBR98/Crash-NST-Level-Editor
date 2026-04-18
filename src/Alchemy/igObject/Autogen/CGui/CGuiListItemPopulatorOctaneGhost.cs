namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiListItemPopulatorOctaneGhost : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _categoryTemplateItem;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _continueButtonTemplateItem;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _noGhostDataTemplateItem;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _mirrorModeTemplateItem;
        [FieldAttr(ctr: 48)] public string? _playerGhostTitle;
        [FieldAttr(ctr: 56)] public string? _challengeGhostTitle;
        [FieldAttr(ctr: 64)] public string? _noGhostDataText;
    }
}
