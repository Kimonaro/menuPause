using UnityEngine;

public class Jogador : Personagem
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(getVelocidade()* Time.deltaTime, 0, 0) ;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade()* Time.deltaTime, 0, 0) ;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade()* Time.deltaTime, 0) ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade()* Time.deltaTime, 0) ;
        }
    }
}
