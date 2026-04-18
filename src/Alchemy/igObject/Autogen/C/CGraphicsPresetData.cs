namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CGraphicsPresetData : igObject
    {
        [FieldAttr(nst: 16)] public CGraphicsSettingTable? _graphicsPresetLow;
        [FieldAttr(nst: 24)] public CGraphicsSettingTable? _graphicsPresetMedium;
        [FieldAttr(nst: 32)] public CGraphicsSettingTable? _graphicsPresetHigh;
        [FieldAttr(nst: 40)] public CGraphicsSettingTable? _graphicsPresetUltra;
    }
}
