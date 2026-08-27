using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null) { return; }

        player.HP -= 15;

        UiManager.instance.ShowNotiText($"Hurt -15 \nHp{player.HP}");

        if (player.HP <= 0)
        {
            player .HP = 0;
            UiManager.instance.ShowNotiText("Game Over");
            Time.timeScale = 0;
            UiManager.instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(87,37,11,255);
    }
}
