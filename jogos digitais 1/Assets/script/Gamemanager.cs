using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int pontos = 0; //crio os pontos e as vidas
    public int vidas = 3;

    public void Addpontos(int qtd)
    {
        pontos += qtd;

        Debug.Log("pontos: " + pontos);
        if (pontos < 0)
        {

            pontos = 0;

        }


    }
    public void perdervidas(int vida)
    {
        vidas -= vida;
        Debug.Log("vidas: " + vidas);

        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<Player>().reiniciarposicao();

        if (vidas <= 0)
        {

            vidas = 0;
            Time.timeScale = 0;

            Debug.Log("gamer-over");

        }

        
    }

}
