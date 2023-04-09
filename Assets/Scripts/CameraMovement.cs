using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MODI.MissionPlan
{
    public class CameraMovement : MonoBehaviour
    {


        Vector3 targetPos;
        private void Start()
        {
            targetPos = transform.position;
        }
        // Update is called once per frame
        void Update()
        {
            MoveCamera();
        }

        void MoveCamera()
        {
            //left / right
            if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 530)
            {
                targetPos.x=targetPos.x+5;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > 80)
            {
                targetPos.x = targetPos.x - 5;
            }
            // front / back
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z < 300)
            {
                targetPos.z = targetPos.z + 5;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > 40)
            {
                targetPos.z = targetPos.z - 5;
            }
            // up / down

            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                targetPos.y = targetPos.y + 5;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                targetPos.y = targetPos.y - 5;
            }


            Vector3.MoveTowards(transform.position, targetPos, float.MaxValue);
            transform.position = targetPos;
        }


      
    
        }
        
    }
