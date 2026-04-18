namespace Alchemy
{
    [ObjectAttr(nst: 208, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_SpawnCollectiblesComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_SpawnCollectiblesComponent_
    {
        [FieldAttr(nst: 40)] public bool SpawnOnStartOnlyOnce;
        [FieldAttr(nst: 41)] public bool SpawnOnDeath;
        [FieldAttr(nst: 42)] public bool SpawnOnRemoveWhenDead;
        [FieldAttr(nst: 43)] public bool SpawnOnMessage;
        [FieldAttr(nst: 48)] public CEntityMessage? ReceivingMessage;
        [FieldAttr(nst: 56)] public Scripts_SpawnCollectiblesComponentData_CollectibleSelectionMethod? SeletionMethod;
        [FieldAttr(nst: 64)] public Scripts_SpawnCollectiblesComponentData_CollectibleSelectionMethod? VehicleSeletionMethod;
        [FieldAttr(nst: 72)] public RangedFloat? MaxCollectiblesToSpawn;
        [FieldAttr(nst: 80)] public float ChanceToSpawn = 1.0f;
        [FieldAttr(nst: 84)] public float Delay;
        [FieldAttr(nst: 88)] public float HorizontalAngularSpread = 360.0f;
        [FieldAttr(nst: 92)] public float HorizontalAngle;
        [FieldAttr(nst: 96)] public bool RotateTowardsPlayer;
        [FieldAttr(nst: 104)] public CBoltPoint? SpawnBoltPoint;
        [FieldAttr(nst: 112)] public Vector3? SpawnOffset;
        [FieldAttr(nst: 120)] public bool FaceCamera;
        [FieldAttr(nst: 124)] public int NumCollectiblesInWave = 1;
        [FieldAttr(nst: 128)] public RangedFloat? HorizontalVelocity;
        [FieldAttr(nst: 136)] public float HorizontalVelocityScaleAirVehicle = 1.0f;
        [FieldAttr(nst: 144)] public RangedFloat? VerticalVelocity;
        [FieldAttr(nst: 152)] public float VerticalVelocityScaleAirVehicle = 1.0f;
        [FieldAttr(nst: 160)] public Vector3? WorldDirectionalVelocity;
        [FieldAttr(nst: 168)] public igHandleMetaField SpawnSound = new();
        [FieldAttr(nst: 176)] public bool RemoveEntityWhenFinished;
        [FieldAttr(nst: 180)] public float RemoveEntityDelay;
        [FieldAttr(nst: 184)] public bool RemoveEntityWhenAllCollected;
        [FieldAttr(nst: 185)] public bool ForceCollect;
        [FieldAttr(nst: 192)] public RangedFloat? ForceCollectDelay;
        [FieldAttr(nst: 200)] public bool SynchronizeSpawnOnline;
    }
}
