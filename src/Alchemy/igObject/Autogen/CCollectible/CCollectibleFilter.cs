namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CCollectibleFilter : igObject
    {
        [FieldAttr(ctr: 16)] public CCollectibleTypeList? _validCollectibleTypesList;
        [FieldAttr(ctr: 24)] public CCollectibleTypeList? _excludeCollectibleTypesList;
    }
}
