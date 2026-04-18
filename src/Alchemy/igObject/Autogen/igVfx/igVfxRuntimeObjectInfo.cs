namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVfxRuntimeObjectInfo : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMetaObject? _runtimeType;
        [FieldAttr(nst: 24, ctr: 24)] public igVfxRuntimeObjectPool? _runtimePool;
        [FieldAttr(nst: 32, ctr: 32)] public uint _runtimePoolSize = 32;
        [FieldAttr(nst: 36, ctr: 36)] public igHandleMetaField _countStat = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _budgetStat = new();
        [FieldAttr(nst: 44, ctr: 44)] public bool _reporting = true;
    }
}
