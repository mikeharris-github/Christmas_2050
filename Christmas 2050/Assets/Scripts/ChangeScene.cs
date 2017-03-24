using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void GoToScene(string sceneName) {
        Debug.Log("Loading Scene " + sceneName);
		SceneManager.LoadScene (sceneName);
        print("test");
	}
}
