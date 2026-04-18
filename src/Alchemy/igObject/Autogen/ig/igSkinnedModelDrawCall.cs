namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 16)]
    public class igSkinnedModelDrawCall : igModelDrawCall
    {
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _blendVectors = new();
        [FieldAttr(nst: 136, ctr: 136)] public igVec4fMetaField _blendVectorsPrevious = new();
    }
}
