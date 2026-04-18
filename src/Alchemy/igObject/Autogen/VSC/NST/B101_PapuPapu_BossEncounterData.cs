namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class B101_PapuPapu_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BossOnThroneBoltpt = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Boss = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _BossThrone = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _BossIntroCutscene = new();
        [FieldAttr(nst: 72)] public float _BossStartDelay;
        [FieldAttr(nst: 80)] public igHandleMetaField _BossFightWaypoint = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Entity_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 136)] public float _Float_0x88;
        [FieldAttr(nst: 140)] public float _Float_0x8c;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public bool _Bool_0x94;
        [FieldAttr(nst: 152)] public int _Int;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public float _Float_0xa0;
        [FieldAttr(nst: 164)] public bool _Bool_0xa4;
        [FieldAttr(nst: 168)] public igKeyboardInputDevice.ESignal _Keyboard_Input_Device_Signal;
        [FieldAttr(nst: 172)] public float _Float_0xac;
        [FieldAttr(nst: 176)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xb8 = new();
    }
}
