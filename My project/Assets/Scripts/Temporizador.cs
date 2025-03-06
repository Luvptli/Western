using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{

    [SerializeField]
    float time = 60;

    [SerializeField]
    TextMeshProUGUI labelTime;

    [SerializeField]
    bool estaJugando;

    [SerializeField]
    GameObject pantallaInicial;

    [SerializeField]
    GameObject endScreen;

    void Start()
    {
        endScreen.SetActive(false);
    }

        void Update()
    {
         if (pantallaInicial.activeSelf == false)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                labelTime.text = Mathf.FloorToInt(time).ToString();

            }

            else if (Time.deltaTime <= 0)
            {
                time = 0;
                labelTime.text = time.ToString();
                endScreen.SetActive(true);
            }
        }
         if (endScreen.activeSelf==true)
        {
            RestartButton();
        }
    }
    public void RestartButton()
    {
        endScreen.SetActive(false);
    }
}
