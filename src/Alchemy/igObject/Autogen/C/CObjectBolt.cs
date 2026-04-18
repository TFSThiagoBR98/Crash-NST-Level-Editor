namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CObjectBolt : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EBoltonModels _boltOn = EBoltonModels.EBOLTON_NONE;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _owner = new();
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _modelBoltPoint = new();
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _boltOnBoltPoint = new();
        [FieldAttr(nst: 48, ctr: 40)] public EObjectBoltType _type;
        [FieldAttr(nst: 52, ctr: 44)] public bool _warned;
        [FieldAttr(nst: 53, ctr: 45)] public bool _isFakeBolt;
        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _boltOffset = new();
        [FieldAttr(nst: 68, ctr: 60)] public bool _worldAlign;
    }
}
