using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSceneManager : MonoBehaviour {


	/// 「始める」ボタンタップ
	public void OnStartBtnTap(){
		SceneManager.LoadScene( "Game" );
	}
}
