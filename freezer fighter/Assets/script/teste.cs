using UnityEngine;

public class teste : MonoBehaviour
{
    Personagem personagem = new Personagem();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        personagem.AtribuirForca_Ataque(10);
        Debug.Log(personagem.Forca_Ataque() + " ataque");
        
        personagem.AtribuirEnergia(100);
        Debug.Log(personagem.Energia() + " de energia");
        
        personagem.AtribuirVelocidade(10);
        Debug.Log(personagem.Velocidade() + " de velocidade");
        
        personagem.AtribuirForca_do_pulo(10);
        Debug.Log(personagem.Forca_do_pulo() + " forca de pulo");
        
        personagem.AtribuitNumero_de_maos(2);
        Debug.Log(personagem.Numero_de_maos() + " maos");
        
        personagem.AtribuitNumero_de_pes(2);
        Debug.Log(personagem.Numero_de_pes() + " pes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
