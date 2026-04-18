namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CVertexWibbleMaterialFeature : igObject
    {
        [FieldAttr(nst: 16, refCount: false)] public igFxMaterial? _owner;
        [FieldAttr(nst: 24)] public igVec3fMetaField _amplitude = new();
        [FieldAttr(nst: 36)] public igVec3fMetaField _frequency = new();
        [FieldAttr(nst: 48)] public igVec3fMetaField _phase = new();
        [FieldAttr(nst: 60)] public bool _flipVertexPhase;
        [FieldAttr(nst: 64)] public float _randomFrequencyVariance;
    }
}
