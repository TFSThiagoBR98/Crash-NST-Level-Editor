namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNTropy_Projectile_CrashHomingData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public float _Float;
    }
}
