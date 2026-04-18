namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Force_Collectible_MultiWumpa_SpawnedData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int_0x28;
        [FieldAttr(nst: 44)] public int _Int_0x2c;
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
    }
}
