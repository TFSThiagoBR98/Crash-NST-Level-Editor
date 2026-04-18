namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T111_Crash_Cove_CGameEntity_simulated_rippleData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 36)] public float _Float_0x24;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Water_Simulation_Settings = new();
    }
}
