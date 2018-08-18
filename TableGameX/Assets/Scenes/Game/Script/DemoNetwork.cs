using UnityEngine;

public class DemoNetwork : MonoBehaviour
{
    void Start() {
        // Photonに接続する(引数でゲームのバージョンを指定できる)
        PhotonNetwork.ConnectUsingSettings(null);
    }
 
    // ロビーに入ると呼ばれる
    void OnJoinedLobby() {
        Debug.Log("ロビーに入りました。");
 
        // ルームに入室する
        PhotonNetwork.JoinRandomRoom();
    }
 
    // ルームに入室すると呼ばれる
    void OnJoinedRoom() {
        Debug.Log("ルームへ入室しました。");
    }
 
    // ルームの入室に失敗すると呼ばれる
    void OnPhotonRandomJoinFailed() {
        Debug.Log("ルームの入室に失敗しました。");
 
        // ルームがないと入室に失敗するため、その時は自分で作る
        // 引数でルーム名を指定できる
        PhotonNetwork.CreateRoom("myRoomName");
    }

 
    void Update() {
 
        // 生成位置をランダムな座標にする
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 pos = new Vector3(x, y, z);
 
        // 左クリックをしたらマッチング環境にCubeのインスタンスを生成する
        if (Input.GetMouseButtonDown(0)) {
 
            // 第1引数にResourcesフォルダの中にあるプレハブの名前(文字列)
            // 第2引数にposition
            // 第3引数にrotation
            // 第4引数にView ID(指定しない場合は0)
            GameObject obj = PhotonNetwork.Instantiate("Cube", pos, Quaternion.identity, 0);
 
            // 生成したオブジェクトに力を加える
            Rigidbody objRB = obj.GetComponent<Rigidbody>();
        }
    }

} 