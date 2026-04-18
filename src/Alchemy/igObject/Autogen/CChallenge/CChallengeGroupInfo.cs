namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CChallengeGroupInfo : igObject
    {
        [FieldAttr(ctr: 16)] public CAEKind? _groupKind;
        [FieldAttr(ctr: 24)] public string? _groupName;
        [FieldAttr(ctr: 32)] public igHandleMetaField _groupIcon = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _groupBackgroundIcon = new();
    }
}
