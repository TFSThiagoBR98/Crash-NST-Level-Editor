namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 16)]
    public class igGuiComposition : igGuiAsset
    {
        [FieldAttr(nst: 32, ctr: 32)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 40, ctr: 40)] public igGuiInstanceMap? _instanceMap;
    }
}
