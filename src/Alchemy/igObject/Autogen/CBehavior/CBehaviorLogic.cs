namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 8, meta: true)]
    public class CBehaviorLogic : CBaseBehaviorLogic
    {
        [FieldAttr(nst: 24, ctr: 16)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 32, ctr: 24)] public igStringStringHashTable? _activators;
        [FieldAttr(nst: 40, ctr: 32)] public igStringStringHashTable? _excludeActivators;
        [FieldAttr(nst: 48, ctr: 40)] public CBaseUpgradeFilter? _skillUpgradeFilter;
        [FieldAttr(nst: 56)] public CBaseVehicleModeFilter? _vehicleModeFilter;
        [FieldAttr(nst: 64, ctr: 48)] public bool _playerOnly;
        [FieldAttr(nst: 65, ctr: 49)] public bool _useProxy;
        [FieldAttr(nst: 66, ctr: 50)] public bool _useProxyInputOnly;
        [FieldAttr(nst: 67, ctr: 51)] public bool _useProxyPassengerOnly;
        [FieldAttr(nst: 68, ctr: 52)] public bool _disable;
        [FieldAttr(nst: 72, ctr: 56, refCount: false)] public igMetaObject? _meta;
    }
}
