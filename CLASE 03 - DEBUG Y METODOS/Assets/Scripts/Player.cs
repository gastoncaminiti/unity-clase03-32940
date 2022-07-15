using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    //Creamos propiedades usando public para editar sus valores desde el editor.
    public float speed = 5.5f;

    public int hp = 3;

    public string namePlayer = "Mr. Cube";

    public int attack = 3;

    public Vector3 dir;

    void Start()
    {
        //Con Debug.Log mostramos valores en la consola.
        Debug.Log(hp);
        Debug.Log("EJECUTANDO EL START");
        //Llamada al método Damage con diferentes parámetros.
        Damage(5);
        Damage(attack);
        //Definimos un posicion inicial diferente.
        //transform.position += Vector3.forward * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //Tambien podemos llamar a un metodo en el update pero este se ejecutara en cada frame.
        //Damage();
        Debug.Log("EJECUTANDO EL UPDATE");
        //Un método de movimiento con parámetros nos permite movernos en diferentes direcciones.
        MovePlayer(Vector3.forward);
        MovePlayer(Vector3.right);
    }
    //La declaración de métodos personalizado, generalmente en unity se escriben abajo de update.
    private void MovePlayer(Vector3 direccion)
    {
        transform.position += direccion * speed * Time.deltaTime;
    }
    
    void Damage(int newAttack)
    {

        hp = hp - newAttack;
    }
}
