namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8, meta: true)]
    public class CVectorSlider : Object
    {
        [FieldAttr(nst: 32)] public igVec3fMetaField _vector = new();
        [FieldAttr(nst: 48)] public Vector3? _vectorArg;
        [FieldAttr(nst: 56)] public igVec3fMetaField _startingVector = new();
        [FieldAttr(nst: 68)] public igVec3fMetaField _endingVector = new();
        [FieldAttr(nst: 80)] public CSlider? _slider;
        [FieldAttr(nst: 88)] public igHandleMetaField _callbackOwner = new();
        [FieldAttr(nst: 96)] public igRawRefMetaField _onUpdate = new();
        [FieldAttr(nst: 104)] public igRawRefMetaField _onCompletion = new();
        [FieldAttr(nst: 112)] public igRawRefMetaField _onStartReached = new();
    }
}
