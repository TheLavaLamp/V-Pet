using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FacePanel4 : MonoBehaviour
{

    [Range(1, 9)]
    private int faces;

    private int gNumber = 3;     //this number is for the determination of the vertical and horizontal number of images

    private Material faceMat;
    public Transform controller;

    // Start is called before the first frame update
    void Start()
    {
        faceMat = GetComponent<Renderer>().sharedMaterial;
        //Renderer rend = GetComponent<Renderer>();
        //rend.material = new Material(faceMat);

        //faceMat = rend.material;
        //faceMat.CopyPropertiesFromMaterial(mat);
        //faceMat = mat;



    }

    // Update is called once per frame
    void Update()
    {

        //if (transform.position.x > 1 && transform.position.x < 2)
        //    Debug.Log("hi");


        //Debug.Log(controller.transform.localPosition.y + " , " + controller.transform.localPosition.y);



        if (controller.transform.localPosition.x < GridUnit(gNumber) && controller.transform.localPosition.y > -GridUnit(gNumber))
        {
            faces = 1;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 2 && controller.transform.localPosition.y > -GridUnit(gNumber))
        {
            faces = 2;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 3 && controller.transform.localPosition.y > -GridUnit(gNumber))
        {
            faces = 3;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) && controller.transform.localPosition.y > -GridUnit(gNumber) * 2)
        {
            faces = 4;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 2 && controller.transform.localPosition.y > -GridUnit(gNumber) * 2)
        {
            faces = 5;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 3 && controller.transform.localPosition.y > -GridUnit(gNumber) * 2)
        {
            faces = 6;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) && controller.transform.localPosition.y > -GridUnit(gNumber) * 3)
        {
            faces = 7;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 2 && controller.transform.localPosition.y > -GridUnit(gNumber) * 3)
        {
            faces = 8;
        }
        else if (controller.transform.localPosition.x < GridUnit(gNumber) * 3 && controller.transform.localPosition.y > -GridUnit(gNumber) * 3)
        {
            faces = 9;
        }

        //Debug.Log(GridUnit(gNumber));

        if (faces == 1)
            faceMat.SetTextureOffset("_MainTex", new Vector2(-GridUnit(gNumber), GridUnit(gNumber)));
        if (faces == 2)
            faceMat.SetTextureOffset("_MainTex", new Vector2(0, GridUnit(gNumber)));
        if (faces == 3)
            faceMat.SetTextureOffset("_MainTex", new Vector2(GridUnit(gNumber), GridUnit(gNumber)));
        if (faces == 4)
            faceMat.SetTextureOffset("_MainTex", new Vector2(-GridUnit(gNumber), 0));
        if (faces == 5)
            faceMat.SetTextureOffset("_MainTex", new Vector2(0, 0));
        if (faces == 6)
            faceMat.SetTextureOffset("_MainTex", new Vector2(GridUnit(gNumber), 0));
        if (faces == 7)
            faceMat.SetTextureOffset("_MainTex", new Vector2(-GridUnit(gNumber), -GridUnit(gNumber)));
        if (faces == 8)
            faceMat.SetTextureOffset("_MainTex", new Vector2(0, -GridUnit(gNumber)));
        if (faces == 9)
            faceMat.SetTextureOffset("_MainTex", new Vector2(GridUnit(gNumber), -GridUnit(gNumber)));

    }




    private float GridUnit(float num)
    {
        float result = 1 / num;

        return result;
    }

}
