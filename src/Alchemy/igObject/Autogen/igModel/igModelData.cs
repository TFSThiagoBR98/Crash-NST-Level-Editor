namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 208, align: 16)]
    public class igModelData : igNamedObject
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _min = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _max = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVectorMetaField<igAnimatedTransform> _transforms = new();
        [FieldAttr(nst: 88, ctr: 88)] public igVectorMetaField<int> _transformHierarchy = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVectorMetaField<igModelDrawCallData> _drawCalls = new();
        [FieldAttr(nst: 136, ctr: 136)] public igVectorMetaField<int> _drawCallTransformIndices = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVectorMetaField<igAnimatedMorphWeightsTransform> _morphWeightTransforms = new();
        [FieldAttr(nst: 184, ctr: 184)] public igVectorMetaField<int> _blendMatrixIndices = new();
    }
}
