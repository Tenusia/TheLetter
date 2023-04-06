using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    //Add BOOL to check if have key yes/no hasKey
    [SerializeField] int moveSpeed = 20;
    bool OpenSesame = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("Press ctrl");
            OpenSesame = true;
        }

        if (OpenSesame)
        {
            transform.position = transform.position + new Vector3(0, 0, moveSpeed * Time.deltaTime);
            Destroy(gameObject, 4f);
        }
    }
}
