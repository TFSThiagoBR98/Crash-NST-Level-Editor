namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Jungle_Enemy_Iguana_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _SplineVelocityMover = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _SplineRotationMover = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Spline_Attach_Behavior = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline_Event_0x40 = new();
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public string? _String_0x58 = null;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public float _Float_0x64;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
        [FieldAttr(nst: 120)] public igHandleMetaField _Spline_Event_0x78 = new();
    }
}
