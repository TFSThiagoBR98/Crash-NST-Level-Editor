namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 88, align: 8)]
    public class CTriggerVolumeBoxComponentData : CTriggerVolumeComponentData
    {
        [FieldAttr(nst: 80, ctr: 68)] public igVec3fMetaField _dimensions = new();
        [FieldAttr(nst: 92, ctr: 80)] public float _convexRadius = 0.05f;
    }
}
