namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8, meta: true)]
    public class CActorTimeScale : Object
    {
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _actor = new();
        [FieldAttr(nst: 40, ctr: 40)] public float _timeScale = 1.0f;
        [FieldAttr(nst: 44, ctr: 44)] public bool _addedToActor;
        [FieldAttr(nst: 45, ctr: 45)] public bool _activated;
        [FieldAttr(nst: 48, ctr: 48)] public float _priority;
        [FieldAttr(nst: 52, ctr: 52)] public bool _critical;
    }
}
