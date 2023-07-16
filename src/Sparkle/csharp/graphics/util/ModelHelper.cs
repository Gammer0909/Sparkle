using System.Numerics;
using Raylib_cs;

namespace Sparkle.csharp.graphics.util; 

public static class ModelHelper {
    
    public static Model LoadModel(string path) => Raylib.LoadModel(path);
    public static Model LoadModel(Mesh mesh) => Raylib.LoadModelFromMesh(mesh);
    public static bool IsModelReady(Model model) => Raylib.IsModelReady(model);
    public static void UnloadModel(Model model) => Raylib.UnloadModel(model);
    
    public static BoundingBox GetModelBoundingBox(Model model) => Raylib.GetModelBoundingBox(model);
    public static void SetModelMeshMaterial(ref Model model, int meshId, int materialId) => Raylib.SetModelMeshMaterial(ref model, meshId, materialId);

    public static void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color) => Raylib.DrawLine3D(startPos, endPos, color);
    public static void DrawPoint3D(Vector3 position, Color color) => Raylib.DrawPoint3D(position, color);
    public static void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color) => Raylib.DrawCircle3D(center, radius, rotationAxis, rotationAngle, color);
    public static void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color) => Raylib.DrawTriangle3D(v1, v2, v3, color);
    public static unsafe void DrawTriangleStrip3D(Vector3 *points, int pointCount, Color color) => Raylib.DrawTriangleStrip3D(points, pointCount, color);
    public static void DrawCube(Vector3 position, float width, float height, float length, Color color) => Raylib.DrawCube(position, width, height, length, color);
    public static void DrawCube(Vector3 position, Vector3 size, Color color) => Raylib.DrawCubeV(position, size, color);
    public static void DrawCubeWires(Vector3 position, float width, float height, float length, Color color) => Raylib.DrawCubeWires(position, width, height, length, color);
    public static void DrawCubeWires(Vector3 position, Vector3 size, Color color) => Raylib.DrawCubeWiresV(position, size, color);
    public static void DrawSphere(Vector3 centerPos, float radius, Color color) => Raylib.DrawSphere(centerPos, radius, color);
    public static void DrawSphere(Vector3 centerPos, float radius, int rings, int slices, Color color) => Raylib.DrawSphereEx(centerPos, radius, rings, slices, color);
    public static void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color) => Raylib.DrawSphereWires(centerPos, radius, rings, slices, color);
    public static void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color) => Raylib.DrawCylinder(position, radiusTop, radiusBottom, height, slices, color);
    public static void DrawCylinder(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color) => Raylib.DrawCylinderEx(startPos, endPos, startRadius, endRadius, sides, color);
    public static void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color) => Raylib.DrawCylinderWires(position, radiusTop, radiusBottom, height, slices, color);
    public static void DrawCylinderWires(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color) => Raylib.DrawCylinderWiresEx(startPos, endPos, startRadius, endRadius, sides, color);
    public static void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color) => Raylib.DrawCapsule(startPos, endPos, radius, slices, rings, color);
    public static void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color) => Raylib.DrawCapsuleWires(startPos, endPos, radius, slices, rings, color);
    public static void DrawPlane(Vector3 centerPos, Vector2 size, Color color) => Raylib.DrawPlane(centerPos, size, color);
    public static void DrawRay(Ray ray, Color color) => Raylib.DrawRay(ray, color);
    public static void DrawGrid(int slices, float spacing) => Raylib.DrawGrid(slices, spacing);
    
    public static void DrawModel(Model model, Vector3 position, float scale, Color color) => Raylib.DrawModel(model, position, scale, color);
    public static void DrawModel(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color color) => Raylib.DrawModelEx(model, position, rotationAxis, rotationAngle, scale, color);
    public static void DrawModelWires(Model model, Vector3 position, float scale, Color color) => Raylib.DrawModelWires(model, position, scale, color);
    public static void DrawModelWires(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color color) => Raylib.DrawModelWiresEx(model, position, rotationAxis, rotationAngle, scale, color);
    public static void DrawBoundingBox(BoundingBox box, Color color) => Raylib.DrawBoundingBox(box, color);
    
    public static ReadOnlySpan<ModelAnimation> LoadModelAnimations(string path, ref uint animCount) => Raylib.LoadModelAnimations(path, ref animCount);
    public static void UpdateModelAnimation(Model model, ModelAnimation anim, int frame) => Raylib.UpdateModelAnimation(model, anim, frame);
    public static void UnloadModelAnimation(ModelAnimation anim) => Raylib.UnloadModelAnimation(anim);
    public static unsafe void UnloadModelAnimations(ModelAnimation* animations, uint count) => Raylib.UnloadModelAnimations(animations, count);
    public static bool IsModelAnimationValid(Model model, ModelAnimation anim) => Raylib.IsModelAnimationValid(model, anim);
}