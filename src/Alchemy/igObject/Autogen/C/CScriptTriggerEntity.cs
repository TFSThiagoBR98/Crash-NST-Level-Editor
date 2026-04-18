namespace Alchemy
{
    [ObjectAttr(nst: 264, ctr: 256, align: 8)]
    public class CScriptTriggerEntity : CGameEntity
    {
        [FieldAttr(nst: 224, ctr: 220)] public bool _activated;
        [FieldAttr(nst: 228, ctr: 224)] public float _maxRadiusInExtents;
        [FieldAttr(nst: 232, ctr: 228)] public float _maxRadiusSquared;
        [FieldAttr(nst: 236, ctr: 232)] public bool _onlyPlayersCanTrigger = true;
        [FieldAttr(nst: 237, ctr: 233)] public bool _autoAabb;
        [FieldAttr(nst: 240, ctr: 236)] public uint _originalFastFlags;
        [FieldAttr(nst: 248, ctr: 240)] public CTriggerVolumeGenericShapeComponentData? _triggerVolumeComponentData;
        [FieldAttr(nst: 256, ctr: 248)] public bool _enableCollisionRequested = true;
    }
}
