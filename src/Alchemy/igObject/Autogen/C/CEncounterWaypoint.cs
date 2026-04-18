namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CEncounterWaypoint : CWaypoint
    {
        [FieldAttr(ctr: 40)] public float _occupationRadiusSquared;
        [FieldAttr(ctr: 48)] public igHandleMetaField _blockingEntity = new();
    }
}
