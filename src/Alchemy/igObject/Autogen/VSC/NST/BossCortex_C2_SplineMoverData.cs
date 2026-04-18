namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C2_SplineMoverData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _MapSpotSplineMarker = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
    }
}
