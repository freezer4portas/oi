using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public string jogo;
   
   public void Start()
   {
    
   }
   void Update()
   {
     
   }

   public void caregarCena()
   {
       SceneManager.LoadScene("jogo");
   }
}