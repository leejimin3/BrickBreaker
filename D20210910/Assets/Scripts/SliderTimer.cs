using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderTimer : MonoBehaviour
{
    Slider slTimer;
    // Start is called before the first frame update
    void Start()
    {
        slTimer = GetComponent<Slider>();
        slTimer.value = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (slTimer.value > 0)
        {
            slTimer.value -= Time.deltaTime;
        }
    }
}
