namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_VehicleCharacterControllerHandler : CBehaviorLogic
    {
        public enum EControllerMotionTypeEnum
        {
            AnimationDriven = 0,
            Dynamic = 1,
        }

        [FieldAttr(nst: 80)] public EControllerMotionTypeEnum MotionTypeEnum;
        [FieldAttr(nst: 84)] public bool ForceDownwardMomentum = true;
        [FieldAttr(nst: 85)] public bool ApplyGravity = true;
        [FieldAttr(nst: 86)] public bool SetInitalVelocity;
    }
}
