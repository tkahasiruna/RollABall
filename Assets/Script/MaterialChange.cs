using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;

//追跡されたARフェイスのマテリアルを更新するクラス
public class MaterialChange : MonoBehaviour


{
    // Define the function template accepted by this event　(このイベントに受け取られる関数テンプレートを定義する)
    public ARFaceManager arFaceManager;

    //反復処理されるマテリアルのリスト 
    public List<Material> materials;

    //現在選択されているマテリアルのインデックス
    private int index;

    //引数として文字列を渡すUnity Event
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
    public StringUnityEvent materialUpdated;


    // …. 前のスライドで作成したフィールド
    // 次のマテリアルに変更、最後まで来たらループ
    public void NextMaterial()
    {
        int nextIndex = index + 1;
        if (nextIndex >= materials.Count)
        {
            nextIndex = 0;
        }
        ChangeMaterial(nextIndex);
    }

    public void ChangeMaterial(int newMaterialIndex)
    {
        Material newMaterial = materials[newMaterialIndex];
        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = newMaterial;
        }

        index = newMaterialIndex;
        materialUpdated.Invoke(newMaterial.name);



    }
    
	// …. 前のスライドで作成したフィールド
// …. 前のスライドで作成したメソッド

public void Start()
    {
        ChangeMaterial(0);
    }

    public void OnEnable()
    {
        arFaceManager.facesChanged += FaceUpdated;
    }

    public void OnDisable()
    {
        arFaceManager.facesChanged -= FaceUpdated;
    }

    public void FaceUpdated(ARFacesChangedEventArgs args)
    {
        if (args.added.Count > 0)
        {
            ChangeMaterial(index);
        }
    }
}




