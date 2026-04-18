namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CStaticCollisionComponentData : igComponentData
    {
        [ObjectAttr(size: 4)]
        public class FlagsBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _disableCollision;
            [FieldAttr(offset: 1, size: 1)] public bool _enableNavMesh;
        }

        [FieldAttr(nst: 24, ctr: 16)] public FlagsBitfield _flagsBitfield = new();
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _collisionMaterial = new();
    }
}
