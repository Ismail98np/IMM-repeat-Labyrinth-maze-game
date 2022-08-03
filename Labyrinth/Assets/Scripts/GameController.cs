using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController i;

    public Sprite emptyKeySprite;
    public Sprite keySprite;

    public Image key1;
    public Image key2;
    public Image key3;

    public List<GameObject> keyLocations = new List<GameObject>();

    public bool allKeysCollected;

    private void Awake()
    {
        i = this;

        ActivateKeyLocations();
    }

    void ActivateKeyLocations()
    {
        int randomNumber = Random.Range(0, keyLocations.Count);
        Transform keyLocation1 = keyLocations[randomNumber].transform;
        keyLocation1.gameObject.SetActive(true);
        keyLocations.Remove(keyLocation1.gameObject);

        randomNumber = Random.Range(0, keyLocations.Count);
        Transform keyLocation2 = keyLocations[randomNumber].transform;
        keyLocation2.gameObject.SetActive(true);
        keyLocations.Remove(keyLocation2.gameObject);

        randomNumber = Random.Range(0, keyLocations.Count);
        Transform keyLocation3 = keyLocations[randomNumber].transform;
        keyLocation3.gameObject.SetActive(true);
        keyLocations.Remove(keyLocation3.gameObject);
    }

    public void UpdateKeys()
    {
        if (!allKeysCollected)
        {
            if (key1.sprite == emptyKeySprite)
            {
                key1.sprite = keySprite;
                return;
            }

            if (key1.sprite == keySprite && key2.sprite == emptyKeySprite)
            {
                key2.sprite = keySprite;
                return;
            }

            if (key2.sprite == keySprite && key3.sprite == emptyKeySprite)
            {
                key3.sprite = keySprite;
                allKeysCollected = true;
                return;
            }
        }
    }
}