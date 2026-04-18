namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CCtrChallengeTokenComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public ECtrChallengeTokenType _tokenType;
    }
}
