namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CModelAsset : CAsset
    {
        [FieldAttr(ctr: 24)] public CModelAnimationDatabase? _modelAnimations;
        [FieldAttr(ctr: 32)] public igModelData? _root;
        [FieldAttr(ctr: 40)] public u64 _techniqueMask;
    }
}
