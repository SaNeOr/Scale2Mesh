using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale2Mesh : MonoBehaviour
{
    public Mesh mesh;
    public Vector3 size = Vector3.one;
    Vector3[] originVertices;

    public void MarkVerticesInfo(){
        if(GetComponent<MeshFilter>().mesh){
            mesh = GetComponent<MeshFilter>().mesh;
            originVertices = mesh.vertices;
            // size = Vector3.one;
        }
    }
    public void S2M(){
        MarkVerticesInfo();
        Vector3 scaleInfo = transform.localScale;
        RecalculateMeshSize(scaleInfo);
        transform.localScale = Vector3.one;
    }

    public void ChangeMeshSize(){
        RecalculateMeshSize(size);
    }

    void RecalculateMeshSize(Vector3 newSize){
        Vector3[] vertices = new Vector3[originVertices.Length];
        int p = 0;
        while (p < originVertices.Length)
        {
            vertices[p] = new Vector3(originVertices[p].x * newSize.x, originVertices[p].y * newSize.y, originVertices[p].z * newSize.z);
            p++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }

}
