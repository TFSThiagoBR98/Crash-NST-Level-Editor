namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CCutsceneActionOpenUi : CCutsceneAction
    {
        [FieldAttr(nst: 24)] public string? _menuName = null;
        [FieldAttr(nst: 32)] public CCharacterIntroductionInfo? _characterIntroductionInfo;
    }
}
