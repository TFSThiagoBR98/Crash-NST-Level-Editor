namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CEntityBolt : igEntityBolt
    {
        [FieldAttr(nst: 24, ctr: 24)] public CBoltPoint? _boltSelect;
        [FieldAttr(nst: 32, ctr: 32)] public CObjectBolt? _objectBolt;
        [FieldAttr(nst: 40, ctr: 40)] public bool _dirty = true;
    }
}
