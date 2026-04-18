namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crate_LevelCountData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _addToCrateTotal;
        [FieldAttr(nst: 48)] public igHandleMetaField _Total = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 72)] public igHandleMetaField _Game_Int_Variable_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Game_Int_Variable_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _BonusRoundActive = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _PlayerDied = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Game_Int_Variable_0x68 = new();
    }
}
