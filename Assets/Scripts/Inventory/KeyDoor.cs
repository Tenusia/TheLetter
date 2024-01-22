using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keytype;
    [SerializeField] private AudioClip[] openDoorClips;
    [SerializeField] private AudioClip[] closeDoorClips;

    public Key.KeyType GetKeyType() {
        return keytype;
    }

    public void OpenDoor() {
        SoundFXManager.instance.PlayRandomSoundFXCLip(openDoorClips, transform, 1f);
        GetComponent<Animator>().SetTrigger("WithKey");
        //gameObject.SetActive(false);
    }

    public void CloseDoor() {
        SoundFXManager.instance.PlayRandomSoundFXCLip(closeDoorClips, transform, 1f);
        GetComponent<Animator>().SetTrigger("ReturnClose");
    }
}
