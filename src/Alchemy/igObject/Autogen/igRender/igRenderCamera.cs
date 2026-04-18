namespace Alchemy
{
    [ObjectAttr(nst: 256, ctr: 256, align: 16)]
    public class igRenderCamera : igNamedObject
    {
        public enum ECameraMode
        {
            kPerspective = 0,
            kOrthographic = 1,
        }

        [FieldAttr(nst: 24, ctr: 24)] public igVec3fMetaField _up = new();
        [FieldAttr(nst: 36, ctr: 36)] public igVec3fMetaField _lookAtPos = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _pos = new();
        [FieldAttr(nst: 60, ctr: 60)] public float _fov = 45.0f;
        [FieldAttr(nst: 64, ctr: 64)] public float _aspect = 1.0f;
        [FieldAttr(nst: 68, ctr: 68)] public float _left;
        [FieldAttr(nst: 72, ctr: 72)] public float _right;
        [FieldAttr(nst: 76, ctr: 76)] public float _bottom;
        [FieldAttr(nst: 80, ctr: 80)] public float _top;
        [FieldAttr(nst: 84, ctr: 84)] public int _viewportX;
        [FieldAttr(nst: 88, ctr: 88)] public int _viewportY;
        [FieldAttr(nst: 92, ctr: 92)] public int _viewportWidth = 640;
        [FieldAttr(nst: 96, ctr: 96)] public int _viewportHeight = 480;
        [FieldAttr(nst: 100, ctr: 100)] public float _near = 1.0f;
        [FieldAttr(nst: 104, ctr: 104)] public float _far = 1.0f;
        [FieldAttr(nst: 108, ctr: 108)] public ECameraMode _mode;
        [FieldAttr(nst: 112, ctr: 112)] public igMatrix44fMetaField _viewMatrix = new();
        [FieldAttr(nst: 176, ctr: 176)] public igMatrix44fMetaField _projectionMatrix = new();
        [FieldAttr(nst: 240, ctr: 240)] public bool _fixedViewport;
        [FieldAttr(nst: 241, ctr: 241)] public bool _updateProjectionOnSizeChange = true;
        [FieldAttr(nst: 242, ctr: 242)] public bool _enabled = true;
    }
}
