using MSCLoader;
using UnityEngine;

namespace ModUtils
{
    public static class MeshReplacer
    {
        public static void ReplaceMesh(MeshRenderer meshRendererToReplace, MeshFilter meshFilterToReplace, Mesh mesh, Material material)
        {
            meshFilterToReplace.sharedMesh = mesh;
            meshRendererToReplace.sharedMaterial = material;
        }
    }
}