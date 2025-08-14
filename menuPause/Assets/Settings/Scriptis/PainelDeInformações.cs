using UnityEngine;
using UnityEngine.UI;

namespace Settings.Scriptis
{
    public class PainelDeInformações : MonoBehaviour
    {
        public Personagem personagem;

        public Slider sliderVidas;
        public Slider sliderEnergia;
    
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
            sliderVidas.minValue = 0;
            sliderVidas.maxValue = personagem.getVidas();
        
        
            sliderEnergia.minValue = 0;
            sliderEnergia.maxValue = personagem.getEnergia();
        }

        // Update is called once per frame
        void Update()
        {
            sliderVidas.value = personagem.getVidas();
            sliderEnergia.value = personagem.getEnergia();
        }
    }
}
