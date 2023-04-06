using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

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
                targetPos.x=targetPos.x+2;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > 80)
            {
                targetPos.x = targetPos.x - 2;
            }
            // front / back
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z < 300)
            {
                targetPos.z = targetPos.z + 2;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > 40)
            {
                targetPos.z = targetPos.z - 2;
            }
            // up / down
            if (Input.GetKeyDown(KeyCode.Space) && transform.position.y > 100)
            {
                targetPos.y = targetPos.y - 2;
            }

            if (Input.GetKeyDown(KeyCode.Escape) && transform.position.y < 300)
            {
                targetPos.y = targetPos.y + 2;
            }

            transform.position = targetPos;
        }

        
    }
}