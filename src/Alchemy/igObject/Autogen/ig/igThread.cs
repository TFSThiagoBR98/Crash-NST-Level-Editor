namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class igThread : igNamedObject
    {
        public enum EPriority
        {
            kLow = 50,
            kNormal = 128,
            kHigh = 200,
            kUrgent = 255,
        }

        [FieldAttr(nst: 24, ctr: 24)] public EPriority _priority = igThread.EPriority.kNormal;
        [FieldAttr(nst: 28, ctr: 28)] public bool _active;
        [FieldAttr(nst: 32, ctr: 32)] public igRawRefMetaField _arg = new();
        [FieldAttr(nst: 40, ctr: 40)] public uint _stackSize = 16384;
        [FieldAttr(nst: 48, ctr: 48)] public igRawRefMetaField _function = new();
        [FieldAttr(nst: 56, ctr: 56)] public bool _isMaster;
        [FieldAttr(nst: 64, ctr: 64)] public igVectorMetaField<igObject> _threadLocalObjects = new();
        [FieldAttr(nst: 88, ctr: 88)] public int _hardwareThread = -2;
        [FieldAttr(nst: 96, ctr: 96)] public igRawRefMetaField _result = new();
        [FieldAttr(nst: 104, ctr: 104)] public igRawRefMetaField _threadHandle = new();
        [FieldAttr(nst: 112)] public uint _threadID;
        [FieldAttr(ctr: 112)] public uint _doneSignal;
    }
}
