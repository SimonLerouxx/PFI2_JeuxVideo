using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class FlagScript : MonoBehaviour
{

    [SerializeField] float speed = 0.2f;

    int direction=1;
    Mesh mesh;
    MeshFilter meshFilter;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        mesh.vertices = CreateVertices(0);
        mesh.triangles= CreateTriangles();
        mesh.RecalculateNormals();
        meshFilter =GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;
        StartCoroutine(MoveFlag());
    }


    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MoveFlag()
    {
        float position = 0;
        while (true)
        {
            if(position >= 0.4)
            {
                direction = -1;
            }
            if(position <= -0.4)
            {
                direction = 1;
            }
            mesh.vertices = CreateVertices(position);
            meshFilter.mesh = mesh;
            position = position + (0.1f * direction);
            yield return new WaitForSeconds(speed);
        }
    }
    private Vector3[] CreateVertices(float x)
    {
        Vector3[] vertices =
        {
            //"Haut gauche"
            new Vector3(0,2.5f,0),
            new Vector3(x,2.5f,0.25f),
            new Vector3(x,2.5f,0.5f),
            new Vector3(x,2.5f,0.75f),
            new Vector3(x,2.5f,1f),
            new Vector3(0.1f + x,2.5f,1.25f),
            new Vector3(0.2f + x,2.5f,1.5f),
            new Vector3(0.3f + x,2.5f,1.75f),
            new Vector3(0.4f + x,2.5f,2),

            //2e ligne
            new Vector3(0,2.25f,0),
            new Vector3(x,2.25f,0.25f),
            new Vector3(x,2.25f,0.5f),
            new Vector3(x,2.25f,0.75f),
            new Vector3(x,2.25f,1f),
            new Vector3(0.1f+x,2.25f,1.25f),
            new Vector3(0.2f+x,2.25f,1.5f),
            new Vector3(0.3f+x,2.25f,1.75f),
            new Vector3(0.4f+x,2.25f,2),

            //3eLigne
           new Vector3(0,2f,0),
            new Vector3(x,2f,0.25f),
            new Vector3(x,2f,0.5f),
            new Vector3(x,2f,0.75f),
            new Vector3(x,2f,1f),
            new Vector3(0.1f+x,2f,1.25f),
            new Vector3(0.2f+x,2f,1.5f),
            new Vector3(0.3f+x,2f,1.75f),
            new Vector3(0.4f+x,2f,2),


            //4e ligne
             new Vector3(0,1.75f,0),
            new Vector3(x,1.75f,0.25f),
            new Vector3(x,1.75f,0.5f),
            new Vector3(x,1.75f,0.75f),
            new Vector3(x,1.75f,1f),
            new Vector3(0.1f+x,1.75f,1.25f),
            new Vector3(0.2f+x,1.75f,1.5f),
            new Vector3(0.3f+x,1.75f,1.75f),
            new Vector3(0.4f+x,1.75f,2),


            //bas Gauche
             new Vector3(0,1.5f,0),
            new Vector3(x,1.5f,0.25f),
            new Vector3(x,1.5f,0.5f),
            new Vector3(x,1.5f,0.75f),
            new Vector3(x,1.5f,1f),
            new Vector3(0.1f+x,1.5f,1.25f),
            new Vector3(0.2f+x,1.5f,1.5f),
            new Vector3(0.3f+x,1.5f,1.75f),
            new Vector3(0.4f+x,1.5f,2),


        };

        return vertices;
    }

    private int[] CreateTriangles()
    {

        int[] stack= new int[] {};

        
        
        return new int[]
        {

            1,0,9,
            9,10,1,

            2,1,10,
            10,11,2,

            3,2,11,
            11,12,3,

            4,3,12,
            12,13,4,

            5,4,13,
            13,14,5,

            6,5,14,
            14,15,6,

            7,6,15,
            15,16,7,

            8,7,16,
            16,17,8,

            9,8,17,
            17,18,9,

            10,9,18,
            18,19,10,

            11,10,19,
            19,20,11,

            12,11,20,
            20,21,12,

            13,12,21,
            21,22,13,

            14,13,22,
            22,23,14,

            15,14,23,
            23,24,15,

            16,15,24,
            24,25,16,

            17,16,25,
            25,26,17,

            18,17,26,
            26,27,18,

            19,18,27,
            27,28,19,

            20,19,28,
            28,29,20,

            21,20,29,
            29,30,21,

            22,21,30,
            30,31,22,

            23,22,31,
            31,32,23,

            24,23,32,
            32,33,24,

            25,24,33,
            33,34,25,

            26,25,34,
            34,35,26,

            27,26,35,
            35,36,27,

            28,27,36,
            36,37,28,

            29,28,37,
            37,38,29,

            30,29,38,
            38,39,30,

            31,29,39,
            39,40,31,

            32,31,40,
            40,41,32,

            33,32,41,
            41,42,33,

            34,33,42,
            42,43,34,

            35,34,43,
            43,44,35,


        };
    }

}
