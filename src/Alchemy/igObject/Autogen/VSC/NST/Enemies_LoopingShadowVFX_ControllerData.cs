namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemies_LoopingShadowVFX_ControllerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
    }
}
