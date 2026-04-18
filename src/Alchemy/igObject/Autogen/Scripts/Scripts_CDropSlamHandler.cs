namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_CDropSlamHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public int _damageAmount = 999;
        [FieldAttr(nst: 84)] public int _damageRadius = 300;
        [FieldAttr(nst: 88)] public float _sidewaysMoveSpeed = 250.0f;
        [FieldAttr(nst: 92)] public float _downwardMoveSpeed = -900.0f;
    }
}
