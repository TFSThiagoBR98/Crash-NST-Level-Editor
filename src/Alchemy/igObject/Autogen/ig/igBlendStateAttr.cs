namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class igBlendStateAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 17)] public bool _enabled;
        [FieldAttr(nst: 25, ctr: 18)] public bool _alphaToCoverageEnabled;
    }
}
