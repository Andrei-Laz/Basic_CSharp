using UnityEngine;
using UnityEngine.UI;

namespace P1_AdventurerBag
{
    public class BackpackBar : MonoBehaviour
    {

        public Slider slider;
        

        public void SetLoad(float load)
        {
            slider.value = load;
        }

        public void SetMaxLoad(float maxLoad)
        {
            slider.value = 0f;
            slider.maxValue = maxLoad;
        }
    }
}