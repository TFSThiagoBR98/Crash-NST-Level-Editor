namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CGuiEventBossHealthBarFade : igGuiEvent
    {
        [FieldAttr(nst: 24)] public bool _fadeOut = true;
    }
}
