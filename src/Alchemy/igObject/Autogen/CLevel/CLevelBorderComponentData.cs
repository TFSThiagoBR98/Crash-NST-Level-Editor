namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CLevelBorderComponentData : CEntityComponentData
    {
        public enum EBorderType
        {
            eBT_Collision = 0,
            eBT_Trigger = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public CLevelBorder? _border;
        [FieldAttr(nst: 32, ctr: 24)] public string? _borderPath = null;
        [FieldAttr(nst: 40, ctr: 32)] public uint _stopFlags = 383;
        [FieldAttr(nst: 44, ctr: 36)] public bool _airVehicleShouldTurnAround = true;
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _levelBorderVfxToSpawn = new();
        [FieldAttr(nst: 56, ctr: 48)] public EBorderType _borderType;
    }
}
