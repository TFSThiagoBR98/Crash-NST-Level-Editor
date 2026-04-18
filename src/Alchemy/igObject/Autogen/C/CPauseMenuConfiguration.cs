namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 16)]
    public class CPauseMenuConfiguration : igObject
    {
        [ObjectAttr(size: 4)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _useCarousel;
            [FieldAttr(offset: 1, size: 1)] public bool _fullscreenInOnOpen;
            [FieldAttr(offset: 2, size: 1)] public bool _showAreaName;
            [FieldAttr(offset: 3, size: 1)] public bool _showCharacterBarWidget;
            [FieldAttr(offset: 4, size: 1)] public bool _showVaultCodeWidget;
            [FieldAttr(offset: 5, size: 1)] public bool _showDescriptions;
            [FieldAttr(offset: 6, size: 1)] public bool _showObjectives;
            [FieldAttr(offset: 7, size: 1)] public bool _showDetailsImage;
            [FieldAttr(offset: 8, size: 1)] public bool _allowBackOutOnButtonPress;
            [FieldAttr(offset: 9, size: 1)] public bool _pauseGame;
            [FieldAttr(offset: 10, size: 1)] public bool _showPlayerActorInScreenspace;
            [FieldAttr(offset: 11, size: 1)] public bool _showBackgroundFilmStrip;
            [FieldAttr(offset: 12, size: 1)] public bool _playTutorialVo;
            [FieldAttr(offset: 13, size: 1)] public bool _logEvents;
        }

        [FieldAttr(nst: 16, ctr: 16)] public string? _displayName = null;
        [FieldAttr(nst: 24, ctr: 24)] public CPauseMenuOptionList? _menuOptions;
        [FieldAttr(nst: 32, ctr: 32)] public CPauseMenuOption? _menuOptionOnOption2;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _templateItem = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _marginOffset = new();
        [FieldAttr(nst: 64, ctr: 64)] public igObject? _gameData;
        [FieldAttr(nst: 72, ctr: 72)] public igHandleMetaField _initiallyFocusedOption = new();
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _initiallyFocusedOptionOverride = new();
        [FieldAttr(nst: 88, ctr: 88)] public string? _additionalGuiWidget = null;
        [FieldAttr(nst: 96, ctr: 96)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 104, ctr: 104)] public string? _networkEventName = null;
    }
}
