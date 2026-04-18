namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneChallengeUnlockable : COctaneUnlockable
    {
        [FieldAttr(ctr: 28)] public int _challengeIndex;
    }
}
