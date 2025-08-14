using UnityEngine;
using UnityEngine.SceneManagement;

namespace Settings.Scriptis
{
    public class CarregarCena : MonoBehaviour
    {
        public string nomeDaCena;

        public void Carregar()
        {
            SceneManager.LoadScene(nomeDaCena);
        }
    }
}
