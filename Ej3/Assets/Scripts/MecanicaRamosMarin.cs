using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaRamosMarin : MonoBehaviour
{
    public int lifeOfPlayer = 100;
    int heal = 25;
    int damage = 15;
    public float directionOfPlayerX = 0;
    public float directionOfPlayerY = 0;
    public float directionOfPlayerZ = 0;

    void Start()
    {
        //llamamos a los metodos que permiten modificar la vida, tanto sumar, como restar la misma
        lifeOfPlayer = addLife(lifeOfPlayer, heal);
        lifeOfPlayer = minusLife(lifeOfPlayer, damage);

    }

    void Update()
    {
        //llamamos al metodo en el que definimos velocidad y direccion a la par
        movementPlayer(directionOfPlayerX, directionOfPlayerY, directionOfPlayerZ);
    }

    public int minusLife(int life, int damage)
    {
        //le resta vida al personaje
        life -= damage;
        return life;
    }

    public int addLife(int life, int heal)
    {
        //le suma vida al personaje
        life += heal;
        return life;
    }

    public void movementPlayer(float directionX, float directionY,float directionZ)
    {
        //con este metodo podemos controlar la velocidad a la que se mueva en el eje que elijamos,
        //y este se movera a tantos metros en un frame por segundo,
        //asi que a su vez podriamos controlar la velocidad y direccion que querramos que vaya en el juego
        transform.position += new Vector3(directionX, directionY, directionZ);

    }
}