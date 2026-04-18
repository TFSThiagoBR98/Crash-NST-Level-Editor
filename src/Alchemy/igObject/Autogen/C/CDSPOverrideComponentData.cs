namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CDSPOverrideComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public bool _startActive = true;
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _overrideSet = new();
        [FieldAttr(nst: 40, ctr: 32)] public bool _allowCameraToTrigger;
        [FieldAttr(nst: 41, ctr: 33)] public bool _ignoreChecksForCanPlayerControl;
    }
}
