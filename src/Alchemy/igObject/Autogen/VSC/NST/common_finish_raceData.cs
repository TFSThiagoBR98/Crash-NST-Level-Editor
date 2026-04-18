namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_finish_raceData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public int _Int_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 72)] public int _Int_0x48;
        [FieldAttr(nst: 76)] public float _Float;
        [FieldAttr(nst: 80)] public EZoneCollectibleType _E_Zone_Collectible_Type;
    }
}
