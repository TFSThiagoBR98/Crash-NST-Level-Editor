namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CCEOrientation : CCombatNodeEvent
    {
        public enum EOrientationActionType
        {
            eOAT_FaceTarget = 0,
            eOAT_FaceAwayFromTarget = 1,
            eOAT_FaceTargetAngles = 2,
            eOAT_FaceAwayFromCurrentDirection = 3,
            eOAT_FaceInputDirection = 4,
            eOAT_FaceAwayFromCamera = 5,
            eOAT_FaceCamera = 6,
        }

        [FieldAttr(nst: 80)] public ECombatTargetSelect _target;
        [FieldAttr(nst: 84)] public EOrientationActionType _actionType;
    }
}
