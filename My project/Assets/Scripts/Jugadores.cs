using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jugadores : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaInicial;

    [SerializeField]
    TextMeshProUGUI labelDinero;

    [SerializeField]
    int dinero = 0;

    [SerializeField]
    GameObject badGuy;

    [SerializeField]
    bool estoyJugando;
    // Start is called before the first frame update
    void Start()
    {
        badGuy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (estoyJugando ==true)
        {
            OnClickBadGuy();
        }



    }

    public void OnClickBadGuy()
    {

        dinero += 500;
        labelDinero.text = dinero.ToString();
    }
}
