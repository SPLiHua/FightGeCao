using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;

public class JsonDataWriter<T> : IDataWriter<T>
{
	public void Write(T t)
	{
		//todo  存储持久化路径，持久化路径还未封装
		Write(t);
	}

	public void Write(T t, string path)
	{
		// if (!File.Exists(path))
		// {
		// 	File.Create(path);
		// }
		try
		{
			string jsonValue = JsonUtility.ToJson(t, true);
			File.WriteAllText(path, jsonValue);
			Debug.Log(string.Format("{0}:{1}", t.GetType().Name, "写入成功"));

		}
		catch (Exception e)
		{
			Debug.Log(string.Format("{0}{1}:{2}", t.GetType().Name, "写入失败", e));
		}
	}

	public void WriteAsyn(T t)
	{
		//StartCoroutine(WriterCallBack(t));
	}

	private IEnumerator WriteCallBack(T t)
	{
		Write(t);
		yield break;
	}

	public void WriteAsyn(T t, string path)
	{
		//StartCoroutine(WriterCallBack(t, saveSetting));
	}

	private IEnumerator WriteCallBack(T t, string path)
	{
		Write(t, path);
		yield break;
	}

	public void Flush()
	{

	}

	public void Close()
	{

	}
}
