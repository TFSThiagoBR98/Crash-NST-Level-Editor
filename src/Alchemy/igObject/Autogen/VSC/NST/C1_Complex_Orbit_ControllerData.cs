namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class C1_Complex_Orbit_ControllerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 64)] public bool _Bool;
    }
}
