namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CRigidModelInstance : CModelInstance
    {
        [FieldAttr(ctr: 72)] public CModelAsset? _modelAsset;
        [FieldAttr(ctr: 80)] public CRigidAnimCtrl? mRigidAnimCtrl;
        [FieldAttr(ctr: 88)] public CScopedScheduledFunction? _cycleComplete;
        [FieldAttr(ctr: 96)] public string? _modelClass;
        [FieldAttr(ctr: 104)] public string? _modelClassForFading;
    }
}
