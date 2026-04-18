namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CBehaviorGraphReflectionData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _runtimeDataFilledIn;
        [FieldAttr(nst: 24, ctr: 16)] public CCharacterClipMap? _clips;
        [FieldAttr(nst: 32, ctr: 24)] public CBehaviorStateMachineList? _stateMachines;
        [FieldAttr(nst: 40, ctr: 32)] public igUnsignedIntIntHashTable? _eventMap;
        [FieldAttr(nst: 48, ctr: 40)] public igUnsignedIntIntHashTable? _variableMap;
        [FieldAttr(nst: 56, ctr: 48)] public CBehaviorActivatorNodeMap? _activatorNodeMap;
        [FieldAttr(nst: 64, ctr: 56)] public CBehaviorLayerGenerator? _layerGenerator;
        [FieldAttr(nst: 72, ctr: 64)] public CBehaviorDockingGenerator? _dockingGenerator;
        [FieldAttr(nst: 80, ctr: 72)] public float _runClipExtractedMotionSpeed;
    }
}
