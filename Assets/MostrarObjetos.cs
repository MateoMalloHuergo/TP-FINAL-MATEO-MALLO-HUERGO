using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarObjetos : MonoBehaviour
{
    public GameObject[] objetos;
    int obj = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[obj].SetActive(false);
            obj--;
            if (obj < 0)
            {
                obj = 24;
            }
            objetos[obj].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objetos[obj].SetActive(false);
            obj++;
            if (obj > 24)
            {
                obj = 0;
            }
            objetos[obj].SetActive(true);
        }
    }
    
}
