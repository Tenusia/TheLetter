using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Key : MonoBehaviour
{
    [SerializeField] private KeyHolder keyHolder;
    [SerializeField] Transform keyTemplate;
    private Transform container;
    //private Transform keyTemplate;

    private void Awake() {
        container = transform.Find("container");
    }

    private void Start() {
        keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
    }

    private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e) {
        UpdateVisual();
    }

    private void UpdateVisual() {
        foreach (Transform child in container) {
            if (child == keyTemplate) continue;
            Destroy(child.gameObject);
        }
        
        List<Key.KeyType> keyList = keyHolder.GetKeyList();
        for (int i = 0; i < keyList.Count; i++) {
            Key.KeyType keyType = keyList[i];
            Transform keyTransform = Instantiate(keyTemplate, container);
            

            keyTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(130 * i, 0);
            Image keyImage = keyTransform.Find("Image").GetComponent<Image>();
            keyTemplate.gameObject.SetActive(true);

            switch (keyType) {
                default:
                    case Key.KeyType.Red:   keyImage.color = Color.red;     break;
                    case Key.KeyType.Green: keyImage.color = Color.green;   break;
                    case Key.KeyType.Blue:  keyImage.color = Color.blue;    break;
            }
        }
    }
}
