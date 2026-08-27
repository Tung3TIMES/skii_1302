using UnityEngine;

public class Flag : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;
        UiManager.instance.ShowNotiText($"+10 points\nPoints: {player.Point}");
        gameObject.SetActive(false);
    }
}
