using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Material cubeMaterial;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject panel;
    [SerializeField] Button deactivateButton;

    private void Start()
    {
        panel.SetActive(false);
        deactivateButton.gameObject.SetActive(false);
    }

    public void ChangeToPatrick1()
    {
        ChangeTexture(0);
    }

    public void ChangeToPatrick2()
    {
        ChangeTexture(1);
    }

    public void ChangeToPatrick3()
    {
        ChangeTexture(2);
    }

    public void ActivatePanel()
    {
        panel.SetActive(true);
        deactivateButton.gameObject.SetActive(true);
    }

    public void DeactivatePanel()
    {
        panel.SetActive(false);
        deactivateButton.gameObject.SetActive(false);
    }

    void ChangeTexture(int index)
    {
        cubeMaterial.mainTexture = sprites[index].texture;
    }
}
