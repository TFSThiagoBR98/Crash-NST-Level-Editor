namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorOctaneHelpHints : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public string? _unavailableHintString;
        [FieldAttr(ctr: 24)] public CGuiOctaneListButtonAnimData? _buttonAnimData;
    }
}
