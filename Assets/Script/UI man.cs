using UnityEngine;
using TMPro;
public class UIman : MonoBehaviour
{
    {
    [SerializeField]
    private TMP_Text NotiText;

    public static UIman instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
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

    public void Shownotification(string message)

    {
        NotiText.text = message; 
    }


}
