namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crash1_Hub_CrashHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _SplineMover = new();
        [FieldAttr(nst: 48)] public float _SplineMoveToRatioSpeed;
        [FieldAttr(nst: 56)] public string? _AnimationIdle = null;
        [FieldAttr(nst: 64)] public string? _AnimationRun = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 88)] public string? _String = null;
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Vfx_Effect_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Vfx_Effect_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Vfx_Effect_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Vfx_Effect_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Vfx_Effect_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Vfx_Effect_0x98 = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Vfx_Effect_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Game_Bool_Variable_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Game_Bool_Variable_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Game_Bool_Variable_0xb8 = new();
    }
}
