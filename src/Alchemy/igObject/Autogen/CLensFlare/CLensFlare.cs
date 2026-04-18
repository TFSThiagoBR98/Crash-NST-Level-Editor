namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 16)]
    public class CLensFlare : igObject
    {
        [FieldAttr(ctr: 12)] public igVec2fMetaField _texCoordMin = new();
        [FieldAttr(ctr: 20)] public igVec2fMetaField _texCoordMax = new();
        [FieldAttr(ctr: 32)] public igVec4fMetaField _color = new();
        [FieldAttr(ctr: 48)] public float _distanceAlongAxis;
        [FieldAttr(ctr: 52)] public float _size;
        [FieldAttr(ctr: 56)] public igVec2fMetaField _screenPosition = new();
        [FieldAttr(ctr: 64)] public float _distance;
        [FieldAttr(ctr: 68)] public float _opacity;
        [FieldAttr(ctr: 72)] public float _screenRotation;
        [FieldAttr(ctr: 76)] public float _scale;
        [FieldAttr(ctr: 80)] public bool _visible;
    }
}
