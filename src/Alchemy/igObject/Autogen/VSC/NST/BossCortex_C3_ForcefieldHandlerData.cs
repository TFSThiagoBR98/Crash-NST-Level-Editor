namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C3_ForcefieldHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
    }
}
