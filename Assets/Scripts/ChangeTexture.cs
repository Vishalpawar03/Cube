using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    private Sprite selectedSprite;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    public void ChangeTextureOfCube()
    {
        Image image = GetComponent<Image>();
        selectedSprite = image.sprite;
        gameManager.CubeMaterial(selectedSprite);
    }
}
