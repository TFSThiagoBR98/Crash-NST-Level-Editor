namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class CutsceneActionSpawnVFX : CutsceneVFXAction
    {
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 60, ctr: 60)] public igVec3fMetaField _angles = new();
        [FieldAttr(nst: 72, ctr: 72)] public float _scale;
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _boltPoint = new();
        [FieldAttr(nst: 88, ctr: 88)] public igHandleMetaField _boltPoint2 = new();
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _boltOwner2 = new();
    }
}
