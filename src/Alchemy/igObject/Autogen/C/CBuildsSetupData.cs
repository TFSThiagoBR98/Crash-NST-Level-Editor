namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CBuildsSetupData : igSingleton
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _currentBuild = new();
        [FieldAttr(ctr: 24)] public CBuildDataList? _builds;
    }
}
