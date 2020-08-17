using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataReader<T>
{
	bool Read(ref T t);
	bool Read(ref T t, string path);
	bool ReadAsyn(ref T t);
	bool ReadAsyn(ref T t, string path);
	void Close();
}