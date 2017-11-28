using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RAYEDPS {
    public class SueloScript : MonoBehaviour {

        private TipoTerreno tipo;

        private GameObject mapa;
        private GameObject objetoMostrado;
        int x;
        int y;

        public void Start()
        {
            mapa = GameObject.FindGameObjectWithTag("Mapa");
         //  tipo = mapa.GetComponent<MapaScript>().tiposTerreno[0];
        
        }
    
        public SueloScript AsignarX(int x)
        {
            this.x = x;
            return this;

        }
        public SueloScript AsignarY(int y)
        {
            this.y = y;
            return this;

        }
        public SueloScript Mostrar()
        {
            objetoMostrado = Instantiate(tipo.prefabVista, new Vector3(x, y, 0), Quaternion.identity);
            return this;

        }

        public SueloScript Transformar(int t)
        {
            tipo = mapa.GetComponent<MapaScript>().tiposTerreno[t];
            Destroy(objetoMostrado);
            return Mostrar();

        }
    }
}
