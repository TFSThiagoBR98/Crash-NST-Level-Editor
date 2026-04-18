namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorOctaneCredits : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public CCreditsLineList? _pendingCreditsLines;
        [FieldAttr(ctr: 24)] public int _maxVisibleLines;
        [FieldAttr(ctr: 28)] public bool _active;
    }
}
