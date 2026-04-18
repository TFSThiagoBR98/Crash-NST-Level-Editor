namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CShowroomCharacterComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CShowroomCharacterKeyFrameDataList? _characterKeyFrameData;
    }
}
