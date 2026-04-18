namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CEntityPoolComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public int _poolSize = 5;
        [FieldAttr(nst: 32)] public string? _poolName = null;
        [FieldAttr(nst: 40)] public u64 _poolId;
    }
}
