namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CTargetLockReticleComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public int _maxNumberOfTargets = 1;
        [FieldAttr(nst: 32)] public igHandleMetaField _reticleEffect = new();
        [FieldAttr(nst: 40)] public CBoltPoint? _reticleBolt;
        [FieldAttr(nst: 48)] public ECombatTargetList _targetList;
    }
}
