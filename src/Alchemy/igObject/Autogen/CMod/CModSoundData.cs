namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 8)]
    public class CModSoundData : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _mod = new();
        [FieldAttr(nst: 24)] public int _priority;
        [FieldAttr(nst: 32)] public igHandleMetaField _rightTriggerPressedSound = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _rightTriggerHeldLoopingSound = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _rightTriggerReleasedSound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _rightTriggerNotHeldLoopingSound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _gearShiftOverrideSound = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _driftActivatedOverrideSound = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _driftActiveOverrideLoopingSound = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _driftDeactivatedOverrideSound = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _boostActivatedOverrideSound = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _boostActiveOverrideLoopingSound = new();
        [FieldAttr(nst: 112)] public CAudioGraphHandleList? _enabledGraphs;
        [FieldAttr(nst: 120)] public CAudioGraphModuleOverrideList? _moduleOverrides;
    }
}
