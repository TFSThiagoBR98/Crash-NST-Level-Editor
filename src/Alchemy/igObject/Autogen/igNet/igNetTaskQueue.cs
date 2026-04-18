namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igNetTaskQueue : igObject
    {
        public enum EState
        {
            kQueueIdle = 0,
            kQueueProcessingTask = 1,
        }

        [FieldAttr(nst: 16, ctr: 16)] public igNetTaskList? _taskList;
        [FieldAttr(nst: 24, ctr: 24)] public EState _state;
        [FieldAttr(nst: 32, ctr: 32)] public igNetTask? _currentTask;
        [FieldAttr(nst: 40, ctr: 40)] public igMutex? _lock;
    }
}
