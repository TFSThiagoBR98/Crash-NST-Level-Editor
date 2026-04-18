namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Characters_Egypt_Enemy_Vase_WhiteMonkey_CharacterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 64)] public string? _String = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
    }
}
