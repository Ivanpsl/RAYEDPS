using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{
    public class BasePocion : ScriptableObject, ICarta
    {

        public string nombre;
        public string descripcion;
        public int objID;
        public TipoPoti tipo;
        public int incremento;
        public Sprite img;

    }

    public enum TipoPoti
    {
        CURACION,
        MANA,

    }

}