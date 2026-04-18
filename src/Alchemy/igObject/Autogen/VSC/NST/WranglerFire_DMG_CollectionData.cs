namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class WranglerFire_DMG_CollectionData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Melee01DMG = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Melee02DMG = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Melee03DMG = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _ChargeLongDMG = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _ChargeEndDMGRed = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _ChargeDOTDMG = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _ChargeDOTRemovalDMG = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _ChargeEndDMGWolf = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Melee01BDMG = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _AxeDMG = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _ChargeShortDMG = new();
    }
}
