namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiListItemPopulatorOctaneLevelSelect : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _categoryTemplateItem;
        [FieldAttr(ctr: 24)] public CGuiOctaneLevelSelectDataListList? _levelData;
        [FieldAttr(ctr: 32)] public CGuiOctaneLevelSelectDataListList? _battleLevelData;
    }
}
