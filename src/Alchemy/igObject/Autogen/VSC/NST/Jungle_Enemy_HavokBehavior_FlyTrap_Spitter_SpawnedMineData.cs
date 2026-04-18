namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Jungle_Enemy_HavokBehavior_FlyTrap_Spitter_SpawnedMineData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Damage_Data = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public float _ThrowLength;
        [FieldAttr(nst: 68)] public float _ThrowPitch;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 80)] public bool _Bool_0x50;
        [FieldAttr(nst: 88)] public string? _String = null;
        [FieldAttr(nst: 96)] public bool _Bool_0x60;
        [FieldAttr(nst: 97)] public bool _Bool_0x61;
    }
}
