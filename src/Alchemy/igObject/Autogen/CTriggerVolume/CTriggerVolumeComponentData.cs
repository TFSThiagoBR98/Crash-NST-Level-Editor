namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CTriggerVolumeComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 36, ctr: 28)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 48, ctr: 40)] public CQueryFilter? _queryFilter;
        [FieldAttr(nst: 56, ctr: 48)] public uint _collisionFlags = 31;
        [FieldAttr(nst: 60, ctr: 52)] public ETriggerVolumeQualityType _qualityType = ETriggerVolumeQualityType.eTVCF_Keyframed_DynamicsOnly;
        [FieldAttr(nst: 64, ctr: 56)] public ETriggerVolumeDetectionType _detectionType = ETriggerVolumeDetectionType.eTVDT_Normal;
        [FieldAttr(nst: 68, ctr: 60)] public bool _sendEventsToEntity = true;
        [FieldAttr(nst: 69, ctr: 61)] public bool _triggerCausesTouch = true;
        [FieldAttr(nst: 70, ctr: 62)] public bool _triggerCausesAct;
        [FieldAttr(nst: 71, ctr: 63)] public bool _processMagicMoment;
        [FieldAttr(nst: 72, ctr: 64)] public bool _triggerForOpponentsOnly;
        [FieldAttr(nst: 73, ctr: 65)] public bool _singleFire;
        [FieldAttr(nst: 74, ctr: 66)] public bool _networkEnabled;
    }
}
