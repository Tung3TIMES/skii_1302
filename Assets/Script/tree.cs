using UnityEngine;

public class tree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        if (player == null)

            return;

        player.HP -= 15;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = new Color32(255, 255, 255, 255);
    }

}
