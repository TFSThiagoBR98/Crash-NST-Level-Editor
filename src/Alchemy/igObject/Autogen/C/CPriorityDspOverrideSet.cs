namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CPriorityDspOverrideSet : CDspOverrideSet
    {
        [FieldAttr(nst: 48, ctr: 44)] public int _priority = -1;
        [FieldAttr(nst: 52, ctr: 48)] public float _activeTime = -1.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _fadeOutTime = 2.0f;
    }
}
