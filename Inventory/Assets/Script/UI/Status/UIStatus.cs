using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField]
    Stats stats;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        GameManager.OnPlayerDataChanged += stats.UpdateStatus;
    }
    void OnDisable()
    {
        GameManager.OnPlayerDataChanged -= stats.UpdateStatus;
    }
}
