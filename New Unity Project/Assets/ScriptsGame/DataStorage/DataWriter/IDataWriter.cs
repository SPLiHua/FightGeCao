using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataWriter<T>
{
	void Write(T t);
	void Write(T t, string path);
	void WriteAsyn(T t);
	void WriteAsyn(T t, string path);

	void Flush();
	void Close();
}
