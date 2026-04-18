namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_GameEntity_VFX_OnAttackReactData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 68)] public float _Float;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
    }
}
