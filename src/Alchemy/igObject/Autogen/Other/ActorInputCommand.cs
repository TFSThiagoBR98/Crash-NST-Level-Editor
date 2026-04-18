namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class ActorInputCommand : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public i64 _buttonStates;
        [FieldAttr(nst: 24, ctr: 24)] public i64 _buttonClicks;
        [FieldAttr(nst: 32, ctr: 32)] public i64 _buttonReleases;
        [FieldAttr(nst: 40, ctr: 40)] public igIntList? _buttonFrames;
        [FieldAttr(nst: 48, ctr: 48)] public igIntListList? _stickFrames;
        [FieldAttr(nst: 56, ctr: 56)] public float _speed;
        [FieldAttr(nst: 60, ctr: 60)] public igVec3fMetaField _direction = new();
        [FieldAttr(nst: 72, ctr: 72)] public igVec2fMetaField _initialTouchLocation = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec2fMetaField _lastTouchLocation = new();
        [FieldAttr(nst: 88, ctr: 88)] public igVec2fMetaField _lastMoveInput = new();
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _touchedEntity = new();
        [FieldAttr(nst: 104, ctr: 104)] public igVec2fMetaField[] _analogStickDeflection = new igVec2fMetaField[2];
    }
}
