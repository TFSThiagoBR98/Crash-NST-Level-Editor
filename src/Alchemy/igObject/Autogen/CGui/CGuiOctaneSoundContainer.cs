namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CGuiOctaneSoundContainer : CGuiBaseSoundContainer
    {
        [FieldAttr(ctr: 24)] public CGuiMenuSoundTable? _Octane1MenuSoundTable;
        [FieldAttr(ctr: 32)] public CGuiMenuSoundTable? _Octane2MenuSoundTable;
        [FieldAttr(ctr: 40)] public CGuiMenuSoundTable? _Octane3MenuSoundTable;
    }
}
