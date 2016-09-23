using UnityEngine;
using System.Collections;

public class Manejador : MonoBehaviour
{
    Animator Animaciones;
    // Use this for initialization
    void Start()
    {
        Animaciones = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Animaciones.SetInteger("Stado", 1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Animaciones.SetInteger("Stado", 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Animaciones.SetInteger("Stado", 2);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Animaciones.SetInteger("Stado", 0);

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Animaciones.SetInteger("Stado", 3);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Animaciones.SetInteger("Stado", 0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Animaciones.SetInteger("Stado", 4);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Animaciones.SetInteger("Stado", 0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Animaciones.SetInteger("Stado", 5);
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Animaciones.SetInteger("Stado", 0);

        }
    }
}

