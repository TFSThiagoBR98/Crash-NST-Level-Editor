namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class igGuiAction : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _critical;
        [FieldAttr(nst: 20, ctr: 16)] public float _preInvokeTime;
        [FieldAttr(nst: 24, ctr: 20)] public float _invokeTime;
        [FieldAttr(nst: 28, ctr: 24)] public bool _infiniteInvokeTime;
        [FieldAttr(nst: 29, ctr: 25)] public bool _executing;
        [FieldAttr(nst: 30, ctr: 26)] public bool _hasInvoked;
        [FieldAttr(nst: 32, ctr: 28)] public float _executionTime;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _ownerProject = new();
    }
}
