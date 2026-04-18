namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 16)]
    public class igAnimatedMorphWeightsTransform : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVec4fMetaField _weights = new();
        [FieldAttr(nst: 32, ctr: 32)] public igAnimatedMorphWeights? _source;
    }
}
