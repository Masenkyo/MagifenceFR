using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Globalization;
using Mono.Cecil.Cil;

public class TowerPlace : MonoBehaviour
{
    public GameObject NormalTower;
    public GameObject Tower;
    bool CanPlace = true;
    private GameObject Variable;
    private Camera cam => Camera.main.GetComponent<Camera>();
    Vector3 mousepos => new Vector3((Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).x)) + 0.5f, (Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).y)) + 0.5f, 0);

    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Tower"))
        {
            
            
            CanPlace = false;
            
        }       
    }
    void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Tower"))
        {
            
            CanPlace = true;
            
        }
    }

    void Update()
    {
        if (Tower != null)
            Tower.transform.position = mousepos;
        if (Input.GetMouseButtonDown(0))
        {
            if (CanPlace == true)
            {
                Debug.Log("I Believe");
                GetComponent<Collider2D>().isTrigger = false;
                Tower = null;
            }
            if (CanPlace == false)
            {
                Debug.Log("hi");
                
            }
        }
    }

    public void TowerPlacee()
    {
        
        Tower
            = Instantiate(NormalTower, mousepos, transform.rotation);

    }
    
}