namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CGuiCrashSoundContainer : CGuiBaseSoundContainer
    {
        [FieldAttr(nst: 24)] public CGuiMenuSoundTable? _crash1MenuSoundTable;
        [FieldAttr(nst: 32)] public CGuiMenuSoundTable? _crash2MenuSoundTable;
        [FieldAttr(nst: 40)] public CGuiMenuSoundTable? _crash3MenuSoundTable;
    }
}
