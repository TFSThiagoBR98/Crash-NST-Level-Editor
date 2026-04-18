namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CMod : CUpgrade
    {
        public enum EModLocation
        {
            eML_Invalid = -1,
            eML_Primary = 0,
            eML_Secondary = 1,
            eML_Horn = 2,
            eML_Antenna = 3,
            eML_Count = 4,
        }

        [FieldAttr(nst: 24)] public CEntityComponentDataList? _modComponentDataList;
        [FieldAttr(nst: 32)] public string? _voiceOverNameSound = null;
        [FieldAttr(nst: 40)] public string? _voiceOverTaglineSound = null;
        [FieldAttr(nst: 48)] public string? _idleSound = null;
        [FieldAttr(nst: 56)] public string? _oneShotSound = null;
        [FieldAttr(nst: 64)] public string? _modAssetPrefix = null;
        [FieldAttr(nst: 72)] public EModLocation _modLocation = CMod.EModLocation.eML_Invalid;
        [FieldAttr(nst: 76)] public int _modIndex = -1;
    }
}
