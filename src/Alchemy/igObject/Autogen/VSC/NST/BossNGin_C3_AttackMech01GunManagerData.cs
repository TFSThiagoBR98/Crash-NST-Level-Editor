namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNGin_C3_AttackMech01GunManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity = new();
    }
}
