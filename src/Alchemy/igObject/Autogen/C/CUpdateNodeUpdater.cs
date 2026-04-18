namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CUpdateNodeUpdater : igUpdateable
    {
        [FieldAttr(nst: 32)] public igHandleMetaField _updater = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _updateCallback = new();
        [FieldAttr(nst: 56)] public igVscFloatDelegateMetaField _updateDeltaCallback = new();
        [FieldAttr(nst: 72)] public float _interval = -1.0f;
        [FieldAttr(nst: 76)] public float _elapsedTime;
        [FieldAttr(nst: 80)] public float _previousFireTime;
    }
}
