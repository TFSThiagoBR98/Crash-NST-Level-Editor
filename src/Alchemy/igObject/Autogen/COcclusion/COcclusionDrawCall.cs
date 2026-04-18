namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COcclusionDrawCall : igDrawCall
    {
        [FieldAttr(ctr: 16)] public igRawRefMetaField _data = new();
        [FieldAttr(ctr: 24)] public igSizeTypeMetaField _query = new();
    }
}
