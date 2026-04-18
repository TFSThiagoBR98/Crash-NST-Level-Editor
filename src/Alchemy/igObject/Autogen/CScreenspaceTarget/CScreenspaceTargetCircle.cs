namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CScreenspaceTargetCircle : CScreenspaceTargetShape
    {
        [FieldAttr(nst: 16)] public igVec2fMetaField _center = new();
        [FieldAttr(nst: 24)] public float _radius;
        [FieldAttr(nst: 28)] public float _scale = 1.0f;
    }
}
