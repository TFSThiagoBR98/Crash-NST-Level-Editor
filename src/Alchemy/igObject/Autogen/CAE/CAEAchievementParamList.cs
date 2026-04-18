namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CAEAchievementParamList : igObjectList<CAEAchievementParam>
    {
        [FieldAttr(ctr: 40)] public string? _name;
        [FieldAttr(ctr: 48)] public int _nitroPoints;
    }
}
