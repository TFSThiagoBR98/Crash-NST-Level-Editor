namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 272, align: 16)]
    public class igGuiPlaceableBolt : igVfxBolt
    {
        [FieldAttr(nst: 240, ctr: 240)] public igHandleMetaField _place = new();
        [FieldAttr(nst: 248, ctr: 248)] public float _distanceFromCamera = 50.0f;
        [FieldAttr(nst: 256, ctr: 256)] public igHandleMetaField _spawnedEffect = new();
        [FieldAttr(nst: 264, ctr: 264)] public bool _setBoltParametersFromTexCoords;
    }
}
