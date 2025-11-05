using UnityEditor.Build.Content;
using UnityEngine;

public class slime : MonoBehaviour
{
    public Gamemanager gamemanager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))

        {
            gamemanager.PerderV(1);
            gamemanager.PerderP(5);
        }

    }
}
