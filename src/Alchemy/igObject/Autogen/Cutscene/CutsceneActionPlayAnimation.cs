namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class CutsceneActionPlayAnimation : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _animationName = null;
        [FieldAttr(nst: 32, ctr: 32)] public CCutsceneActor? _actor;
        [FieldAttr(nst: 40, ctr: 40)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 52, ctr: 52)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec3fMetaField _scale = new();
        [FieldAttr(nst: 80, ctr: 80)] public CCutsceneActor? _boltTo;
        [FieldAttr(nst: 88, ctr: 88)] public string? _boltBoneName = null;
    }
}
