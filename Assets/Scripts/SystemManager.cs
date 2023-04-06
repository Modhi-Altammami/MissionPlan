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
        public static SystemManager instance;
        GameObject currentObj;

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
            editPanel.GetComponentInChildren<TextMeshProUGUI>().text = obj.name;
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
        }
        public void Close()
        {
            currentObj = null;
            editPanel.SetActive(false);
        }
    }
}
