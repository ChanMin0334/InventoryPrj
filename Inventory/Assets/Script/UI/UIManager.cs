using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    UIMainMenu uiMainMenu;

    [SerializeField]
    UIStatus uiStatus;

    [SerializeField]
    UIInventory uiInventory;

    [SerializeField]
    GameObject btnCanvas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMainmenu()
    {
        btnCanvas.SetActive(true);
        uiStatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        btnCanvas.SetActive(false);
        uiStatus.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
    }

    public void OpenInventory()
    {
        btnCanvas.SetActive(false);
        uiStatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(true);
    }
}
