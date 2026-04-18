namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 16)]
    public class CSurfaceMaterialAccumulationData : igObject
    {
        [FieldAttr(ctr: 12)] public float _rotationsUntilCovered;
        [FieldAttr(ctr: 16)] public float _rotationsUntilClean;
        [FieldAttr(ctr: 20)] public float _maxAccumulation;
        [FieldAttr(ctr: 24)] public float _accumulationWeight;
        [FieldAttr(ctr: 28)] public float _wetness;
        [FieldAttr(ctr: 32)] public float _wetnessBias;
        [FieldAttr(ctr: 36)] public float _wetnessAccumulationMultiplier;
        [FieldAttr(ctr: 40)] public float _washOffThreshold;
        [FieldAttr(ctr: 48)] public igVec4fMetaField _dryColorStorage = new();
        [FieldAttr(ctr: 64)] public igVec4fMetaField _wetColorStorage = new();
        [FieldAttr(ctr: 80)] public igVec4fMetaField _dryGlossEmissiveStorage = new();
        [FieldAttr(ctr: 96)] public igVec4fMetaField _wetGlossEmissiveStorage = new();
    }
}
