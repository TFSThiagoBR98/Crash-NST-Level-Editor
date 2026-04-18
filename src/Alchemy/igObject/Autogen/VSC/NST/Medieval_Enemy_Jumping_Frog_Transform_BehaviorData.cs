namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Medieval_Enemy_Jumping_Frog_Transform_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public bool _Bool;
        [FieldAttr(nst: 60)] public float _Float;
    }
}
