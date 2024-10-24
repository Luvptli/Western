using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    [SerializeField]
    float time = 60;

    [SerializeField]
    TextMeshProUGUI labelTime;

    [SerializeField]
    bool pantallaInicial;

    [SerializeField]
    bool juegoIniciado;

    [SerializeField]
    GameObject start;

    [SerializeField]
    GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        endScreen.SetActive(false);
        start.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (pantallaInicial==true)
        {
            BeginButton();
        }
        else if (juegoIniciado == true)
        {
            
        }
    }

    public void BeginButton()
    {
        start.SetActive(false);
        time -= Time.deltaTime;
        labelTime.text = time.ToString();
        float segundos = Mathf.FloorToInt(time % 60);
        labelTime.text = string.Format("00", segundos);
        juegoIniciado = true;
    }
}
