namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CDroppablePowerUpComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _dropSpeed;
        [FieldAttr(ctr: 20)] public float _distanceAbove;
        [FieldAttr(ctr: 24)] public float _distanceBelow;
        [FieldAttr(ctr: 28)] public igVec3fMetaField _desiredGroundDistance = new();
    }
}
