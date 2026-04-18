namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CCloudBundle : igObject
    {
        public enum ECloudEntityType
        {
            kNoEntity = 0,
            kGameEntity = 1,
            kIgEntity = 2,
        }

        [FieldAttr(ctr: 16)] public igVectorMetaField<igVectorMetaField<CCloudInstance>> _cloudInstancesLists = new();
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igObject? _entity;
        [FieldAttr(nst: 48, ctr: 48)] public ECloudEntityType _currentType;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igModelInstance? _modelInstance;
    }
}
