namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CStackCameraControllerBase : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public EControllerPriorityCategory _priorityCategory;
        [FieldAttr(nst: 28, ctr: 28)] public int _priority;
        [FieldAttr(nst: 32, ctr: 32)] public CStackCameraBehaviorStates? _behaviorStates;
        [FieldAttr(nst: 40, ctr: 40)] public CStackBlender? _blender;
        [FieldAttr(nst: 48, ctr: 48)] public bool _debugControllerEnabled = true;
        [FieldAttr(nst: 49, ctr: 49)] public bool _debuggingEnabled;
    }
}
