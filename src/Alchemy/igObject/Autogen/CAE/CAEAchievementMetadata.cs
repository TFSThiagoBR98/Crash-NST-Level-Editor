namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CAEAchievementMetadata : igObject
    {
        [FieldAttr(ctr: 16)] public string? _checksum;
        [FieldAttr(ctr: 24)] public int _version;
    }
}
