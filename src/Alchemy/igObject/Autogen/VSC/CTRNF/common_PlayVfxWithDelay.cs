namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PlayVfxWithDelay : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public float _Float_0x28;
        [FieldAttr(ctr: 44)] public float _Float_0x2c;
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 52)] public bool _Bool_0x34;
        [FieldAttr(ctr: 56)] public float _Float_0x38;
        [FieldAttr(ctr: 60)] public bool _Bool_0x3c;
    }
}
