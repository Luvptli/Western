using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pantallas : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaInicial;

    // Start is called before the first frame update
    void Start()
    {
        pantallaInicial.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (pantallaInicial.activeSelf)
        {
            BeginButton();
        }
        else
        {
            
        }
    }

    public void BeginButton()
    {
        pantallaInicial.SetActive (false);
    }


}
