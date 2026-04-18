namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_ChangeHavokVariableHandler : CBehaviorLogic
    {
        public enum ESetHavokBehaviorVariableEnum
        {
            Int = 0,
            Float = 1,
            Bool = 2,
        }

        [FieldAttr(nst: 80)] public ESetHavokBehaviorVariableEnum HavokVariableEnum;
        [FieldAttr(nst: 88)] public string? HavokBehaviorVariableID = null;
        [FieldAttr(nst: 96)] public int ActivateValue = -1;
        [FieldAttr(nst: 100)] public int DeactivateValue = -1;
        [FieldAttr(nst: 104)] public float ActivateFloatValue = -1.0f;
        [FieldAttr(nst: 108)] public float DeactivateFloatValue = -1.0f;
        [FieldAttr(nst: 112)] public bool ActivateBoolValue = true;
        [FieldAttr(nst: 113)] public bool DeactivateBoolValue;
        [FieldAttr(nst: 114)] public bool ExitReset;
    }
}
