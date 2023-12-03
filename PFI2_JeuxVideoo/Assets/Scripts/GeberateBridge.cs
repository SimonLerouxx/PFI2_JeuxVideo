using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeberateBridge : MonoBehaviour
{
    Mesh mesh;
    private void Awake()
    {
        mesh = new Mesh();
        mesh.vertices = CreateVertices();
    }

    const float timeBetweenStep = 0.4f;

    bool isCreating = false;
    public void GenerateBridge()
    {

        if(!isCreating)
        {
            isCreating = true;
            StartCoroutine(CreateByTime(mesh));
        }

    }



    private Vector3[] CreateVertices()
    {
        Vector3[] vertices =
        {
            new Vector3(-6.118f,53.961f,-20.1f),
            new Vector3(-6.118f,53.961f,-22.68f),
            new Vector3(-3.557f,53.237f,-20.1f),
            new Vector3(-3.557f,53.237f,-22.68f),

            new Vector3(-1.038f,52.48f,-20.1f),
            new Vector3(-1.038f,52.48f,-22.68f),

            new Vector3(1.64f,51.67f,-20.1f),
            new Vector3(1.64f,51.67f,-22.68f),

            new Vector3(4.22f,51.14f,-20.1f),
            new Vector3(4.22f,51.14f,-22.68f),

            new Vector3(7.82f,50.43f,-20.1f),
            new Vector3(7.82f,50.43f,-22.68f),

            new Vector3(10.2f,50f,-20.1f),
            new Vector3(10.2f,50f,-22.68f),

            new Vector3(15f,50f,-20.1f),
            new Vector3(15f,50f,-22.68f),

        };

        return vertices;
    }

    //private int[] CreateTriangles()
    //{
    //    return new int[]
    //    {
    //        1,0,2,
    //        2,3,1,

    //        3,2,4,
    //        4,5,3,

    //        5,4,6,
    //        6,7,5,

    //        7,6,8,
    //        8,9,7,

    //        9,8,10,
    //        10,11,9,

    //        11,10,12,
    //        12,13,11,

    //        13,12,14,
    //        14,15,13


    //    };
    //}

    IEnumerator CreateByTime(Mesh mesh)
    {
        mesh.triangles = new int[]
        {
            1,0,2,
            2,3,1,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);



        ///////////////////////
        mesh.triangles = new int[]
        {
            1,0,2,
            2,3,1,

            3,2,4,
            4,5,3,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);



        //////////////////////////
        mesh.triangles = new int[]
        {
             1,0,2,
            2,3,1,

            3,2,4,
            4,5,3,

            5,4,6,
            6,7,5,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        //////////////////////
        mesh.triangles = new int[]
        {

            3,2,4,
            4,5,3,

            5,4,6,
            6,7,5,

            7,6,8,
            8,9,7,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        /////////////////////////////
        mesh.triangles = new int[]
        {

            5,4,6,
            6,7,5,

            7,6,8,
            8,9,7,

            9,8,10,
            10,11,9,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        //////////////////////////////
        mesh.triangles = new int[]
        {

            7,6,8,
            8,9,7,

            9,8,10,
            10,11,9,

            11,10,12,
            12,13,11,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        //////////////////////////////////////
        mesh.triangles = new int[]
        {

            9,8,10,
            10,11,9,

            11,10,12,
            12,13,11,

            13,12,14,
            14,15,13
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        /////////////////////////////////////////
        mesh.triangles = new int[]
        {

            11,10,12,
            12,13,11,

            13,12,14,
            14,15,13
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);
        ////////////////////////////////////////
        mesh.triangles = new int[]
        {
            13,12,14,
            14,15,13
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);

        mesh.triangles = null;
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshCollider>().sharedMesh = mesh;
        yield return new WaitForSeconds(timeBetweenStep);

        isCreating= false;

    }


}
