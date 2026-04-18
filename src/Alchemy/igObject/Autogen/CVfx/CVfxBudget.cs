namespace Alchemy
{
    [ObjectAttr(nst: 296, ctr: 296, align: 4)]
    public class CVfxBudget : igVfxBudget
    {
        [FieldAttr(nst: 240, ctr: 236)] public uint _CVfxBoltCount = 32;
        [FieldAttr(nst: 244, ctr: 240)] public uint _CVfxCameraBoltCount = 32;
        [FieldAttr(nst: 248, ctr: 244)] public uint _CVfxDebugBoltCount = 32;
        [FieldAttr(nst: 252, ctr: 248)] public uint _CVfxMeshSpawnLocationCount = 32;
        [FieldAttr(nst: 256, ctr: 252)] public uint _CVfxGroundBoltCount = 32;
        [FieldAttr(nst: 260, ctr: 256)] public uint _CVfxScreenBoltCount = 32;
        [FieldAttr(nst: 264, ctr: 260)] public uint _CVfxLandVehicleMaterialCollisionBoltCount = 32;
        [FieldAttr(ctr: 264)] public uint _CVfxKartMaterialCollisionBoltCount;
        [FieldAttr(nst: 268, ctr: 268)] public uint _CVfxWaterVehicleWaterCollisionBoltCount = 32;
        [FieldAttr(nst: 272, ctr: 272)] public uint _CVfxVehicleMaterialCollisionSpawnRateCount = 32;
        [FieldAttr(nst: 276, ctr: 276)] public uint _pointLightPoolCount = 32;
        [FieldAttr(nst: 280, ctr: 280)] public uint _boxLightPoolCount = 32;
        [FieldAttr(nst: 284, ctr: 284)] public uint _tintSpherePoolCount = 32;
        [FieldAttr(nst: 288, ctr: 288)] public uint _rigidBodyCount = 200;
        [FieldAttr(nst: 292, ctr: 292)] public uint _drawModelCount = 200;
    }
}
