using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Suma : MonoBehaviour
{
    private int dato1;
    private int dato2;
    private int operaci�n;
    private int miNumero;
    public TMP_Text muestraSuma;
    public TMP_Text respuesta;
    public TMP_InputField cassie;
    public TMP_Text titulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Numeros()
    {
        dato1= Random.Range(0, 30);
        dato2= Random.Range(0, 30);
        operaci�n = dato1 + dato2;
        muestraSuma.text = dato1 + " + " + dato2;
    }
    public void Operaci�n()
    {
        int.TryParse(cassie.text, out miNumero);
        if(miNumero == operaci�n) 
        {
            respuesta.text = "�Tu respuesta fue correcta! :D";
        }
        else
        {
            respuesta.text = "Intentalo de nuevo, perderor >:D";
        }
    }
}
