namespace Alchemy
{
    [ObjectAttr(nst: 336, align: 4, metaType: typeof(CVscComponentData))]
    public class C2_HubTalkingHeadsCutscenePlayerData : CVscComponentData
    {
        public enum ENewEnum16_id_v38q14g9
        {
            Cortex = 0,
            Coco = 1,
            NBrio = 2,
        }

        public enum ETalkingHeadTypes
        {
            Cortex = 0,
            Coco = 1,
            NBrio = 2,
        }

        public enum ENewEnum17_id_o6pds769
        {
            DebugPlayOnly = 0,
            Progression = 1,
            CrystalsCollected = 2,
            CrystalFail = 3,
            AllGemsCollected = 4,
            GemsIntro = 5,
            ProgressionPostBoss = 6,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _Cutscene_Data = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Designer_Cutscene_Info = new();
        [FieldAttr(nst: 56)] public ENewEnum16_id_v38q14g9 _NewEnum16_id_v38q14g9;
        [FieldAttr(nst: 60)] public ETalkingHeadTypes _TalkingHeadTypes;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Localized_Line_0x68 = new();
        [FieldAttr(nst: 112)] public string? _String_0x70 = null;
        [FieldAttr(nst: 120)] public bool _Bool_0x78;
        [FieldAttr(nst: 128)] public igHandleMetaField _Localized_Line_0x80 = new();
        [FieldAttr(nst: 136)] public string? _String_0x88 = null;
        [FieldAttr(nst: 144)] public ENewEnum17_id_o6pds769 _NewEnum17_id_o6pds769;
        [FieldAttr(nst: 148)] public int _Int;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Query_Filter = new();
        [FieldAttr(nst: 176)] public float _Float_0xb0;
        [FieldAttr(nst: 180)] public float _Float_0xb4;
        [FieldAttr(nst: 184)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 188)] public float _Float_0xbc;
        [FieldAttr(nst: 192)] public float _Float_0xc0;
        [FieldAttr(nst: 196)] public float _Float_0xc4;
        [FieldAttr(nst: 200)] public float _Float_0xc8;
        [FieldAttr(nst: 204)] public float _Float_0xcc;
        [FieldAttr(nst: 208)] public float _Float_0xd0;
        [FieldAttr(nst: 212)] public float _Float_0xd4;
        [FieldAttr(nst: 216)] public igHandleMetaField _Entity_0xd8 = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _Game_Sound_Music_Settings_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Game_Sound_Music_Settings_0xe8 = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _Game_Sound_Music_Settings_0xf0 = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _Game_Sound_Music_Settings_0xf8 = new();
        [FieldAttr(nst: 256)] public bool _Bool_0x100;
        [FieldAttr(nst: 264)] public igHandleMetaField _Localized_Line_0x108 = new();
        [FieldAttr(nst: 272)] public string? _String_0x110 = null;
        [FieldAttr(nst: 280)] public float _Float_0x118;
        [FieldAttr(nst: 288)] public igHandleMetaField _Sound_0x120 = new();
        [FieldAttr(nst: 296)] public igHandleMetaField _Sound_0x128 = new();
        [FieldAttr(nst: 304)] public igHandleMetaField _Sound_0x130 = new();
        [FieldAttr(nst: 312)] public igHandleMetaField _Sound_0x138 = new();
        [FieldAttr(nst: 320)] public igHandleMetaField _Sound_0x140 = new();
        [FieldAttr(nst: 328)] public igHandleMetaField _Checkpoint = new();
    }
}
