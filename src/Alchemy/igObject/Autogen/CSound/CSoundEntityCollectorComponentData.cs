namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CSoundEntityCollectorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CTriggerVolumeComponentData? _collectionVolume;
        [FieldAttr(nst: 32)] public CEntity? _dummyEntity;
        [FieldAttr(nst: 40)] public float _positionDamping = 0.15f;
    }
}
