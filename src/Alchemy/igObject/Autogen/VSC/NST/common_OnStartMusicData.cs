namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_OnStartMusicData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _OnStartMusic = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public bool _Bool;
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Sound_Music_Settings = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
    }
}
