using UnityEngine;

namespace eWolf.CodeExamples.ProceduralGeneration
{
    public class CreateMesh : MonoBehaviour
    {
        public Material material;
        private MeshBuilder _meshBuilder = new MeshBuilder();

        public void BuildMesh()
        {
            _meshBuilder = new MeshBuilder();
            UVSet uvSet = new UVSet(1, 1);

            float size = 1f;
            float width = 0.1f;

            Vector3 xy = new Vector3(0, 0, 0);
            Vector3 xytop = xy + Vector3.up * size;
            Vector3 xyFar = xy + Vector3.forward * size;
            Vector3 xytopFar = xytop + Vector3.forward * size;
            _meshBuilder.BuildQuad(xy, xyFar, xytop, xytopFar, uvSet);

            xy = new Vector3(width, 0, 0);
            xytop = xy + Vector3.up * size;
            xyFar = xy + Vector3.forward * size;
            xytopFar = xytop + Vector3.forward * size;
            _meshBuilder.BuildQuad(xytop, xytopFar, xy, xyFar, uvSet);

            UVSet uvSetEnd = new UVSet(width, 1);
            xy = new Vector3(0, 0, 0);
            xytop = xy + Vector3.up * size;
            xyFar = xy + Vector3.right * width;
            xytopFar = xytop + Vector3.right * width;
            _meshBuilder.BuildQuad(xytop, xytopFar, xy, xyFar, uvSetEnd);


            _meshBuilder.ApplyMeshDetails(gameObject, material);
        }

        public void ClearMesh()
        {
            _meshBuilder = new MeshBuilder();
            _meshBuilder.ApplyMeshDetails(gameObject, material);
        }
    }
}