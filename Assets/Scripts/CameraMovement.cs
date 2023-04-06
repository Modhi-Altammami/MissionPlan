using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

namespace MODI.MissionPlan
{
    public class CameraMovement : MonoBehaviour
    {
        Vector3 targetPos;
        Vector2 angle;
        private void Start()
        {
            targetPos = transform.position;
        }
        // Update is called once per frame
        void Update()
        {
            RotateCamera();
            MoveCamera();
        }

        void MoveCamera()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 530)
            {
                targetPos.x++;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > 80)
            {
                targetPos.x--;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < 300)
            {
                targetPos.y++;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > 40)
            {
                targetPos.y--;
            }

            transform.position = targetPos;
        }

        void RotateCamera()
        {
            angle.x += Input.GetAxis("Mouse X");
            angle.y += Input.GetAxis("Mouse Y");

            transform.localRotation = Quaternion.Euler(-angle.y, angle.x, 0);
        }
    }
}