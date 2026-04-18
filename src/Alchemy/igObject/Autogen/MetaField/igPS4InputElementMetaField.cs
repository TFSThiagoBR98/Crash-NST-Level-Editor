namespace Alchemy
{
    [ObjectAttr(12)]
    public class igPS4InputElementMetaField : igMetaField 
    {
        [FieldAttr(0)] public EIG_VERTEX_USAGE _usage;
        [FieldAttr(4)] public u32 _usageIndex;
        [FieldAttr(8)] public u32 _resourceIndex;
    }
}