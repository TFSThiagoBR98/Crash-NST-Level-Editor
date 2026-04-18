namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CSoundUpdateMethod : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _updatePeriod = 0.3f;
        [FieldAttr(nst: 24, ctr: 16)] public CScopedScheduledFunction? _scheduledFunction;
        [FieldAttr(nst: 32, ctr: 24)] public CSoundUpdateTaskList? _soundTaskList;
        [FieldAttr(nst: 40, ctr: 32)] public CSoundUpdateReferenceOverride? _referenceOverride;
    }
}
