namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorOctaneProgressionArea : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _categoryTemplateItem;
        [FieldAttr(ctr: 24)] public CGuiOctaneListButtonAnimData? _buttonAnimData;
    }
}
