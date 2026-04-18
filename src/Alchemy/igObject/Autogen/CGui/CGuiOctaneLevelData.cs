namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiOctaneLevelData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _levelName;
        [FieldAttr(ctr: 24)] public igHandleMetaField _levelAmbienceSFX = new();
    }
}
