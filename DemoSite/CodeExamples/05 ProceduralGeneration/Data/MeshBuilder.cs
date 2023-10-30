using System;
using System.Collections.Generic;
using UnityEngine;

namespace eWolf.CodeExamples.ProceduralGeneration
{
    public class MeshBuilder
    {
        private List<Vector2> MeshUVs { get; set; } = new List<Vector2>();
        private List<Vector3> MeshVertices { get; set; } = new List<Vector3>();
        private List<int> Triangles { get; set; } = new List<int>();

        public void ApplyMeshDetails(GameObject baseobject, Material material)
        {
            Mesh mesh = new Mesh
            {
                name = $"MyMesh {DateTime.Now.ToShortDateString()}"
            };
            baseobject.GetComponent<MeshFilter>().mesh = mesh;

            mesh.vertices = MeshVertices.ToArray();
            mesh.uv = MeshUVs.ToArray();

            Renderer r = baseobject.GetComponent<Renderer>();
            r.sharedMaterial = material;

            mesh.SetTriangles(Triangles.ToArray(), 0);

            mesh.subMeshCount = 1;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
        }

        public void BuildQuad(Vector3 a, Vector3 b, Vector3 c, Vector3 d, UVSet uvset)
        {
            int indexA = AddVectorUVSets(a, uvset.BR);
            int indexB = AddVectorUVSets(b, uvset.TR);
            int indexC = AddVectorUVSets(c, uvset.BL);
            int indexD = AddVectorUVSets(d, uvset.TL);

            Triangles.AddRange(new int[] { indexA, indexB, indexC });
            Triangles.AddRange(new int[] { indexD, indexC, indexB });
        }

        private int AddVectorUVSets(Vector3 points, Vector2 uvs)
        {
            MeshVertices.Add(points);
            MeshUVs.Add(uvs);
            return MeshVertices.Count - 1;
        }
    }
}