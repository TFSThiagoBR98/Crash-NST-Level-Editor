namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CModelComponentData : igComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public string? _fileName = null;
        [FieldAttr(nst: 32, ctr: 24)] public float _fadeFx = 1.0f;
        [FieldAttr(nst: 36, ctr: 28)] public EDistanceCullImportance _distanceCullImportance = EDistanceCullImportance.kMedium;
        [FieldAttr(ctr: 32)] public igHandleMetaField _environmentMapOverride = new();
    }
}
