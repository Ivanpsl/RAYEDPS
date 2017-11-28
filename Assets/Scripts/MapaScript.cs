using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{

    public class MapaScript : MonoBehaviour
    {


        public GameObject suelo;

        public TipoTerreno[] tiposTerreno;
        int[,] matrizSuelos;
        

        public int maxX = 10;
        public int maxY = 10;

        void Start()
        {
            matrizSuelos = new int[maxX, maxY];

            for (int i = 0; i < maxY; i++)
                for (int x = 0; x < maxX; x++)
                {
                    matrizSuelos[x, i] = 0;
                }
            matrizSuelos[5, 5] = 2;
            matrizSuelos[6, 5] = 2;

            GenerarVisualizacionMapa();
        }

        void GenerarVisualizacionMapa()
        {
            for(int x=0; x<maxX; x++)
                for(int y=0; y < maxY; y++)
                {
                
                    GameObject auxSuelo= Instantiate(suelo, new Vector3(x, y, 0), Quaternion.identity);
                    auxSuelo.GetComponent<SueloScript>().AsignarX(x).AsignarY(y).Transformar(matrizSuelos[x, y]);


                }
        }

    }


}