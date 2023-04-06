using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MODI.MissionPlan
{
    public class ObjectPlacement : MonoBehaviour
    {
        Camera cam;
        bool isplaced;
        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                isplaced = true;

            }

            if (!isplaced)
            {
                PlaceObject();
            }

        }


        void PlaceObject()
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitdata;
            if (Physics.Raycast(ray, out hitdata))
            {
                transform.position = hitdata.point;
            }
        }



    }

}
