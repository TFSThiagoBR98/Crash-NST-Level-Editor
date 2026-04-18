namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CFxMaterialRedirectTable : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _default = new();
        [FieldAttr(nst: 24, ctr: 24)] public igFxMaterialHandleList? _keys;
        [FieldAttr(nst: 32, ctr: 32)] public igFxMaterialHandleList? _values;
        [FieldAttr(nst: 40, ctr: 40)] public int _priority;
    }
}
