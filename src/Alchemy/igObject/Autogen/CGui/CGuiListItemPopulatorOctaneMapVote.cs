namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiListItemPopulatorOctaneMapVote : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public string? _randomItemName;
        [FieldAttr(ctr: 24)] public EOctaneRaceModes _randomItemMode;
        [FieldAttr(ctr: 32)] public igHandleMetaField _randomItemIcon = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _randomItemBackground = new();
        [FieldAttr(ctr: 48)] public bool _isHidden;
    }
}
