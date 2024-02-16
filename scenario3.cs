using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenario3 : MonoBehaviour
{
    public List<GameObject> Objects;
    void Start()
    {
        //Printing their own names
        foreach (var obj in Objects)
        {
            Debug.Log(obj.GetInstanceID()+" -> "+ obj.name);
        }

        //Swap name of cube and plane
        (Objects[0].name, Objects[2].name) = (Objects[2].name, Objects[0].name);
        
        //Swap name of plane and sphere
        (Objects[2].name, Objects[1].name) = (Objects[1].name, Objects[2].name);
        
        //Swap name of cube and plane
        (Objects[0].name, Objects[2].name) = (Objects[2].name, Objects[0].name);
        
        //Swap name of sphere and cube
        (Objects[1].name, Objects[0].name) = (Objects[0].name, Objects[1].name);
        
        //Printing their own names
        foreach (var obj in Objects)
        {
            Debug.Log(obj.GetInstanceID()+" - "+ obj.name);
        }

    }
}