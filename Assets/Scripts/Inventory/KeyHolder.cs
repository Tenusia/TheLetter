using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;
    [SerializeField] private AudioClip itemPickUpClip;

    private List<Key.KeyType> keyList;

    private void Awake() {
        keyList = new List<Key.KeyType>();
    }

    public List<Key.KeyType> GetKeyList() {
        return keyList;
    }

    public void AddKey(Key.KeyType keyType) {
        SoundFXManager.instance.PlaySoundFXCLip(itemPickUpClip, transform, 1f);
        keyList.Add(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKey(Key.KeyType keyType) {
        keyList.Remove(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ContainsKey(Key.KeyType keyType) {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider other) {
        Key key = other.GetComponent<Key>();
        if (key != null) {
            Destroy(key.gameObject);
            AddKey(key.GetKeyType());
        }

        KeyDoor keyDoor = other.GetComponent<KeyDoor>();
        if (keyDoor !=null) {
            if (ContainsKey(keyDoor.GetKeyType())) {
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor();
            }
            else {
                keyDoor.GetComponent<Animator>().SetTrigger("WithoutKey");
            }
        }
    }
}
