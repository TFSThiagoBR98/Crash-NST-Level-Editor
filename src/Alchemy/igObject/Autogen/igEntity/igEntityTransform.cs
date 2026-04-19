namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class igEntityTransform : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igQuaternionfMetaField _parentSpaceOrientation = new();
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _parentSpaceTransform = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec3fMetaField _parentSpaceRotation = new();
        [FieldAttr(nst: 108, ctr: 108)] public float _runtimeParentSpaceScale = 1.0f;
        [FieldAttr(nst: 112, ctr: 112)] public igVec3fMetaField _nonUniformPersistentParentSpaceScale = new(1, 1, 1);
        [FieldAttr(nst: 124, ctr: 124)] public bool _isDirty = true;
    }
}
