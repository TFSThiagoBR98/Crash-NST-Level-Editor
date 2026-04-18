namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CGameVariable : igObject
    {
        public enum EGameVariableLifetime
        {
            eGVL_Saved = 0,
            eGVL_Session = 1,
            eGVL_Level = 2,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EGameVariableLifetime _variableLifetime;
        [FieldAttr(nst: 20, ctr: 16)] public bool _replicated = true;
        [FieldAttr(nst: 21, ctr: 17)] public bool _triggerAutoSave = true;
    }
}
