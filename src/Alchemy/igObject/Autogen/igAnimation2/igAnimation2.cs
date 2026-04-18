namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igAnimation2 : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public int _priority;
        [FieldAttr(nst: 32, ctr: 32)] public igAnimationBinding2List? _bindingList;
        [FieldAttr(nst: 40, ctr: 40)] public igAnimationTransitionList? _transitionList;
    }
}
