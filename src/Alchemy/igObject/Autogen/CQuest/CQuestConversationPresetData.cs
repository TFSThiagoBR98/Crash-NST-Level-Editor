namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CQuestConversationPresetData : igObject
    {
        [FieldAttr(nst: 16)] public float _cameraBlendInDuration = 0.5f;
        [FieldAttr(nst: 20)] public float _cameraBlendOutDuration = 0.5f;
        [FieldAttr(nst: 24)] public float _cadence = 0.5f;
    }
}
