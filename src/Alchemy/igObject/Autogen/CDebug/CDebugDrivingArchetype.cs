namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CDebugDrivingArchetype : igObject
    {
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public CDrivingArchetypeData? _data;
    }
}
