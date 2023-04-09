using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MODI.MissionPlan
{
    public class SystemManager : MonoBehaviour
    {

        [SerializeField] Transform parent;
        [SerializeField] GameObject editPanel;
        [SerializeField] TextMeshProUGUI unitName;
        [SerializeField] TextMeshProUGUI unitCoordinates;
        [SerializeField] TextMeshProUGUI unitAltitude;
        public static SystemManager instance;
        GameObject currentObj;
        char upArrow = '↑';
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void CreateObject(GameObject obj)
        {
            Instantiate(obj, parent);
        }

        public void EditingPanel(GameObject obj)
        {
            currentObj = obj;
            unitName.text = obj.name;
            unitCoordinates.text="X:"+ System.Math.Round(obj.gameObject.transform.position.x,2)+
                ", Z:"+ System.Math.Round(obj.gameObject.transform.position.z, 2);
            unitAltitude.text = upArrow +" "+ System.Math.Round(obj.gameObject.transform.position.y, 2);
            editPanel.SetActive(true);
        }


        public void Delete()
        {
            Destroy(currentObj);
            currentObj = null;
            editPanel.SetActive(false);
        }

        public void Reposition()
        {
            currentObj.GetComponent<ObjectPlacement>().isplaced = false;
            currentObj = null;
            editPanel.SetActive(false);

        }
        public void Close()
        {
            currentObj = null;
            editPanel.SetActive(false);
        }
    }
}
