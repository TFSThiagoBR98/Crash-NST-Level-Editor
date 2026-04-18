namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CBehaviorLayerGenerator : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public CBehaviorLayerList? _layers;
        [FieldAttr(nst: 32, ctr: 32)] public igRawRefMetaField _havokLayerGenerator = new();
    }
}
