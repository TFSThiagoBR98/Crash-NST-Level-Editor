namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_StartPigSpitData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
    }
}
