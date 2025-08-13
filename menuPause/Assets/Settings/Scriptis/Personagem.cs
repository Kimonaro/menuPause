using UnityEngine;

public class Personagem : MonoBehaviour
{
    private int vidas;
    private int energia;

    public void setVida(int vidas)
    {
        this.vidas = vidas;
    }

    public int getVidas()
    {
        return this.vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return this.energia;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
