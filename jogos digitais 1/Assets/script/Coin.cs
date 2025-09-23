using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int point = 0;//crio a variael ponto
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//comparo ela com o player
        {
            Debug.Log("colidiu");  //informo que houve colisão
        }
    }
}
