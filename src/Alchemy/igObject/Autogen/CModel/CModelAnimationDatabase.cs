namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CModelAnimationDatabase : igInfo
    {
        [FieldAttr(nst: 40, ctr: 40)] public CModelAnimationHashTable? _animations;
        [FieldAttr(nst: 48, ctr: 48)] public float _animationLength;
        [FieldAttr(nst: 52, ctr: 52)] public bool _isLooping;
    }
}
