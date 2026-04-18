namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class igTransformSequence2 : igTransformSource2Keyframed
    {
        [FieldAttr(nst: 24, ctr: 24)] public igIntList? _timeList;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fList? _translationList;
        [FieldAttr(nst: 40, ctr: 40)] public igQuaternionfList? _quaternionList;
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fList? _scaleList;
        [FieldAttr(nst: 56, ctr: 56)] public igVec3fList? _shearList;
        [FieldAttr(nst: 64, ctr: 64)] public igVec3fMetaField _centerOfRotation = new();
        [FieldAttr(nst: 76, ctr: 76)] public int _timeOffset;
        [FieldAttr(nst: 80, ctr: 80)] public int _duration = -1;
        [FieldAttr(nst: 84, ctr: 84)] public EIG_UTILS_PLAY_MODE _playMode;
        [FieldAttr(nst: 88, ctr: 88)] public u8[] _interpolation = new u8[5];
        [FieldAttr(nst: 93, ctr: 93)] public u8 _supportedTransforms;
        [FieldAttr(nst: 96, ctr: 96)] public int _lastTime;
    }
}
