using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class TowerPlace : MonoBehaviour
{
    public GameObject NormalTower;
    public GameObject Tower;
    private Camera cam => Camera.main.GetComponent<Camera>();
    Vector3 mousepos => new Vector3((Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).x)) + 0.5f, (Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).y)) + 0.5f, 0);

    void Start()
    {

    }


    void LateUpdate()
    {
        if (Tower != null)
            Tower.transform.position = mousepos;
        if (Input.GetMouseButtonDown(0))
        {
            Tower = null;
            if (GameObject.FindObjectsOfType<GameObject>().Any(c => c.tag == "Tower" && c == Tower))
            {

            }

        }
    }

    public void TowerPlacee()
    {
        Tower
            = Instantiate(NormalTower, mousepos, transform.rotation);

    }

}