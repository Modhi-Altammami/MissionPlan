using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MODI.MissionPlan
{
    public class ObjectPlacement : MonoBehaviour
    {
        [SerializeField] LayerMask terrian;
        
        Camera cam;
        public bool isplaced;
        [SerializeField]List<Material> materials;
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
            if (Physics.Raycast(ray, out hitdata , int.MaxValue , terrian))
            {
                transform.position = hitdata.point;
            }
        }


        private void OnMouseDown()
        {
            if (!isplaced) return;
            SystemManager.instance.EditingPanel(gameObject);
        }

        private void OnMouseOver()
        {
            foreach(Material m in materials)
            {
                m.EnableKeyword("_EMISSION");
            }
        }


        private void OnMouseExit()
        {
            foreach (Material m in materials)
            {
                m.DisableKeyword("_EMISSION");
            }
        }

    }

}
