namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CDisablePlayerAttacksHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public uint _attackTypes = 7;
        [FieldAttr(nst: 84)] public bool _cancelCurrentAttacks;
    }
}
