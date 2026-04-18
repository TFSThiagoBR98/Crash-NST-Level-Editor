namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 8)]
    public class CCombatNodeEvent : igObject
    {
        public enum ECriticalType
        {
            kCriticalNone = 0,
            kCriticalStart = 1,
            kCriticalEnd = 2,
            kCriticalOnInterrupt = 3,
        }

        [FieldAttr(nst: 16, ctr: 12)] public bool _triggerOnLoop = true;
        [FieldAttr(nst: 17, ctr: 13)] public bool _triggerWhenStateInactive;
        [FieldAttr(nst: 18, ctr: 14)] public bool _triggerOnProxies;
        [FieldAttr(nst: 19, ctr: 15)] public bool _timeRelativeFromEnd;
        [FieldAttr(nst: 24, ctr: 16)] public string? _name = null;
        [FieldAttr(nst: 32, ctr: 24)] public float _time;
        [FieldAttr(nst: 36, ctr: 28)] public ECriticalType _critical;
        [FieldAttr(nst: 40, ctr: 32)] public CBaseUpgradeFilter? _skillUpgradeFilter;
        [FieldAttr(nst: 48, ctr: 40)] public CVariantIdentifierFilter? _variantIdentifierFilter;
        [FieldAttr(nst: 56)] public CBaseVehicleModeFilter? _vehicleModeFilter;
        [FieldAttr(nst: 64, ctr: 48)] public CCombatNodeEvent? _nextEvent;
        [FieldAttr(nst: 72, ctr: 56)] public CEntityMessage.ENetworkSendRestriction _networkRestriction;
        [FieldAttr(nst: 76, ctr: 60)] public uint _deviceClass = 31;
    }
}
