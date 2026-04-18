namespace Alchemy
{
    [ObjectAttr(nst: 240, align: 4, metaType: typeof(CVscComponentData))]
    public class C3_HubTalkingHeadsCutscenePlayerData : CVscComponentData
    {
        public enum ENewEnum20_id_9ip97ee5
        {
            StoryProgression = 0,
            CrystalsCollected = 1,
            CrystalFail = 2,
            TimeTrialIntro = 3,
        }

        public enum ENewEnum20_id_2pwobb9e
        {
            AkuAku = 0,
            TinyTiger = 1,
            Dingodile = 2,
            NTropy = 3,
            NGin = 4,
            Cortex = 5,
        }

        [FieldAttr(nst: 40)] public ENewEnum20_id_9ip97ee5 _NewEnum20_id_9ip97ee5;
        [FieldAttr(nst: 44)] public int _Int;
        [FieldAttr(nst: 48)] public bool _Bool;
        [FieldAttr(nst: 52)] public ENewEnum20_id_2pwobb9e _NewEnum20_id_2pwobb9e;
        [FieldAttr(nst: 56)] public string? _String = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Localized_Line = new();
        [FieldAttr(nst: 72)] public float _Float;
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Cutscene_Data = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Edc_Info = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Fade_Sequence_Preset_Data_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Fade_Sequence_Preset_Data_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Fade_Sequence_Preset_Data_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Fade_Sequence_Preset_Data_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Fade_Sequence_Preset_Data_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Entity_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Entity_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Entity_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Entity_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Entity_0xb8 = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _Entity_0xc0 = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _Entity_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _Sound_0xd8 = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _Sound_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Checkpoint = new();
    }
}
