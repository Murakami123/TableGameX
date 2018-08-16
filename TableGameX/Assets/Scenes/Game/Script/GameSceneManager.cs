using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

	/// 戻るボタンを押したとき
	public void OnReturnBtnTap(){
		SceneManager.LoadScene( "Title" );
	}

}



