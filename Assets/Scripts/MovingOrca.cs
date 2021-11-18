using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOrca : MonoBehaviour
{
    public GameObject bigOrcaSwimming;
    Vector3 currentAngles;
    Vector3 oldAngles;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        currentAngles = transform.rotation.eulerAngles; 
        float zPos = (float)bigOrcaSwimming.transform.position.z;
        if(zPos < 2.25){
            bigOrcaSwimming.transform.position = new Vector3(4f, 1.75f, zPos-0.2f ); 
        }

        /*
        //hitting the back wall end point 
        if(bigOrcaSwimming.transform.position.z <= -2.25){
            //rotate 
            bigOrcaSwimming.transform.eulerAngles = new Vector3(0, 180, 0); 

            //move towrds the front wall
            bigOrcaSwimming.transform.position = new Vector3(4f, 1.75f, -2.0f); 
        }

        //hitting front wall
        if(bigOrcaSwimming.transform.position.z >= 1.75){
            //rotate 
            bigOrcaSwimming.transform.eulerAngles = new Vector3(0, 0, 0); 

            //move towards the back wall 
            bigOrcaSwimming.transform.position = new Vector3(4f, 1.75f, 1.25f);
        }
        
        if(bigOrcaSwimming.transform.position.z < 1.25 && bigOrcaSwimming.transform.position.z > -2.25){
            double pos = bigOrcaSwimming.transform.position.z;
            //float newZ = (Convert.ToFloat(bigOrcaSwimming.transform.position.z) )- .5; 
        }
        */
    }//end update       
}//end class

