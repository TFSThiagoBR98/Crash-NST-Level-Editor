namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CNavMeshBuildData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _inputMeshFile = null;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _buildSettings = new();
    }
}
