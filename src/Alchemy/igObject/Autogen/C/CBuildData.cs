namespace Alchemy
{
    [ObjectAttr(ctr: 152, align: 8)]
    public class CBuildData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _buildName;
        [FieldAttr(ctr: 24)] public int _maxPlayerCount;
        [FieldAttr(ctr: 28)] public bool _marketingMenuFlow;
        [FieldAttr(ctr: 29)] public bool _allowDebugInputs;
        [FieldAttr(ctr: 30)] public bool _allowNetwork;
        [FieldAttr(ctr: 32)] public CZoneInfoHandleList? _excludedMaps;
        [FieldAttr(ctr: 40)] public CRacerDriverDataHandleList? _excludedDrivers;
        [FieldAttr(ctr: 48)] public bool _classicSkinsOnly;
        [FieldAttr(ctr: 56)] public CDriverSkinDataHandleList? _excludedSkins;
        [FieldAttr(ctr: 64)] public bool _classicKartsOnly;
        [FieldAttr(ctr: 72)] public CRacerKartDataHandleList? _excludedKarts;
        [FieldAttr(ctr: 80)] public CKartCustomizationItemHandleList? _excludedWheels;
        [FieldAttr(ctr: 88)] public CKartCustomizationColorSchemeHandleList? _excludedPaints;
        [FieldAttr(ctr: 96)] public CKartCustomizationDecalHandleList? _excludedDecals;
        [FieldAttr(ctr: 104)] public CKartCustomizationStickerHandleList? _excludedStickers;
        [FieldAttr(ctr: 112)] public CKartCustomizationPresetItemHandleList? _excludedPresets;
        [FieldAttr(ctr: 120)] public CRacerCustomizationPresetList? _aiPreset;
        [FieldAttr(ctr: 128)] public bool _saveLoadEnabled;
        [FieldAttr(ctr: 129)] public bool _unlockAll;
        [FieldAttr(ctr: 136)] public string? _titleMenuLevelName;
        [FieldAttr(ctr: 144)] public bool _restrictedCustomization;
        [FieldAttr(ctr: 145)] public bool _preventAutomaticPartyCreation;
        [FieldAttr(ctr: 146)] public bool _isOnlineDemo;
        [FieldAttr(ctr: 148)] public int _buildPlaylistId;
    }
}
