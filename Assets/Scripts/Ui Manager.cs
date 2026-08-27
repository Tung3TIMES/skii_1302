using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UiManager : MonoBehaviour  
{
    [SerializeField] private TMP_Text notiText;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private Player player;

    public static UiManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string text)
    {
        notiText.text = text;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 86.96f, -85.35f);
        player.HP = 100;

        player.Point = 0;

        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero; 
            rb.angularVelocity = Vector3.zero;
        }

        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);

        Flag[] flags = Object.FindObjectsByType<Flag>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (Flag f in flags)
        {
            f.gameObject.SetActive(true);
        }
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}
