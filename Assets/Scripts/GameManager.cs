using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Material cubeMaterial;
    [SerializeField] GameObject panel;
    [SerializeField] Button deactivateButton;

    private void Start()
    {
        panel.SetActive(false);
        deactivateButton.gameObject.SetActive(false);
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

    public void CubeMaterial(Sprite materialSprite)
    {
        cubeMaterial.mainTexture = materialSprite.texture;
    }
}
