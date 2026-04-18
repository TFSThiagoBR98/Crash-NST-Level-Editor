namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 96, align: 8)]
    public class CTriggerVolumeCylinderComponentData : CTriggerVolumeComponentData
    {
        [FieldAttr(nst: 80, ctr: 68)] public igVec3fMetaField _bottom = new();
        [FieldAttr(nst: 92, ctr: 80)] public igVec3fMetaField _top = new();
        [FieldAttr(nst: 104, ctr: 92)] public float _radius = 10.0f;
    }
}
