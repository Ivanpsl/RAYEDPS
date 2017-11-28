using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class LocalizationManager : MonoBehaviour {

	public static LocalizationManager instance;

	private Dictionary<string, string> textoLocalizado;
	private bool isReady=false;

	private string textoNoEncontrado= "Localized text"; 
	/**
	 * Singleton.
	 * Hacemos que nunca se borre al cambiar entre escenas y solo exista uno
	 * **/
	void Awake () {
		if (instance == null) {
			instance = this;
<<<<<<< HEAD
			//CargarTextoLocalizado ("leng_en.json");
=======
			CargarTextoLocalizado ("leng_es.json");
>>>>>>> Try
		} else if (instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
	}

	/** Funcion llamada al seleccionar el idioma 
	 * string fichero: nombre del fichero con el idioma
	 * */
	public void CargarTextoLocalizado(string fichero){
		textoLocalizado = new Dictionary<string,string> ();

		//obtendremos la ruta en la que aparecera el fichero 
		string rutaFichero = Path.Combine (Application.streamingAssetsPath, fichero);

		//si el fichero existe 
		if (File.Exists (rutaFichero)) {
			//leemos el fichero entero
			string datosJson = File.ReadAllText (rutaFichero);

			//modelamos el objeto LocalizationData a partir de los datos JSON mediante la libreria JsonUtility
			LocalizationData datosCargados = JsonUtility.FromJson<LocalizationData> (datosJson);


			for(int i=0; i< datosCargados.items.Length; i++){
				textoLocalizado.Add (datosCargados.items [i].key, datosCargados.items [i].value);
			}

			Debug.Log ("Datos de idioma cargados, el diccionario contiene " + textoLocalizado.Count + " datos");

		} else {
			
			Debug.LogError ("Fichero no encontrado");
		}

		isReady = true;
	}

	public bool GetIsReady(){
		return isReady;
	}

	public string GetTextoConcretoLocalizado(string key){
		string resultado = textoNoEncontrado;
		if (textoLocalizado.ContainsKey (key)) {
			resultado = textoLocalizado [key];
		}
		return resultado;
	}
}
