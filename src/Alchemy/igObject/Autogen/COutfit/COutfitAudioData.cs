namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class COutfitAudioData : igObject
    {
        [FieldAttr(ctr: 16)] public CAudioArchiveHandleList? _overrideSoundBankList;
    }
}
