namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Collectible_Template_SpawnedData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _CanSpinAway;
        [FieldAttr(nst: 48)] public igHandleMetaField _SpinAwaySound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _CollectSound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _CollectVFX = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _SpinAwayVFX = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Game_Bool_Variable_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Game_Bool_Variable_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 104)] public bool _Bool;
    }
}
