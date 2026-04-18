namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 72, align: 8)]
    public class CChangeCollisionPriorityHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public ECharacterCollisionPriority _collisionPriority = ECharacterCollisionPriority.eCCP_High;
    }
}
