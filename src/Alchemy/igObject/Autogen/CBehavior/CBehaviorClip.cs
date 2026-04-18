namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CBehaviorClip : CCharacterClip
    {
        [FieldAttr(nst: 32, ctr: 32)] public CBehaviorLayer? _layer;
        [FieldAttr(nst: 40, ctr: 40)] public bool _isPartial;
        [FieldAttr(nst: 48, ctr: 48)] public CBehaviorStateList? _parentStates;
    }
}
