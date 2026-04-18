namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CLevelConfirmationDialogBoxHandler : igObject
    {
        public enum EContextualParameter
        {
            eCP_None = 0,
            eCP_QuestTitle = 1,
            eCP_ObjectiveDescription = 2,
            eCP_LevelName = 3,
            eCP_ChapterName = 4,
        }

        [FieldAttr(nst: 16)] public EContextualParameter _title;
        [FieldAttr(nst: 24)] public string? _bodyString = null;
        [FieldAttr(nst: 32)] public EContextualParameter _bodyParameter0;
        [FieldAttr(nst: 36)] public EContextualParameter _bodyParameter1;
        [FieldAttr(nst: 40)] public EContextualParameter _bodyParameter2;
        [FieldAttr(nst: 48)] public igHandleMetaField _level = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _checkpoint = new();
        [FieldAttr(nst: 64)] public string? _questTitle = null;
        [FieldAttr(nst: 72)] public string? _objectiveDescription = null;
        [FieldAttr(nst: 80)] public CChangeRequest? _syncWaitRequest;
    }
}
