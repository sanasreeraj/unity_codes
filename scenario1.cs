using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenario1 : MonoBehaviour
{
    //Creating References
    public GameObject A;
    public GameObject B;
    void Start()
    {
        Debug.Log(A.name+ "Id: "+ A.GetInstanceID());
        Debug.Log(B.name+ "Id: "+ B.GetInstanceID());

        //Swapping each object with other
        (A.name, B.name) = (B.name, A.name);
        
        Debug.Log(A.name+ "Id: "+ A.GetInstanceID());
        Debug.Log(B.name+ "Id: "+ B.GetInstanceID());
    }
    
}