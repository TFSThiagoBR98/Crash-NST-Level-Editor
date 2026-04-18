namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_OrientBarrel_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public string? _Death_State = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
    }
}
