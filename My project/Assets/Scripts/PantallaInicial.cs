using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PantallaInicial : MonoBehaviour
{
    [SerializeField]
    bool pantallaInicial;

    [SerializeField]
    GameObject start;

    // Start is called before the first frame update
    void Start()
    {  
        start.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (pantallaInicial == true)
        {
            BeginnButton();
        }
    }

    public void BeginnButton()
    {
        start.SetActive(false);
    }
}
