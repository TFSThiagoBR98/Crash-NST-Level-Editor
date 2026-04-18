namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CCrystalChallengeControllerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CDifficultySpecificFloat? _challengeTime;
        [FieldAttr(ctr: 24)] public float _lowTimeLeftThreshold;
    }
}
