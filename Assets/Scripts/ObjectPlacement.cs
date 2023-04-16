using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MODI.MissionPlan
{
    public class ObjectPlacement : MonoBehaviour
    {
        [SerializeField] LayerMask terrian;
         MeshRenderer materials;

        Camera cam;
        public bool isplaced;
        public bool isRotated;
        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;
            materials = GetComponent<MeshRenderer>();
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
            else
            {
                if (!isRotated)
                {
                    transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 50f);
                }

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    isRotated=true;
                }
            }
            if (isplaced && isRotated)
            {
                SystemManager.instance.activateMenu();
            }
            else
            {
                SystemManager.instance.decativateMenu();
            }
        }


        void PlaceObject()
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitdata;
            if (Physics.Raycast(ray, out hitdata , int.MaxValue , terrian))
            {
                transform.position = hitdata.point;
            }
        }


        private void OnMouseDown()
        {
            if (!isplaced) return;
            if (!isRotated) return;
          
            SystemManager.instance.EditingPanel(gameObject);
        }

        private void OnMouseOver()
        {
            if (!isplaced) return;
            if (!isRotated) return;
            materials.material.EnableKeyword("_EMISSION");
            
        }


        private void OnMouseExit()
        {
            if (!isplaced) return;
            if (!isRotated) return;
            materials.material.DisableKeyword("_EMISSION");
            
        }

    }

}
