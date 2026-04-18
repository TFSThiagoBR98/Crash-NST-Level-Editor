namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorPitstopShowcaseBundle : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _marketplaceSku = new();
        [FieldAttr(ctr: 24)] public bool _isBundle;
    }
}
