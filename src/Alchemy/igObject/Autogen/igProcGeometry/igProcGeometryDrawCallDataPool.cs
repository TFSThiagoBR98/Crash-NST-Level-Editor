namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class igProcGeometryDrawCallDataPool : igPool
    {
        [FieldAttr(ctr: 80)] public u64 _resetCallback;
    }
}
