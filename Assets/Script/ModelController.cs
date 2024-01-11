using UnityEngine;
using System.Collections.Generic;

public class ModelController : MonoBehaviour
{


//….. 承前
public void Next()
	{
		int nextIndex = currentIndex + 1;

		if (nextIndex >= models.Count)
		{
			nextIndex = 0;
		}

		ChangeModel(nextIndex);
	}

	public void Previous()
	{
		int previousIndex = currentIndex - 1;

		if (previousIndex < 0)
		{
			previousIndex = models.Count - 1;
		}

		ChangeModel(previousIndex);
	}


	// 表示可能なモデルのリスト
	public List<GameObject> models;

	// リストの内現在選択されているゲームオブジェクトを把握しておく
	private int currentIndex;

	// リストの先頭のモデルを最初に表示する
	public void Start()
	{
		ChangeModel(0);
	}

	// 表示されていたモデルを非表示にし、新しいモデルを表示する
	public void ChangeModel(int newIndex)
	{
		models[currentIndex].SetActive(false);
		models[newIndex].SetActive(true);

		currentIndex = newIndex;
	}
}

