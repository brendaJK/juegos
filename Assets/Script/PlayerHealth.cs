using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public RectTransform heartUI;
    private float heartSize = 16f;
    // public TextMeshProUGUI textLifeCount;
    private Explode explode;
    // Start is called before the first frame update
    void Start()
    {
        explode = GetComponent<Explode>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            health = health - 1;
            if (health == 0)
            {
                Destroy(gameObject);
                explode.OnExplode();
            }
             heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);
             //textLifeCount.text = health.ToString();
        }
        if (collision.tag == "Life")
        {
            Destroy(collision.gameObject);
            health = health + 1;
            if (health >= 3)
            {
                health = 3;
            }
            heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);
            // textLifeCount.text = health.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}