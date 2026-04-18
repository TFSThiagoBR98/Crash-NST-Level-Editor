namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Adjust_Position_OnDeathData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 52)] public float _Float;
        [FieldAttr(nst: 56)] public string? _String = null;
    }
}
