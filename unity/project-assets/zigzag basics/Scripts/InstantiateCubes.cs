using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public Transform prefab;
    int counter = 0;

    /*
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(-15 + i * 3.0F, 0, 0), Quaternion.identity);
        }
    }
   */


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            Instantiate(prefab, new Vector3(-15 + counter * 3.0F, 0, 0), Quaternion.identity);
            counter++;
            */
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            InvokeRepeating("CreateNewCube", 1f, 1f);
        }
    }


    public void Start()
    {
        InvokeRepeating("CreateNewCube", 3f, 1f);
    }

    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(-10 + counter * 3.0F, 0, 0), Quaternion.identity);
        counter++;
        /*
        if(counter >= 20)
        {
            CancelInvoke();
        }
        */
    }
}
