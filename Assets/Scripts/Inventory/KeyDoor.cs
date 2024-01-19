using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keytype;

    public Key.KeyType GetKeyType() {
        return keytype;
    }

    public void OpenDoor() {
        GetComponent<Animator>().SetTrigger("WithKey");
        //gameObject.SetActive(false);
    }

    public void CloseDoor() {
        GetComponent<Animator>().SetTrigger("ReturnClose");
    }
}
