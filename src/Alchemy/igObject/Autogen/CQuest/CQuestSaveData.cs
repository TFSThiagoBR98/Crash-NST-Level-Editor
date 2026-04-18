namespace Alchemy
{
    [ObjectAttr(ctr: 16, align: 4)]
    public class CQuestSaveData : igObject
    {
        [FieldAttr(ctr: 12)] public uint _saveBitfield;
    }
}
