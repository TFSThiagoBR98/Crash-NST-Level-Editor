namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CNetworkEntityTokenComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _attackerAcquires;
        [FieldAttr(ctr: 20)] public float _exclusiveAcquireTimeout;
        [FieldAttr(ctr: 24)] public float _reacquireTimeout;
        [FieldAttr(ctr: 28)] public bool _allowRemoteAcquireRequest;
        [FieldAttr(ctr: 29)] public bool _useAcquireCounter;
        [FieldAttr(ctr: 30)] public bool _hideOnAcquire;
        [FieldAttr(ctr: 31)] public bool _dropOnDamage;
        [FieldAttr(ctr: 32)] public EDropOnDamageScale _dropOnDamageScale;
        [FieldAttr(ctr: 36)] public float _damageDropAmount;
        [FieldAttr(ctr: 40)] public bool _allowRemoteDropRequest;
        [FieldAttr(ctr: 41)] public bool _hostOnly;
        [FieldAttr(ctr: 42)] public bool _boltToAcquiringEntity;
        [FieldAttr(ctr: 48)] public CBoltPoint? _tokenBolt;
    }
}
