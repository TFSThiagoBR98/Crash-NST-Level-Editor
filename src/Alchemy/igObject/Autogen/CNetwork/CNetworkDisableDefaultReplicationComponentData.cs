namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CNetworkDisableDefaultReplicationComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _startEnabled;
        [FieldAttr(ctr: 17)] public bool _allowDisable;
        [FieldAttr(ctr: 20)] public EReplication _positionReplication;
        [FieldAttr(ctr: 24)] public EReplication _rotationReplication;
        [FieldAttr(ctr: 28)] public EReplication _scaleReplication;
        [FieldAttr(ctr: 32)] public CNetworkDisableDefaultReplicationTable? _otherFieldsReplication;
    }
}
