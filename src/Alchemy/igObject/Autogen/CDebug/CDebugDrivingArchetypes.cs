namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CDebugDrivingArchetypes : igSingleton
    {
        [FieldAttr(ctr: 16)] public CDebugDrivingArchetypeList? _debugArchetypes;
    }
}
