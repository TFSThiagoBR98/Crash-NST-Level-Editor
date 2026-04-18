namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class H100_Hub_Area_Transition_Music_TriggerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public bool _Bool_0x28;
        [FieldAttr(ctr: 41)] public bool _Bool_0x29;
        [FieldAttr(ctr: 42)] public bool _Bool_0x2a;
        [FieldAttr(ctr: 43)] public bool _Bool_0x2b;
        [FieldAttr(ctr: 44)] public bool _Bool_0x2c;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Game_Int_Variable = new();
    }
}
