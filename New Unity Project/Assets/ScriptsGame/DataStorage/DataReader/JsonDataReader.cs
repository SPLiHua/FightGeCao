using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonDataReader<T> : IDataReader<T>
{
	public void Close()
	{

	}

	public bool Read(ref T t)
	{
		//读取xit默认存放地址
		return Read(ref t, "");
	}

	public bool Read(ref T t, string path)
	{
		if (!File.Exists(path))
		{
			return false;
		}
		//string json = File.ReadAllText(path);      另一种用法
		StreamReader stream = new StreamReader(path);
		if (stream == null)
		{
			return false;
		}
		string json = stream.ReadToEnd();
		if (json.Length > 0)
		{
			t = JsonUtility.FromJson<T>(json);
			Debug.Log(string.Format("{0}:{1}", t.GetType().Name, "读取成功"));
			return true;
		}
		Debug.Log(string.Format("{0}:{1}", t.GetType().Name, "读取成功"));
		return false;
	}

	public bool ReadAsyn(ref T t)
	{
		return false;
	}

	public bool ReadAsyn(ref T t, string path)
	{
		return false;
	}
}
