namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Progression_Rewards_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EOctaneAdventureType _E_Octane_Adventure_Type;
        [FieldAttr(ctr: 44)] public bool _Bool_0x2c;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Localized_String_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Localized_String_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Localized_String_0x48 = new();
        [FieldAttr(ctr: 80)] public bool _Bool_0x50;
        [FieldAttr(ctr: 88)] public igObject? _InternalStore_prioritySetHandler = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Priority_Dsp_Override_Set = new();
        [FieldAttr(ctr: 104)] public bool _Bool_0x68;
    }
}
