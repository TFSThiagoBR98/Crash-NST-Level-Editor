namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CMixPointComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _traversalMixMinRadius;
        [FieldAttr(ctr: 20)] public float _traversalMixMaxRadius;
        [FieldAttr(ctr: 24)] public float _traversalMixTrack1MaxVolume;
        [FieldAttr(ctr: 28)] public float _traversalMixTrack2MaxVolume;
        [FieldAttr(ctr: 32)] public float _traversalMixTrack3MaxVolume;
        [FieldAttr(ctr: 36)] public float _traversalMixTrack4MaxVolume;
        [FieldAttr(ctr: 40)] public float _traversalMixTrack5MaxVolume;
        [FieldAttr(ctr: 44)] public bool _startActive;
        [FieldAttr(ctr: 48)] public igVec3fMetaField _entityRelativeOffset = new();
    }
}
