namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class CCutsceneActor : JuiceVisual
    {
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _proxiedEntity = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 60, ctr: 60)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 72, ctr: 72)] public igVec3fMetaField _scale = new();
        [FieldAttr(nst: 88, ctr: 88)] public CSkinnedModelInstance? _model;
        [FieldAttr(nst: 96, ctr: 96)] public CCutsceneActorData? _entityData;
        [FieldAttr(nst: 104, ctr: 104)] public string? _cutsceneOwnerName = "DO NOT CHANGE";
        [FieldAttr(nst: 112, ctr: 112)] public string? _animationDatabasePath = "DO NOT CHANGE";
    }
}
