namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class CCameraTriggerVolumeComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igVec3fMetaField _dimensions = new();
    }
}
