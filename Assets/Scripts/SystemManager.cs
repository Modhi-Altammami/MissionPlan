using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{

    [SerializeField] Transform parent;
   

    public void CreateObject(GameObject obj)
    {
        Instantiate(obj, parent);
    }
}
