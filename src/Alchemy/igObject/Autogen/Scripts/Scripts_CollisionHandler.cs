namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_CollisionHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public bool CollideWithEnemies = true;
        [FieldAttr(nst: 81)] public bool CollideWithAltEnemies = true;
        [FieldAttr(nst: 82)] public bool CollideWithHeroes = true;
        [FieldAttr(nst: 83)] public bool CollideWithPlayers = true;
        [FieldAttr(nst: 84)] public bool CollideWithProjectiles = true;
    }
}
