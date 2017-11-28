using UnityEngine;
using UnityEditor;


/// <summary>
/// Fichero dedicado a los enum y metodos para el uso de los dados
/// </summary>
/// 

namespace RAYEDPS {

    #region Types

    public struct DiceType
        {
            enum TYPE { BOOL_TYPE, NUM_TYPE };

        }
    #endregion


    #region Utils

    public class DiceUtils
		{

        /// <summary>
        ///      
        /// </summary>
        /// <typeparam name="T"> Tipo de dado: Especial(bool) / Normal(int) </typeparam>
        /// <typeparam name="U"> Tipo de resultado: bool o int 
        /// </typeparam>
        /// <param name="dice">Dado lanzado </param>
        /// <returns></returns>
        /// 


	    public static DiceResult<T,U> Throw<T,U>(T dice) where T: BaseDice<U> 
	    {
				   int face = Random.Range(1, 5);
                   return new DiceResult<T, U>(dice, dice.GetFace(face));
	    }

    }
    #endregion
}