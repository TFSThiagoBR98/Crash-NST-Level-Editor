namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Castle_OrbitComplex_SplineControllerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _StartingRatio;
        [FieldAttr(nst: 44)] public bool _Bool_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
    }
}
