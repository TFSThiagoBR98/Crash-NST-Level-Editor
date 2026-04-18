namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CGuiListItemPopulatorPauseMenu : igGuiListItemPopulator
    {
        [FieldAttr(nst: 16)] public bool _isCarousel;
        [FieldAttr(nst: 17)] public bool _refreshMenuOptions = true;
        [FieldAttr(nst: 24, refCount: false)] public CPauseMenuOptionList? _sourceMenuOptions;
        [FieldAttr(nst: 32)] public CPauseMenuOptionList? _pauseMenuOptions;
    }
}
