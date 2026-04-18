namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igRenderPass : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _active;
        [FieldAttr(nst: 32, ctr: 32)] public string? _passEventName = null;
        [FieldAttr(nst: 40, ctr: 40)] public igRenderPassList? _children;
        [FieldAttr(nst: 48, ctr: 48)] public u16 _totalChildCount;
        [FieldAttr(nst: 49, ctr: 50)] public u16 _passId = 255;
    }
}
